using MunicipalLibrary.Options.Data;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace MunicipalLibrary
{
    public partial class AddReader : Form
    {
        public AddReader()
        {
            InitializeComponent();
        }

        private void AddReader_Load(object sender, EventArgs e)
        {
            ReaderRandom();

            dtpDateAdded.Format = DateTimePickerFormat.Custom;
        }

        private void ReaderRandom()
        {
            Random random = new Random();
            string randomString = "";

            randomString += (char)random.Next('A', 'Z' + 1);
            randomString += (char)random.Next('A', 'Z' + 1);

            randomString += random.Next(0, 10);
            randomString += random.Next(0, 10);
            randomString += random.Next(0, 10);
            randomString += random.Next(0, 10);

            tbPersNo.Text = randomString;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbSurname.Text != "" && tbContact.Text != "" && tbEmail.Text != "")
            {
                DateTime selectedDate = dtpDateAdded.Value;

                OracleDB db = new OracleDB();
                db.OpenConnection();

                OracleCommand cmd = new OracleCommand("INSERT INTO READER (READERNAME, READERSURNAME, READERCONTACT, READEREMAIL, READERPERSNO, DATEADDED) " +
                    "VALUES (:READERNAME, :READERSURNAME, :READERCONTACT, :READEREMAIL, :READERPERSNO, :DATEADDED)", db.GetConnection());

                cmd.Parameters.Add(":READERNAME", OracleDbType.Varchar2).Value = tbName.Text.ToString();
                cmd.Parameters.Add(":READERSURNAME", OracleDbType.Varchar2).Value = tbSurname.Text.ToString();
                cmd.Parameters.Add(":READERCONTACT", OracleDbType.Varchar2).Value = tbContact.Text.ToString();
                cmd.Parameters.Add(":READEREMAIL", OracleDbType.Varchar2).Value = tbEmail.Text.ToString();
                cmd.Parameters.Add(":READERPERSNO", OracleDbType.Varchar2).Value = tbPersNo.Text.ToString();
                cmd.Parameters.Add(":DATEADDED", OracleDbType.Date).Value = selectedDate;
                cmd.BindByName = true;

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Reader added");
                else
                    MessageBox.Show("Reader do not added!");

                db.CloseConnection();
                ClearString();
            }
            else
            {
                MessageBox.Show("Text box can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearString()
        {
            tbName.Clear();
            tbSurname.Clear();
            tbContact.Clear();
            tbEmail.Clear();
            ReaderRandom();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data!", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
