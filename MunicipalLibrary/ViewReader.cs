using MunicipalLibrary.Options.Data;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace MunicipalLibrary
{
    public partial class ViewReader : Form
    {
        public ViewReader()
        {
            InitializeComponent();
            dgReaderBase.AllowUserToAddRows = false;
        }

        private void ViewReader_Load(object sender, EventArgs e)
        {
            OracleDB db = new OracleDB();
            OracleDataAdapter oda = new OracleDataAdapter("SELECT * FROM READER", db.GetConnection());
            DataTable dt = new DataTable();
            oda.Fill(dt);

            dgReaderBase.DataSource = dt;

            dtpDateAdded.Format = DateTimePickerFormat.Custom;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpDateAdded.Value;

            OracleDB db = new OracleDB();
            OracleCommand cmd = new OracleCommand("UPDATE READER SET READERNAME = :READERNAME, READERSURNAME = :READERSURNAME, " +
                "READERCONTACT = :READERCONTACT, READEREMAIL = :READEREMAIL, READERPERSNO = :READERPERSNO, " +
                "DATEADDED = :DATEADDED WHERE READERID = :READERID", db.GetConnection());

            cmd.Parameters.Add(":READERID", OracleDbType.Int32).Value = int.Parse(RowId.ToString());
            cmd.Parameters.Add(":READERNAME", OracleDbType.Varchar2).Value = tbName.Text.ToString();
            cmd.Parameters.Add(":READERSURNAME", OracleDbType.Varchar2).Value = tbSurname.Text.ToString();
            cmd.Parameters.Add(":READERCONTACT", OracleDbType.Varchar2).Value = tbContact.Text.ToString();
            cmd.Parameters.Add(":READEREMAIL", OracleDbType.Varchar2).Value = tbEmail.Text.ToString();
            cmd.Parameters.Add(":READERPERSNO", OracleDbType.Varchar2).Value = tbPersNo.Text.ToString();
            cmd.Parameters.Add(":DATEADDED", OracleDbType.Date).Value = selectedDate;
            cmd.BindByName = true;

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                OracleDB db = new OracleDB();
                OracleCommand cmd = new OracleCommand("DELETE FROM READER WHERE READERID = " + RowId + "", db.GetConnection());
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
        }

        int ReaderId;
        Int32 RowId;
        private void dgReaderBase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgReaderBase.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ReaderId = int.Parse(dgReaderBase.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            OracleDB db = new OracleDB();
            db.OpenConnection();

            OracleCommand cmd = new OracleCommand("SELECT * FROM READER WHERE READERID = " + ReaderId + "", db.GetConnection());
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds);

            RowId = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());

            tbName.Text = ds.Tables[0].Rows[0][1].ToString();
            tbSurname.Text = ds.Tables[0].Rows[0][2].ToString();
            tbContact.Text = ds.Tables[0].Rows[0][3].ToString();
            tbEmail.Text = ds.Tables[0].Rows[0][4].ToString();
            tbPersNo.Text = ds.Tables[0].Rows[0][5].ToString();
            dtpDateAdded.Text = ds.Tables[0].Rows[0][6].ToString();

            db.CloseConnection();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            (dgReaderBase.DataSource as DataTable).DefaultView.RowFilter = $"READERNAME LIKE '%{tbSearch.Text}%' " +
                $"OR READERSURNAME LIKE '%{tbSearch.Text}%' OR READERPERSNO LIKE '%{tbSearch.Text}%'";
        }
    }
}
