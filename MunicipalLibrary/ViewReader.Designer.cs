namespace MunicipalLibrary
{
    partial class ViewReader
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnRefresh = new MunicipalLibrary.Options.Elements.CustomButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pEdit = new System.Windows.Forms.Panel();
            this.pEmail = new System.Windows.Forms.Panel();
            this.pPersNo = new System.Windows.Forms.Panel();
            this.tbPersNo = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dtpDateAdded = new System.Windows.Forms.DateTimePicker();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDateAdded = new System.Windows.Forms.Label();
            this.lblPersNo = new System.Windows.Forms.Label();
            this.pSurname = new System.Windows.Forms.Panel();
            this.pContact = new System.Windows.Forms.Panel();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.pName = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpdate = new MunicipalLibrary.Options.Elements.CustomButton();
            this.btnDelete = new MunicipalLibrary.Options.Elements.CustomButton();
            this.btnCancel = new MunicipalLibrary.Options.Elements.CustomButton();
            this.dgReaderBase = new System.Windows.Forms.DataGridView();
            this.pTop = new System.Windows.Forms.Panel();
            this.pEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReaderBase)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblSearch.Location = new System.Drawing.Point(8, 91);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(90, 19);
            this.lblSearch.TabIndex = 39;
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
            this.btnRefresh.Location = new System.Drawing.Point(634, 90);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 20);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbSearch.Location = new System.Drawing.Point(104, 90);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(524, 20);
            this.tbSearch.TabIndex = 41;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // pEdit
            // 
            this.pEdit.Controls.Add(this.pEmail);
            this.pEdit.Controls.Add(this.pPersNo);
            this.pEdit.Controls.Add(this.tbPersNo);
            this.pEdit.Controls.Add(this.tbEmail);
            this.pEdit.Controls.Add(this.dtpDateAdded);
            this.pEdit.Controls.Add(this.lblEmail);
            this.pEdit.Controls.Add(this.lblDateAdded);
            this.pEdit.Controls.Add(this.lblPersNo);
            this.pEdit.Controls.Add(this.pSurname);
            this.pEdit.Controls.Add(this.pContact);
            this.pEdit.Controls.Add(this.tbContact);
            this.pEdit.Controls.Add(this.tbSurname);
            this.pEdit.Controls.Add(this.pName);
            this.pEdit.Controls.Add(this.tbName);
            this.pEdit.Controls.Add(this.lblContact);
            this.pEdit.Controls.Add(this.lblSurname);
            this.pEdit.Controls.Add(this.lblName);
            this.pEdit.Controls.Add(this.btnUpdate);
            this.pEdit.Controls.Add(this.btnDelete);
            this.pEdit.Controls.Add(this.btnCancel);
            this.pEdit.Location = new System.Drawing.Point(13, 338);
            this.pEdit.Name = "pEdit";
            this.pEdit.Size = new System.Drawing.Size(775, 250);
            this.pEdit.TabIndex = 38;
            // 
            // pEmail
            // 
            this.pEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pEmail.Location = new System.Drawing.Point(540, 52);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(200, 3);
            this.pEmail.TabIndex = 50;
            // 
            // pPersNo
            // 
            this.pPersNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pPersNo.Location = new System.Drawing.Point(540, 102);
            this.pPersNo.Name = "pPersNo";
            this.pPersNo.Size = new System.Drawing.Size(200, 3);
            this.pPersNo.TabIndex = 49;
            // 
            // tbPersNo
            // 
            this.tbPersNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbPersNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPersNo.Cursor = System.Windows.Forms.Cursors.No;
            this.tbPersNo.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPersNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbPersNo.Location = new System.Drawing.Point(540, 82);
            this.tbPersNo.Name = "tbPersNo";
            this.tbPersNo.ReadOnly = true;
            this.tbPersNo.Size = new System.Drawing.Size(200, 20);
            this.tbPersNo.TabIndex = 52;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbEmail.Location = new System.Drawing.Point(540, 32);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 20);
            this.tbEmail.TabIndex = 51;
            // 
            // dtpDateAdded
            // 
            this.dtpDateAdded.CalendarFont = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDateAdded.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDateAdded.Location = new System.Drawing.Point(540, 132);
            this.dtpDateAdded.Name = "dtpDateAdded";
            this.dtpDateAdded.Size = new System.Drawing.Size(200, 20);
            this.dtpDateAdded.TabIndex = 48;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblEmail.Location = new System.Drawing.Point(400, 32);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 19);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "Email";
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblDateAdded.Location = new System.Drawing.Point(400, 132);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(102, 19);
            this.lblDateAdded.TabIndex = 46;
            this.lblDateAdded.Text = "Date Added";
            // 
            // lblPersNo
            // 
            this.lblPersNo.AutoSize = true;
            this.lblPersNo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblPersNo.Location = new System.Drawing.Point(400, 82);
            this.lblPersNo.Name = "lblPersNo";
            this.lblPersNo.Size = new System.Drawing.Size(103, 19);
            this.lblPersNo.TabIndex = 45;
            this.lblPersNo.Text = "Personal №";
            // 
            // pSurname
            // 
            this.pSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pSurname.Location = new System.Drawing.Point(174, 97);
            this.pSurname.Name = "pSurname";
            this.pSurname.Size = new System.Drawing.Size(200, 3);
            this.pSurname.TabIndex = 43;
            // 
            // pContact
            // 
            this.pContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pContact.Location = new System.Drawing.Point(174, 147);
            this.pContact.Name = "pContact";
            this.pContact.Size = new System.Drawing.Size(200, 3);
            this.pContact.TabIndex = 42;
            // 
            // tbContact
            // 
            this.tbContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbContact.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbContact.Location = new System.Drawing.Point(174, 127);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(200, 20);
            this.tbContact.TabIndex = 44;
            // 
            // tbSurname
            // 
            this.tbSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSurname.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbSurname.Location = new System.Drawing.Point(174, 77);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(200, 20);
            this.tbSurname.TabIndex = 41;
            // 
            // pName
            // 
            this.pName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pName.Location = new System.Drawing.Point(174, 47);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(200, 3);
            this.pName.TabIndex = 40;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbName.Location = new System.Drawing.Point(174, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 39;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblContact.Location = new System.Drawing.Point(34, 127);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(74, 19);
            this.lblContact.TabIndex = 38;
            this.lblContact.Text = "Contact";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblSurname.Location = new System.Drawing.Point(34, 77);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(83, 19);
            this.lblSurname.TabIndex = 37;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblName.Location = new System.Drawing.Point(34, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 19);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Name";
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
            // dgReaderBase
            // 
            this.dgReaderBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReaderBase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.dgReaderBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgReaderBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReaderBase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.dgReaderBase.Location = new System.Drawing.Point(12, 113);
            this.dgReaderBase.Name = "dgReaderBase";
            this.dgReaderBase.ReadOnly = true;
            this.dgReaderBase.Size = new System.Drawing.Size(776, 210);
            this.dgReaderBase.TabIndex = 37;
            this.dgReaderBase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReaderBase_CellClick);
            // 
            // pTop
            // 
            this.pTop.BackgroundImage = global::MunicipalLibrary.Properties.Resources.books_2;
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(800, 80);
            this.pTop.TabIndex = 42;
            // 
            // ViewReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pEdit);
            this.Controls.Add(this.dgReaderBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewReader";
            this.Text = "ViewReader";
            this.Load += new System.EventHandler(this.ViewReader_Load);
            this.pEdit.ResumeLayout(false);
            this.pEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReaderBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearch;
        private Options.Elements.CustomButton btnRefresh;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel pEdit;
        private Options.Elements.CustomButton btnUpdate;
        private Options.Elements.CustomButton btnDelete;
        private Options.Elements.CustomButton btnCancel;
        private System.Windows.Forms.DataGridView dgReaderBase;
        private System.Windows.Forms.Panel pSurname;
        private System.Windows.Forms.Panel pContact;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Panel pName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pEmail;
        private System.Windows.Forms.Panel pPersNo;
        private System.Windows.Forms.TextBox tbPersNo;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.Label lblPersNo;
        private System.Windows.Forms.Panel pTop;
    }
}