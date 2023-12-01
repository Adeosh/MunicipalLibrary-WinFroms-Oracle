namespace MunicipalLibrary
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.stripMainMenu = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMinimized = new System.Windows.Forms.Label();
            this.lblCloseButton = new System.Windows.Forms.Label();
            this.stripMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripMainMenu
            // 
            resources.ApplyResources(this.stripMainMenu, "stripMainMenu");
            this.stripMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.stripMainMenu.GripMargin = new System.Windows.Forms.Padding(22, 2, 0, 2);
            this.stripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.readerToolStripMenuItem,
            this.issueBookToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.rentalToolStripMenuItem});
            this.stripMainMenu.Name = "stripMainMenu";
            // 
            // booksToolStripMenuItem
            // 
            resources.ApplyResources(this.booksToolStripMenuItem, "booksToolStripMenuItem");
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.viewBooksToolStripMenuItem});
            this.booksToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.booksToolStripMenuItem.Image = global::MunicipalLibrary.Properties.Resources.home;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            // 
            // addNewBookToolStripMenuItem
            // 
            resources.ApplyResources(this.addNewBookToolStripMenuItem, "addNewBookToolStripMenuItem");
            this.addNewBookToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.addNewBookToolStripMenuItem.Image = global::MunicipalLibrary.Properties.Resources.add_book;
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // viewBooksToolStripMenuItem
            // 
            resources.ApplyResources(this.viewBooksToolStripMenuItem, "viewBooksToolStripMenuItem");
            this.viewBooksToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.viewBooksToolStripMenuItem.Image = global::MunicipalLibrary.Properties.Resources.view_book;
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
            // 
            // readerToolStripMenuItem
            // 
            resources.ApplyResources(this.readerToolStripMenuItem, "readerToolStripMenuItem");
            this.readerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReaderToolStripMenuItem,
            this.viewReaderToolStripMenuItem});
            this.readerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.readerToolStripMenuItem.Image = global::MunicipalLibrary.Properties.Resources.options;
            this.readerToolStripMenuItem.Name = "readerToolStripMenuItem";
            // 
            // addReaderToolStripMenuItem
            // 
            resources.ApplyResources(this.addReaderToolStripMenuItem, "addReaderToolStripMenuItem");
            this.addReaderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.addReaderToolStripMenuItem.Image = global::MunicipalLibrary.Properties.Resources.add_reader;
            this.addReaderToolStripMenuItem.Name = "addReaderToolStripMenuItem";
            this.addReaderToolStripMenuItem.Click += new System.EventHandler(this.addReaderToolStripMenuItem_Click);
            // 
            // viewReaderToolStripMenuItem
            // 
            resources.ApplyResources(this.viewReaderToolStripMenuItem, "viewReaderToolStripMenuItem");
            this.viewReaderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.viewReaderToolStripMenuItem.Image = global::MunicipalLibrary.Properties.Resources.view_reader;
            this.viewReaderToolStripMenuItem.Name = "viewReaderToolStripMenuItem";
            this.viewReaderToolStripMenuItem.Click += new System.EventHandler(this.viewReaderToolStripMenuItem_Click);
            // 
            // issueBookToolStripMenuItem
            // 
            resources.ApplyResources(this.issueBookToolStripMenuItem, "issueBookToolStripMenuItem");
            this.issueBookToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.issueBookToolStripMenuItem.Image = global::MunicipalLibrary.Properties.Resources.issue;
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.issueBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            resources.ApplyResources(this.returnBookToolStripMenuItem, "returnBookToolStripMenuItem");
            this.returnBookToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.returnBookToolStripMenuItem.Image = global::MunicipalLibrary.Properties.Resources._return;
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // rentalToolStripMenuItem
            // 
            resources.ApplyResources(this.rentalToolStripMenuItem, "rentalToolStripMenuItem");
            this.rentalToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.rentalToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.rentalToolStripMenuItem.Image = global::MunicipalLibrary.Properties.Resources.details;
            this.rentalToolStripMenuItem.Name = "rentalToolStripMenuItem";
            this.rentalToolStripMenuItem.Click += new System.EventHandler(this.rentalToolStripMenuItem_Click);
            // 
            // lblMinimized
            // 
            resources.ApplyResources(this.lblMinimized, "lblMinimized");
            this.lblMinimized.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblMinimized.Name = "lblMinimized";
            this.lblMinimized.Click += new System.EventHandler(this.lblMinimized_Click);
            this.lblMinimized.MouseEnter += new System.EventHandler(this.lblMinimized_MouseEnter);
            this.lblMinimized.MouseLeave += new System.EventHandler(this.lblMinimized_MouseLeave);
            // 
            // lblCloseButton
            // 
            resources.ApplyResources(this.lblCloseButton, "lblCloseButton");
            this.lblCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.lblCloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblCloseButton.Name = "lblCloseButton";
            this.lblCloseButton.Click += new System.EventHandler(this.lblCloseButton_Click);
            this.lblCloseButton.MouseEnter += new System.EventHandler(this.lblCloseButton_MouseEnter);
            this.lblCloseButton.MouseLeave += new System.EventHandler(this.lblCloseButton_MouseLeave);
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MunicipalLibrary.Properties.Resources.main_library;
            this.Controls.Add(this.lblMinimized);
            this.Controls.Add(this.lblCloseButton);
            this.Controls.Add(this.stripMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            this.stripMainMenu.ResumeLayout(false);
            this.stripMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip stripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalToolStripMenuItem;
        private System.Windows.Forms.Label lblMinimized;
        private System.Windows.Forms.Label lblCloseButton;
    }
}