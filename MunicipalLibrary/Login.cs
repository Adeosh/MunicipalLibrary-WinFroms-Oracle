using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MunicipalLibrary.Options.Data;
using Oracle.ManagedDataAccess.Client;

namespace MunicipalLibrary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.tbName.AutoSize = false;
            this.tbName.Size = new Size(this.tbPass.Width = 356, this.tbPass.Height = 64);
            this.tbPass.AutoSize = false;
            this.tbPass.Size = new Size(this.tbPass.Width = 356, this.tbPass.Height = 64);
            this.tbPass.UseSystemPasswordChar = false;

            tbName.Text = "Enter a name";
            tbName.ForeColor = Color.LightGray;

            tbPass.Text = "Enter the password";
            tbPass.ForeColor = Color.LightGray;
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

        private void lblMinimized_MouseLeave(object sender, EventArgs e)
        {
            lblMinimized.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void lblRegister_MouseEnter(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.FromArgb(76, 84, 84);
        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.FromArgb(107, 203, 203);
        }

        Point lastPoint;
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void lblAuth_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void lblAuth_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        #region BE
        private async void Login_Load(object sender, EventArgs e)
        {
            while (true)
            {
                for (byte r = 105, g = 201, b = 201; r <= 240 & g <= 254 & b <= 254; r += 4, g += 2, b += 2, await Task.Delay(150))
                {
                    lblAuth.ForeColor = Color.FromArgb(r, g, b);
                }

                for (byte r = 240, g = 255, b = 255; r <= 105 & g <= 201 & b <= 201; r -= 4, g -= 2, b -= 2, await Task.Delay(150))
                {
                    lblAuth.ForeColor = Color.FromArgb(r, g, b);
                }

                lblAuth.ForeColor = Color.FromArgb(156, 156, 164);
                Thread.Sleep(500);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String adminName = tbName.Text;
            String adminPass = tbPass.Text;

            OracleDB db = new OracleDB();
            DataTable dt = new DataTable();
            OracleDataAdapter oda = new OracleDataAdapter();

            OracleCommand cmd = new OracleCommand("SELECT * FROM ADMINISTRATOR " +
                "WHERE ADMINNAME = :ADMINNAME AND ADMINPASS = :ADMINPASS", db.GetConnection());

            cmd.Parameters.Add(":ADMINNAME", OracleDbType.Varchar2).Value = adminName;
            cmd.Parameters.Add(":ADMINPASS", OracleDbType.Varchar2).Value = adminPass;

            oda.SelectCommand = cmd;
            oda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                MainMenu main = new MainMenu();
                main.Show();
            }
            else
            {
                MessageBox.Show("Input error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #endregion
    }
}
