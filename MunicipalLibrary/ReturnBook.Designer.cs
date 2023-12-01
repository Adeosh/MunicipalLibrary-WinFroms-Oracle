namespace MunicipalLibrary
{
    partial class ReturnBook
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
            this.pTop = new System.Windows.Forms.Panel();
            this.lblReturnBook = new System.Windows.Forms.Label();
            this.pLeftSide = new System.Windows.Forms.Panel();
            this.pPersNo = new System.Windows.Forms.Panel();
            this.btnSearchReader = new MunicipalLibrary.Options.Elements.CustomButton();
            this.btnRefresh = new MunicipalLibrary.Options.Elements.CustomButton();
            this.btnCancel = new MunicipalLibrary.Options.Elements.CustomButton();
            this.lblPersNo = new System.Windows.Forms.Label();
            this.tbPersNo = new System.Windows.Forms.TextBox();
            this.pbReader = new System.Windows.Forms.PictureBox();
            this.pReturn = new System.Windows.Forms.Panel();
            this.dgRentalBase = new System.Windows.Forms.DataGridView();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookIssueDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.pBookTitle = new System.Windows.Forms.Panel();
            this.pBookIssue = new System.Windows.Forms.Panel();
            this.tbBookIssueDate = new System.Windows.Forms.TextBox();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.dtpBookReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnReturnBook = new MunicipalLibrary.Options.Elements.CustomButton();
            this.pTop.SuspendLayout();
            this.pLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReader)).BeginInit();
            this.pReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRentalBase)).BeginInit();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.lblReturnBook);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(800, 80);
            this.pTop.TabIndex = 0;
            // 
            // lblReturnBook
            // 
            this.lblReturnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReturnBook.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblReturnBook.Location = new System.Drawing.Point(0, 0);
            this.lblReturnBook.Name = "lblReturnBook";
            this.lblReturnBook.Size = new System.Drawing.Size(800, 80);
            this.lblReturnBook.TabIndex = 10;
            this.lblReturnBook.Text = "Return Book";
            this.lblReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLeftSide
            // 
            this.pLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.pLeftSide.Controls.Add(this.pPersNo);
            this.pLeftSide.Controls.Add(this.btnSearchReader);
            this.pLeftSide.Controls.Add(this.btnRefresh);
            this.pLeftSide.Controls.Add(this.btnCancel);
            this.pLeftSide.Controls.Add(this.lblPersNo);
            this.pLeftSide.Controls.Add(this.tbPersNo);
            this.pLeftSide.Controls.Add(this.pbReader);
            this.pLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeftSide.Location = new System.Drawing.Point(0, 80);
            this.pLeftSide.Name = "pLeftSide";
            this.pLeftSide.Size = new System.Drawing.Size(260, 520);
            this.pLeftSide.TabIndex = 2;
            // 
            // pPersNo
            // 
            this.pPersNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pPersNo.Location = new System.Drawing.Point(59, 286);
            this.pPersNo.Name = "pPersNo";
            this.pPersNo.Size = new System.Drawing.Size(148, 4);
            this.pPersNo.TabIndex = 45;
            // 
            // btnSearchReader
            // 
            this.btnSearchReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnSearchReader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnSearchReader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSearchReader.BorderRadius = 20;
            this.btnSearchReader.BoredrSize = 2;
            this.btnSearchReader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchReader.FlatAppearance.BorderSize = 0;
            this.btnSearchReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReader.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchReader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnSearchReader.Location = new System.Drawing.Point(59, 300);
            this.btnSearchReader.Name = "btnSearchReader";
            this.btnSearchReader.Size = new System.Drawing.Size(147, 40);
            this.btnSearchReader.TabIndex = 44;
            this.btnSearchReader.Text = "Search";
            this.btnSearchReader.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnSearchReader.UseVisualStyleBackColor = false;
            this.btnSearchReader.Click += new System.EventHandler(this.btnSearchReader_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.BoredrSize = 2;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnRefresh.Location = new System.Drawing.Point(3, 361);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 40);
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BoredrSize = 2;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnCancel.Location = new System.Drawing.Point(157, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPersNo
            // 
            this.lblPersNo.AutoSize = true;
            this.lblPersNo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblPersNo.Location = new System.Drawing.Point(55, 226);
            this.lblPersNo.Name = "lblPersNo";
            this.lblPersNo.Size = new System.Drawing.Size(154, 19);
            this.lblPersNo.TabIndex = 41;
            this.lblPersNo.Text = "Enter Personal №";
            // 
            // tbPersNo
            // 
            this.tbPersNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.tbPersNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPersNo.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPersNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbPersNo.Location = new System.Drawing.Point(60, 268);
            this.tbPersNo.Name = "tbPersNo";
            this.tbPersNo.Size = new System.Drawing.Size(146, 20);
            this.tbPersNo.TabIndex = 40;
            this.tbPersNo.TextChanged += new System.EventHandler(this.tbPersNo_TextChanged);
            // 
            // pbReader
            // 
            this.pbReader.BackgroundImage = global::MunicipalLibrary.Properties.Resources.user;
            this.pbReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbReader.Location = new System.Drawing.Point(60, 70);
            this.pbReader.Name = "pbReader";
            this.pbReader.Size = new System.Drawing.Size(140, 120);
            this.pbReader.TabIndex = 0;
            this.pbReader.TabStop = false;
            // 
            // pReturn
            // 
            this.pReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.pReturn.Controls.Add(this.btnReturnBook);
            this.pReturn.Controls.Add(this.dtpBookReturnDate);
            this.pReturn.Controls.Add(this.pBookTitle);
            this.pReturn.Controls.Add(this.pBookIssue);
            this.pReturn.Controls.Add(this.tbBookIssueDate);
            this.pReturn.Controls.Add(this.tbBookTitle);
            this.pReturn.Controls.Add(this.lblReturnDate);
            this.pReturn.Controls.Add(this.lblBookTitle);
            this.pReturn.Controls.Add(this.lblBookIssueDate);
            this.pReturn.Location = new System.Drawing.Point(266, 348);
            this.pReturn.Name = "pReturn";
            this.pReturn.Size = new System.Drawing.Size(522, 252);
            this.pReturn.TabIndex = 3;
            // 
            // dgRentalBase
            // 
            this.dgRentalBase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.dgRentalBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRentalBase.Location = new System.Drawing.Point(266, 80);
            this.dgRentalBase.Name = "dgRentalBase";
            this.dgRentalBase.Size = new System.Drawing.Size(522, 262);
            this.dgRentalBase.TabIndex = 4;
            this.dgRentalBase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRentalBase_CellClick);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblBookTitle.Location = new System.Drawing.Point(64, 32);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(95, 19);
            this.lblBookTitle.TabIndex = 49;
            this.lblBookTitle.Text = "Book Title";
            // 
            // lblBookIssueDate
            // 
            this.lblBookIssueDate.AutoSize = true;
            this.lblBookIssueDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBookIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblBookIssueDate.Location = new System.Drawing.Point(64, 82);
            this.lblBookIssueDate.Name = "lblBookIssueDate";
            this.lblBookIssueDate.Size = new System.Drawing.Size(141, 19);
            this.lblBookIssueDate.TabIndex = 48;
            this.lblBookIssueDate.Text = "Book Issue Date";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblReturnDate.Location = new System.Drawing.Point(64, 134);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(157, 19);
            this.lblReturnDate.TabIndex = 50;
            this.lblReturnDate.Text = "Book Return Date";
            // 
            // pBookTitle
            // 
            this.pBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pBookTitle.Location = new System.Drawing.Point(248, 51);
            this.pBookTitle.Name = "pBookTitle";
            this.pBookTitle.Size = new System.Drawing.Size(200, 3);
            this.pBookTitle.TabIndex = 51;
            // 
            // pBookIssue
            // 
            this.pBookIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pBookIssue.Location = new System.Drawing.Point(248, 101);
            this.pBookIssue.Name = "pBookIssue";
            this.pBookIssue.Size = new System.Drawing.Size(200, 3);
            this.pBookIssue.TabIndex = 52;
            // 
            // tbBookIssueDate
            // 
            this.tbBookIssueDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbBookIssueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBookIssueDate.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBookIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbBookIssueDate.Location = new System.Drawing.Point(248, 81);
            this.tbBookIssueDate.Name = "tbBookIssueDate";
            this.tbBookIssueDate.Size = new System.Drawing.Size(200, 20);
            this.tbBookIssueDate.TabIndex = 54;
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBookTitle.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbBookTitle.Location = new System.Drawing.Point(248, 31);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(200, 20);
            this.tbBookTitle.TabIndex = 53;
            // 
            // dtpBookReturnDate
            // 
            this.dtpBookReturnDate.CalendarFont = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBookReturnDate.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBookReturnDate.Location = new System.Drawing.Point(248, 134);
            this.dtpBookReturnDate.Name = "dtpBookReturnDate";
            this.dtpBookReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBookReturnDate.TabIndex = 55;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnReturnBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnReturnBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnReturnBook.BorderRadius = 20;
            this.btnReturnBook.BoredrSize = 2;
            this.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnReturnBook.Location = new System.Drawing.Point(248, 185);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(200, 40);
            this.btnReturnBook.TabIndex = 56;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgRentalBase);
            this.Controls.Add(this.pReturn);
            this.Controls.Add(this.pLeftSide);
            this.Controls.Add(this.pTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.pTop.ResumeLayout(false);
            this.pLeftSide.ResumeLayout(false);
            this.pLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReader)).EndInit();
            this.pReturn.ResumeLayout(false);
            this.pReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRentalBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Label lblReturnBook;
        private System.Windows.Forms.Panel pLeftSide;
        private System.Windows.Forms.Panel pPersNo;
        private Options.Elements.CustomButton btnSearchReader;
        private Options.Elements.CustomButton btnRefresh;
        private Options.Elements.CustomButton btnCancel;
        private System.Windows.Forms.Label lblPersNo;
        private System.Windows.Forms.TextBox tbPersNo;
        private System.Windows.Forms.PictureBox pbReader;
        private System.Windows.Forms.Panel pReturn;
        private System.Windows.Forms.DataGridView dgRentalBase;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookIssueDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Panel pBookTitle;
        private System.Windows.Forms.Panel pBookIssue;
        private System.Windows.Forms.TextBox tbBookIssueDate;
        private System.Windows.Forms.TextBox tbBookTitle;
        private System.Windows.Forms.DateTimePicker dtpBookReturnDate;
        private Options.Elements.CustomButton btnReturnBook;
    }
}