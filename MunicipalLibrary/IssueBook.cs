using MunicipalLibrary.Options.Data;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace MunicipalLibrary
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            dtpBookIssueDate.Format = DateTimePickerFormat.Custom;

            OracleDB db = new OracleDB();
            OracleCommand cmd = new OracleCommand();
            db.OpenConnection();

            cmd = new OracleCommand("SELECT TITLE FROM LIBRARY", db.GetConnection());
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    cbBookTitle.Items.Add(dr.GetString(i));
                }
            }
            dr.Close();
            db.CloseConnection();
        }

        int bCount;
        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            if (tbPersNo.Text != "")
            {
                String persNo = tbPersNo.Text;

                OracleDB db = new OracleDB();
                OracleCommand cmd = new OracleCommand();

                db.OpenConnection();
                cmd.Connection = db.GetConnection();
                cmd.CommandText = "SELECT * FROM READER WHERE READERPERSNO = '" + persNo + "'";
                cmd.BindByName = true;
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);

                cmd.CommandText = "SELECT COUNT(REAPERSNO) FROM RENTAL WHERE REAPERSNO = '" + persNo + "' AND BOOKRETURNDATE IS NULL";
                cmd.BindByName = true;
                OracleDataAdapter oda2 = new OracleDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                oda2.Fill(ds2);
                bCount = int.Parse(ds2.Tables[0].Rows[0][0].ToString());

                if (ds.Tables[0].Rows.Count != 0)
                {
                    tbReaderName.Text = ds.Tables[0].Rows[0][1].ToString();
                    tbReaderSurname.Text = ds.Tables[0].Rows[0][2].ToString();
                    tbReaderContact.Text = ds.Tables[0].Rows[0][3].ToString();
                    tbReaderEmail.Text = ds.Tables[0].Rows[0][4].ToString();
                }
                else
                {
                    tbReaderName.Clear();
                    tbReaderSurname.Clear();
                    tbReaderContact.Clear();
                    tbReaderEmail.Clear();
                    MessageBox.Show("Invalid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbPersNo.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPersNo_TextChanged(object sender, EventArgs e)
        {
            if (tbPersNo.Text == "")
            {
                tbReaderName.Clear();
                tbReaderSurname.Clear();
                tbReaderContact.Clear();
                tbReaderEmail.Clear();
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (tbReaderName.Text != "" || tbReaderSurname.Text != "")
            {
                if (cbBookTitle.SelectedIndex != -1 && bCount <= 2)
                {
                    DateTime selectedDate = dtpBookIssueDate.Value;
                    String persNo = tbPersNo.Text;

                    OracleDB db = new OracleDB();
                    db.OpenConnection();
                    OracleCommand cmd = new OracleCommand("INSERT INTO RENTAL (REANAME, REASURNAME, REACONTACT, REAEMAIL," +
                        "REAPERSNO, BOOKTITLE, BOOKISSUEDATE) VALUES (:REANAME, :REASURNAME, :REACONTACT, :REAEMAIL," +
                        ":REAPERSNO, :BOOKTITLE, :BOOKISSUEDATE)", db.GetConnection());

                    cmd.Parameters.Add(":REANAME", OracleDbType.Varchar2).Value = tbReaderName.Text;
                    cmd.Parameters.Add(":REASURNAME", OracleDbType.Varchar2).Value = tbReaderSurname.Text;
                    cmd.Parameters.Add(":REACONTACT", OracleDbType.Varchar2).Value = tbReaderContact.Text;
                    cmd.Parameters.Add(":REAEMAIL", OracleDbType.Varchar2).Value = tbReaderEmail.Text;
                    cmd.Parameters.Add(":REAPERSNO", OracleDbType.Varchar2).Value = persNo;
                    cmd.Parameters.Add(":BOOKTITLE", OracleDbType.Varchar2).Value = cbBookTitle.Text;
                    cmd.Parameters.Add(":BOOKISSUEDATE", OracleDbType.Date).Value = selectedDate;
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();

                    MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Book or Maximum number of book has been Issued.", "No Book Selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter valid Personal No", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
