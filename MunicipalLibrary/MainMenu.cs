using MunicipalLibrary.Options.Elements;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalLibrary
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            stripMainMenu.Renderer = new CustomRender();
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
            lblCloseButton.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void lblCloseButton_MouseLeave(object sender, EventArgs e)
        {
            lblCloseButton.ForeColor = Color.FromArgb(107, 203, 203);
        }

        private void lblMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMinimized_MouseEnter(object sender, EventArgs e)
        {
            lblMinimized.ForeColor = Color.FromArgb(230, 230, 230);
        }

        private void lblMinimized_MouseLeave(object sender, EventArgs e)
        {
            lblMinimized.ForeColor = Color.FromArgb(107, 203, 203);
        }

        Point lastPoint;
        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook viewBook = new ViewBook();
            viewBook.Show();
        }

        private void addReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReader addReader = new AddReader();
            addReader.Show();
        }

        private void viewReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewReader viewReader = new ViewReader();
            viewReader.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook issueBook = new IssueBook();
            issueBook.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
        }

        private void rentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalDetails rentalDetails = new RentalDetails();
            rentalDetails.Show();
        }
    }
}
