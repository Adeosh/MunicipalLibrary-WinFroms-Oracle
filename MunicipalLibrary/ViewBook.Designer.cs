namespace MunicipalLibrary
{
    partial class ViewBook
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
            this.dgBookBase = new System.Windows.Forms.DataGridView();
            this.pEdit = new System.Windows.Forms.Panel();
            this.pQuantity = new System.Windows.Forms.Panel();
            this.pReleaseDate = new System.Windows.Forms.Panel();
            this.tbReleaseDate = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.pAuthor = new System.Windows.Forms.Panel();
            this.pPrice = new System.Windows.Forms.Panel();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.pTitle = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnRefresh = new MunicipalLibrary.Options.Elements.CustomButton();
            this.btnUpdate = new MunicipalLibrary.Options.Elements.CustomButton();
            this.btnDelete = new MunicipalLibrary.Options.Elements.CustomButton();
            this.btnCancel = new MunicipalLibrary.Options.Elements.CustomButton();
            this.pTopEdit = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookBase)).BeginInit();
            this.pEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBookBase
            // 
            this.dgBookBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBookBase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.dgBookBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBookBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookBase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.dgBookBase.Location = new System.Drawing.Point(12, 107);
            this.dgBookBase.Name = "dgBookBase";
            this.dgBookBase.ReadOnly = true;
            this.dgBookBase.Size = new System.Drawing.Size(776, 210);
            this.dgBookBase.TabIndex = 0;
            this.dgBookBase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBookBase_CellClick);
            // 
            // pEdit
            // 
            this.pEdit.Controls.Add(this.btnUpdate);
            this.pEdit.Controls.Add(this.btnDelete);
            this.pEdit.Controls.Add(this.btnCancel);
            this.pEdit.Controls.Add(this.pQuantity);
            this.pEdit.Controls.Add(this.pReleaseDate);
            this.pEdit.Controls.Add(this.tbReleaseDate);
            this.pEdit.Controls.Add(this.tbQuantity);
            this.pEdit.Controls.Add(this.dtpPurchaseDate);
            this.pEdit.Controls.Add(this.lblQuantity);
            this.pEdit.Controls.Add(this.lblPurchaseDate);
            this.pEdit.Controls.Add(this.lblReleaseDate);
            this.pEdit.Controls.Add(this.pAuthor);
            this.pEdit.Controls.Add(this.pPrice);
            this.pEdit.Controls.Add(this.tbPrice);
            this.pEdit.Controls.Add(this.tbAuthor);
            this.pEdit.Controls.Add(this.pTitle);
            this.pEdit.Controls.Add(this.tbTitle);
            this.pEdit.Controls.Add(this.lblPrice);
            this.pEdit.Controls.Add(this.lblAuthor);
            this.pEdit.Controls.Add(this.lblTitle);
            this.pEdit.Location = new System.Drawing.Point(13, 338);
            this.pEdit.Name = "pEdit";
            this.pEdit.Size = new System.Drawing.Size(775, 250);
            this.pEdit.TabIndex = 1;
            // 
            // pQuantity
            // 
            this.pQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pQuantity.Location = new System.Drawing.Point(531, 50);
            this.pQuantity.Name = "pQuantity";
            this.pQuantity.Size = new System.Drawing.Size(200, 3);
            this.pQuantity.TabIndex = 28;
            // 
            // pReleaseDate
            // 
            this.pReleaseDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pReleaseDate.Location = new System.Drawing.Point(531, 100);
            this.pReleaseDate.Name = "pReleaseDate";
            this.pReleaseDate.Size = new System.Drawing.Size(200, 3);
            this.pReleaseDate.TabIndex = 29;
            // 
            // tbReleaseDate
            // 
            this.tbReleaseDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReleaseDate.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReleaseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbReleaseDate.Location = new System.Drawing.Point(531, 80);
            this.tbReleaseDate.Name = "tbReleaseDate";
            this.tbReleaseDate.Size = new System.Drawing.Size(200, 20);
            this.tbReleaseDate.TabIndex = 31;
            // 
            // tbQuantity
            // 
            this.tbQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuantity.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbQuantity.Location = new System.Drawing.Point(531, 30);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(200, 20);
            this.tbQuantity.TabIndex = 30;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CalendarFont = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpPurchaseDate.Location = new System.Drawing.Point(531, 130);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPurchaseDate.TabIndex = 27;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblQuantity.Location = new System.Drawing.Point(391, 30);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 19);
            this.lblQuantity.TabIndex = 26;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPurchaseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblPurchaseDate.Location = new System.Drawing.Point(391, 130);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(127, 19);
            this.lblPurchaseDate.TabIndex = 25;
            this.lblPurchaseDate.Text = "Purchase Date";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReleaseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblReleaseDate.Location = new System.Drawing.Point(391, 80);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(113, 19);
            this.lblReleaseDate.TabIndex = 24;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // pAuthor
            // 
            this.pAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pAuthor.Location = new System.Drawing.Point(136, 100);
            this.pAuthor.Name = "pAuthor";
            this.pAuthor.Size = new System.Drawing.Size(200, 3);
            this.pAuthor.TabIndex = 20;
            // 
            // pPrice
            // 
            this.pPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pPrice.Location = new System.Drawing.Point(136, 147);
            this.pPrice.Name = "pPrice";
            this.pPrice.Size = new System.Drawing.Size(200, 3);
            this.pPrice.TabIndex = 21;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbPrice.Location = new System.Drawing.Point(136, 130);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(200, 20);
            this.tbPrice.TabIndex = 23;
            // 
            // tbAuthor
            // 
            this.tbAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAuthor.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbAuthor.Location = new System.Drawing.Point(136, 80);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(200, 20);
            this.tbAuthor.TabIndex = 22;
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pTitle.Location = new System.Drawing.Point(136, 50);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(200, 3);
            this.pTitle.TabIndex = 19;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTitle.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbTitle.Location = new System.Drawing.Point(136, 30);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(200, 20);
            this.tbTitle.TabIndex = 18;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblPrice.Location = new System.Drawing.Point(33, 130);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 19);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblAuthor.Location = new System.Drawing.Point(33, 80);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(67, 19);
            this.lblAuthor.TabIndex = 16;
            this.lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblTitle.Location = new System.Drawing.Point(33, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(47, 19);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Title";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbSearch.Location = new System.Drawing.Point(108, 84);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(524, 20);
            this.tbSearch.TabIndex = 35;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblSearch.Location = new System.Drawing.Point(12, 85);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(90, 19);
            this.lblSearch.TabIndex = 35;
            this.lblSearch.Text = "Search >>";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.BoredrSize = 1;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnRefresh.Location = new System.Drawing.Point(638, 84);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 20);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BoredrSize = 2;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnUpdate.Location = new System.Drawing.Point(140, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BoredrSize = 2;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnDelete.Location = new System.Drawing.Point(340, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(540, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pTopEdit
            // 
            this.pTopEdit.BackgroundImage = global::MunicipalLibrary.Properties.Resources.books_3;
            this.pTopEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pTopEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTopEdit.Location = new System.Drawing.Point(0, 0);
            this.pTopEdit.Name = "pTopEdit";
            this.pTopEdit.Size = new System.Drawing.Size(800, 80);
            this.pTopEdit.TabIndex = 36;
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pTopEdit);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pEdit);
            this.Controls.Add(this.dgBookBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBookBase)).EndInit();
            this.pEdit.ResumeLayout(false);
            this.pEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBookBase;
        private System.Windows.Forms.Panel pEdit;
        private System.Windows.Forms.Panel pAuthor;
        private System.Windows.Forms.Panel pPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pQuantity;
        private System.Windows.Forms.Panel pReleaseDate;
        private System.Windows.Forms.TextBox tbReleaseDate;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblReleaseDate;
        private Options.Elements.CustomButton btnUpdate;
        private Options.Elements.CustomButton btnDelete;
        private Options.Elements.CustomButton btnCancel;
        private System.Windows.Forms.TextBox tbSearch;
        private Options.Elements.CustomButton btnRefresh;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pTopEdit;
    }
}