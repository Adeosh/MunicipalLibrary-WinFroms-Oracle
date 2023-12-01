using MunicipalLibrary.Options.Data;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalLibrary
{
    public partial class RentalDetails : Form
    {
        public RentalDetails()
        {
            InitializeComponent();
        }

        private void lblCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCloseButton_MouseEnter(object sender, EventArgs e)
        {
            lblCloseButton.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void lblCloseButton_MouseLeave(object sender, EventArgs e)
        {
            lblCloseButton.ForeColor = Color.FromArgb(76, 84, 84);
        }

        private void RentalDetails_Load(object sender, EventArgs e)
        {
            OracleDB db = new OracleDB();
            OracleCommand cmd = new OracleCommand();

            db.OpenConnection();
            cmd.Connection = db.GetConnection();
            cmd.CommandText = "SELECT * FROM RENTAL WHERE BOOKRETURNDATE IS NULL";
            cmd.BindByName = true;
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dgIssuedBooks.DataSource = ds.Tables[0];

            db.OpenConnection();
            cmd.Connection = db.GetConnection();
            cmd.CommandText = "SELECT * FROM RENTAL WHERE BOOKRETURNDATE IS NOT NULL";
            cmd.BindByName = true;
            OracleDataAdapter oda2 = new OracleDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            oda2.Fill(ds2);
            dgReturnedBooks.DataSource = ds2.Tables[0];

            dgIssuedBooks.AllowUserToAddRows = false;
            dgReturnedBooks.AllowUserToAddRows = false;
        }
    }
}
