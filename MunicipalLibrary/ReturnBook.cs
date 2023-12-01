using MunicipalLibrary.Options.Data;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace MunicipalLibrary
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            dtpBookReturnDate.Format = DateTimePickerFormat.Custom;
        }

        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            OracleDB db = new OracleDB();
            db.OpenConnection();

            OracleCommand cmd = new OracleCommand("SELECT * FROM RENTAL WHERE REAPERSNO = '"+tbPersNo.Text+ "' AND BOOKRETURNDATE IS NULL", db.GetConnection());

            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dgRentalBase.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid Id or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            OracleDB db = new OracleDB();
            db.OpenConnection();

            OracleCommand cmd = new OracleCommand("UPDATE RENTAL SET BOOKRETURNDATE = '"+dtpBookReturnDate.Text+"'" +
                "WHERE REAPERSNO = '"+tbPersNo.Text+ "' AND RENTALID = '"+RowId+"'", db.GetConnection());

            cmd.ExecuteNonQuery();
            db.CloseConnection();

            MessageBox.Show("Return success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReturnBook_Load(this, null);
        }

        private void tbPersNo_TextChanged(object sender, EventArgs e)
        {
            if (tbPersNo.Text == "")
            {
                dgRentalBase.DataSource = null;
            }
        }

        String Title;
        String Date;
        Int64 RowId;
        private void dgRentalBase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRentalBase.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                RowId = Int32.Parse(dgRentalBase.Rows[e.RowIndex].Cells[0].Value.ToString());
                Title = dgRentalBase.Rows[e.RowIndex].Cells[6].Value.ToString();
                Date = dgRentalBase.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            tbBookTitle.Text = Title;
            tbBookIssueDate.Text = Date;
        }
    }
}
