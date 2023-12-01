using MunicipalLibrary.Options.Data;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace MunicipalLibrary
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
            dgBookBase.AllowUserToAddRows = false;
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            OracleDB db = new OracleDB();
            OracleDataAdapter oda = new OracleDataAdapter("SELECT * FROM LIBRARY", db.GetConnection());
            DataTable dt = new DataTable();
            oda.Fill(dt);

            dgBookBase.DataSource = dt;

            dtpPurchaseDate.Format = DateTimePickerFormat.Custom;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpPurchaseDate.Value;

            OracleDB db = new OracleDB();
            OracleCommand cmd = new OracleCommand("UPDATE LIBRARY SET TITLE = :TITLE, AUTHOR = :AUTHOR, " +
                "PRICE = :PRICE, QUANTITY = :QUANTITY, RELEASEDATE = :RELEASEDATE, " +
                "PURCHASEDATE = :PURCHASEDATE WHERE BOOKID = :BOOKID", db.GetConnection());

            cmd.Parameters.Add(":BOOKID", OracleDbType.Int32).Value = int.Parse(RowId.ToString());
            cmd.Parameters.Add(":TITLE", OracleDbType.Varchar2).Value = tbTitle.Text.ToString();
            cmd.Parameters.Add(":AUTHOR", OracleDbType.Varchar2).Value = tbAuthor.Text.ToString();
            cmd.Parameters.Add(":PRICE", OracleDbType.Int32).Value = tbPrice.Text.ToString();
            cmd.Parameters.Add(":QUANTITY", OracleDbType.Int32).Value = tbQuantity.Text.ToString();
            cmd.Parameters.Add(":RELEASEDATE", OracleDbType.Int32).Value = tbReleaseDate.Text.ToString();
            cmd.Parameters.Add(":PURCHASEDATE", OracleDbType.Date).Value = selectedDate;
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
                OracleCommand cmd = new OracleCommand("DELETE FROM LIBRARY WHERE BOOKID = " + RowId +"", db.GetConnection());
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

        int BookId;
        Int32 RowId;
        private void dgBookBase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgBookBase.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                BookId = int.Parse(dgBookBase.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            OracleDB db = new OracleDB();

            db.OpenConnection();

            OracleCommand cmd = new OracleCommand("SELECT * FROM LIBRARY WHERE BOOKID = " + BookId + "", db.GetConnection());
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds);

            RowId = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());

            tbTitle.Text = ds.Tables[0].Rows[0][1].ToString();
            tbAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            tbPrice.Text = ds.Tables[0].Rows[0][3].ToString();
            tbQuantity.Text = ds.Tables[0].Rows[0][4].ToString();
            tbReleaseDate.Text = ds.Tables[0].Rows[0][5].ToString();
            dtpPurchaseDate.Text = ds.Tables[0].Rows[0][6].ToString();

            db.CloseConnection();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            (dgBookBase.DataSource as DataTable).DefaultView.RowFilter = $"TITLE LIKE '%{tbSearch.Text}%' " +
                $"OR AUTHOR LIKE '%{tbSearch.Text}%'";
        }
    }
}
