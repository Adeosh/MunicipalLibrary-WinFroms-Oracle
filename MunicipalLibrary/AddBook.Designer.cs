namespace MunicipalLibrary
{
    partial class AddBook
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
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pAddBook = new System.Windows.Forms.Panel();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.pSide = new System.Windows.Forms.Panel();
            this.pTitle = new System.Windows.Forms.Panel();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbReleaseDate = new System.Windows.Forms.TextBox();
            this.pAuthor = new System.Windows.Forms.Panel();
            this.pPrice = new System.Windows.Forms.Panel();
            this.pQuantity = new System.Windows.Forms.Panel();
            this.pReleaseDate = new System.Windows.Forms.Panel();
            this.btnCancel = new MunicipalLibrary.Options.Elements.CustomButton();
            this.btnSave = new MunicipalLibrary.Options.Elements.CustomButton();
            this.pAddBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblTitle.Location = new System.Drawing.Point(140, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(47, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // pAddBook
            // 
            this.pAddBook.Controls.Add(this.lblAddBook);
            this.pAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAddBook.Location = new System.Drawing.Point(120, 0);
            this.pAddBook.Name = "pAddBook";
            this.pAddBook.Size = new System.Drawing.Size(380, 40);
            this.pAddBook.TabIndex = 2;
            // 
            // lblAddBook
            // 
            this.lblAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddBook.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblAddBook.Location = new System.Drawing.Point(0, 0);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(380, 40);
            this.lblAddBook.TabIndex = 8;
            this.lblAddBook.Text = "Add Book";
            this.lblAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblAuthor.Location = new System.Drawing.Point(140, 150);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(67, 19);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReleaseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblReleaseDate.Location = new System.Drawing.Point(140, 300);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(113, 19);
            this.lblReleaseDate.TabIndex = 4;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPurchaseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblPurchaseDate.Location = new System.Drawing.Point(140, 350);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(127, 19);
            this.lblPurchaseDate.TabIndex = 5;
            this.lblPurchaseDate.Text = "Purchase Date";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblPrice.Location = new System.Drawing.Point(140, 200);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 19);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblQuantity.Location = new System.Drawing.Point(140, 250);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 19);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTitle.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbTitle.Location = new System.Drawing.Point(280, 100);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(200, 20);
            this.tbTitle.TabIndex = 8;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CalendarFont = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpPurchaseDate.Location = new System.Drawing.Point(280, 350);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPurchaseDate.TabIndex = 9;
            // 
            // pSide
            // 
            this.pSide.BackgroundImage = global::MunicipalLibrary.Properties.Resources.books_1;
            this.pSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSide.Location = new System.Drawing.Point(0, 0);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(120, 500);
            this.pSide.TabIndex = 0;
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pTitle.Location = new System.Drawing.Point(280, 120);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(200, 3);
            this.pTitle.TabIndex = 12;
            // 
            // tbAuthor
            // 
            this.tbAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAuthor.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbAuthor.Location = new System.Drawing.Point(280, 150);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(200, 20);
            this.tbAuthor.TabIndex = 13;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbPrice.Location = new System.Drawing.Point(280, 200);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(200, 20);
            this.tbPrice.TabIndex = 14;
            // 
            // tbQuantity
            // 
            this.tbQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuantity.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbQuantity.Location = new System.Drawing.Point(280, 250);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(200, 20);
            this.tbQuantity.TabIndex = 15;
            // 
            // tbReleaseDate
            // 
            this.tbReleaseDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReleaseDate.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReleaseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbReleaseDate.Location = new System.Drawing.Point(280, 300);
            this.tbReleaseDate.Name = "tbReleaseDate";
            this.tbReleaseDate.Size = new System.Drawing.Size(200, 20);
            this.tbReleaseDate.TabIndex = 16;
            // 
            // pAuthor
            // 
            this.pAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pAuthor.Location = new System.Drawing.Point(280, 170);
            this.pAuthor.Name = "pAuthor";
            this.pAuthor.Size = new System.Drawing.Size(200, 3);
            this.pAuthor.TabIndex = 13;
            // 
            // pPrice
            // 
            this.pPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pPrice.Location = new System.Drawing.Point(280, 220);
            this.pPrice.Name = "pPrice";
            this.pPrice.Size = new System.Drawing.Size(200, 3);
            this.pPrice.TabIndex = 13;
            // 
            // pQuantity
            // 
            this.pQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pQuantity.Location = new System.Drawing.Point(280, 270);
            this.pQuantity.Name = "pQuantity";
            this.pQuantity.Size = new System.Drawing.Size(200, 3);
            this.pQuantity.TabIndex = 13;
            // 
            // pReleaseDate
            // 
            this.pReleaseDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pReleaseDate.Location = new System.Drawing.Point(280, 320);
            this.pReleaseDate.Name = "pReleaseDate";
            this.pReleaseDate.Size = new System.Drawing.Size(200, 3);
            this.pReleaseDate.TabIndex = 13;
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
            this.btnCancel.Location = new System.Drawing.Point(330, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSave.BorderRadius = 20;
            this.btnSave.BoredrSize = 2;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnSave.Location = new System.Drawing.Point(144, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pAuthor);
            this.Controls.Add(this.pPrice);
            this.Controls.Add(this.pQuantity);
            this.Controls.Add(this.pReleaseDate);
            this.Controls.Add(this.tbReleaseDate);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.pAddBook);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.pAddBook.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.Panel pSide;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pAddBook;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private Options.Elements.CustomButton btnSave;
        private Options.Elements.CustomButton btnCancel;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbReleaseDate;
        private System.Windows.Forms.Panel pAuthor;
        private System.Windows.Forms.Panel pPrice;
        private System.Windows.Forms.Panel pQuantity;
        private System.Windows.Forms.Panel pReleaseDate;
    }
}