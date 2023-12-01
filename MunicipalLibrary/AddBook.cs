using MunicipalLibrary.Options.Data;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace MunicipalLibrary
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            dtpPurchaseDate.Format = DateTimePickerFormat.Custom;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text != "" && tbAuthor.Text != "" && tbPrice.Text != "" && tbQuantity.Text != "" && tbReleaseDate.Text != "")
            {
                DateTime selectedDate = dtpPurchaseDate.Value;

                OracleDB db = new OracleDB();
                OracleCommand cmd = new OracleCommand("INSERT INTO LIBRARY (TITLE, AUTHOR, PRICE, QUANTITY, RELEASEDATE, PURCHASEDATE) " +
                    "VALUES (:TITLE, :AUTHOR, :PRICE, :QUANTITY, :RELEASEDATE, :PURCHASEDATE)", db.GetConnection());

                cmd.Parameters.Add(":TITLE", OracleDbType.Varchar2).Value = tbTitle.Text.ToString();
                cmd.Parameters.Add(":AUTHOR", OracleDbType.Varchar2).Value = tbAuthor.Text.ToString();
                cmd.Parameters.Add(":PRICE", OracleDbType.Int32).Value = tbPrice.Text.ToString();
                cmd.Parameters.Add(":QUANTITY", OracleDbType.Int32).Value = tbQuantity.Text.ToString();
                cmd.Parameters.Add(":RELEASEDATE", OracleDbType.Int32).Value = tbReleaseDate.Text.ToString();
                cmd.Parameters.Add(":PURCHASEDATE", OracleDbType.Date).Value = selectedDate;
                cmd.BindByName = true;

                db.OpenConnection();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Book added");
                else
                    MessageBox.Show("Book do not added!");

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
            tbTitle.Clear();
            tbAuthor.Clear();
            tbPrice.Clear();
            tbQuantity.Clear();
            tbReleaseDate.Clear();
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
