using MunicipalLibrary.Options.Data;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalLibrary
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            this.tbName.AutoSize = false;
            this.tbName.Size = new Size(this.tbPass.Width = 356, this.tbPass.Height = 64);
            this.tbPass.AutoSize = false;
            this.tbPass.Size = new Size(this.tbPass.Width = 356, this.tbPass.Height = 64);
            this.tbEmail.AutoSize = false;
            this.tbEmail.Size = new Size(this.tbPass.Width = 356, this.tbPass.Height = 64);
            this.tbPass.UseSystemPasswordChar = false;

            tbName.Text = "Enter a name";
            tbName.ForeColor = Color.LightGray;

            tbPass.Text = "Enter the password";
            tbPass.ForeColor = Color.LightGray;

            tbEmail.Text = "Enter your email";
            tbEmail.ForeColor = Color.LightGray;

            cbCountries.Text = "Select a country";
            cbCountries.ForeColor = Color.Black;
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

        private void lblCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCloseButton_MouseEnter(object sender, EventArgs e)
        {
            lblCloseButton.ForeColor = Color.FromArgb(76, 84, 84);
        }

        private void lblCloseButton_MouseLeave(object sender, EventArgs e)
        {
            lblCloseButton.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void lblMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMinimized_MouseEnter(object sender, EventArgs e)
        {
            lblMinimized.ForeColor = Color.FromArgb(76, 84, 84);
        }

        private void lblMinimized_Leave(object sender, EventArgs e)
        {
            lblMinimized.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void lblAuth_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void lblAuth_MouseEnter(object sender, EventArgs e)
        {
            lblAuth.ForeColor = Color.FromArgb(76, 84, 84);           
        }

        private void lblAuth_MouseLeave(object sender, EventArgs e)
        {
            lblAuth.ForeColor = Color.FromArgb(107, 203, 203);
        }

        Point lastPoint;
        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        #region BE
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "Enter a name")
            {
                MessageBox.Show("Enter a name");
            }

            if (tbPass.Text == "Enter the password")
            {
                MessageBox.Show("Enter the password");
            }

            if (tbEmail.Text == "Enter your email")
            {
                MessageBox.Show("Enter your email");
            }

            if (cbCountries.Text == "Select a country")
            {
                MessageBox.Show("Select a country");
            }

            if (IsUserChecked())
                return;

            OracleDB db = new OracleDB();
            OracleCommand cmd = new OracleCommand("INSERT INTO ADMINISTRATOR (ADMINNAME, ADMINPASS, ADMINEMAIL, ADMINCOUNTRY) " +
                "VALUES (:ADMINNAME, :ADMINPASS, :ADMINEMAIL, :ADMINCOUNTRY)", db.GetConnection());

            cmd.Parameters.Add(":ADMINNAME", OracleDbType.Varchar2).Value = tbName.Text.ToString();
            cmd.Parameters.Add(":ADMINPASS", OracleDbType.Varchar2).Value = tbPass.Text.ToString();
            cmd.Parameters.Add(":ADMINEMAIL", OracleDbType.Varchar2).Value = tbEmail.Text.ToString();
            cmd.Parameters.Add(":ADMINCOUNTRY", OracleDbType.Varchar2).Value = cbCountries.Text.ToString();
            cmd.BindByName = true;

            db.OpenConnection();

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("The account has been created!");
            else
                MessageBox.Show("The account was not created!");

            db.CloseConnection();
        }

        public Boolean IsUserChecked()
        {
            OracleDB db = new OracleDB();

            DataTable dt = new DataTable();

            OracleDataAdapter oda = new OracleDataAdapter();

            OracleCommand cmd = new OracleCommand("SELECT * FROM ADMINISTRATOR WHERE ADMINNAME = :ADMINNAME", db.GetConnection());
            cmd.Parameters.Add(":ADMINNAME", OracleDbType.Varchar2).Value = tbName.Text.ToString();
            cmd.BindByName = true;

            oda.SelectCommand = cmd;
            oda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This login already exists!");
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Guidance
        private void tbName_Enter(object sender, EventArgs e)
        {
            if (tbName.Text == "Enter a name")
            {
                tbName.Text = "";
                tbName.ForeColor = Color.Black;
            }
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                tbName.Text = "Enter a name";
                tbName.ForeColor = Color.LightGray;
            }
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            if (tbPass.Text == "Enter the password")
            {
                tbPass.UseSystemPasswordChar = true;
                tbPass.Text = "";
                tbPass.ForeColor = Color.Black;
            }
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.UseSystemPasswordChar = false;
                tbPass.Text = "Enter the password";
                tbPass.ForeColor = Color.LightGray;
            }
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Enter your email")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Black;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Enter your email";
                tbEmail.ForeColor = Color.LightGray;
            }
        }

        private void cbCountries_Enter(object sender, EventArgs e)
        {
            if (cbCountries.Text == "Select a country")
            {
                cbCountries.Text = "";
                cbCountries.ForeColor = Color.Black;
            }
        }

        private void cbCountries_Leave(object sender, EventArgs e)
        {
            if (cbCountries.Text == "")
            {
                cbCountries.Text = "Select a country";
                cbCountries.ForeColor = Color.Black;
            }
        }
        #endregion
    }
}
