namespace MunicipalLibrary
{
    partial class AddReader
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
            this.pSurname = new System.Windows.Forms.Panel();
            this.pContact = new System.Windows.Forms.Panel();
            this.pEmail = new System.Windows.Forms.Panel();
            this.pPersNo = new System.Windows.Forms.Panel();
            this.tbPersNo = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.pName = new System.Windows.Forms.Panel();
            this.btnCancel = new MunicipalLibrary.Options.Elements.CustomButton();
            this.btnSave = new MunicipalLibrary.Options.Elements.CustomButton();
            this.dtpDateAdded = new System.Windows.Forms.DateTimePicker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblDateAdded = new System.Windows.Forms.Label();
            this.lblPersNo = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.pAddReader = new System.Windows.Forms.Panel();
            this.lblAddReader = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.pSide = new System.Windows.Forms.Panel();
            this.pAddReader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSurname
            // 
            this.pSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pSurname.Location = new System.Drawing.Point(280, 170);
            this.pSurname.Name = "pSurname";
            this.pSurname.Size = new System.Drawing.Size(200, 3);
            this.pSurname.TabIndex = 34;
            // 
            // pContact
            // 
            this.pContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pContact.Location = new System.Drawing.Point(280, 220);
            this.pContact.Name = "pContact";
            this.pContact.Size = new System.Drawing.Size(200, 3);
            this.pContact.TabIndex = 33;
            // 
            // pEmail
            // 
            this.pEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pEmail.Location = new System.Drawing.Point(280, 270);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(200, 3);
            this.pEmail.TabIndex = 32;
            // 
            // pPersNo
            // 
            this.pPersNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pPersNo.Location = new System.Drawing.Point(280, 320);
            this.pPersNo.Name = "pPersNo";
            this.pPersNo.Size = new System.Drawing.Size(200, 3);
            this.pPersNo.TabIndex = 31;
            // 
            // tbPersNo
            // 
            this.tbPersNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbPersNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPersNo.Cursor = System.Windows.Forms.Cursors.No;
            this.tbPersNo.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPersNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbPersNo.Location = new System.Drawing.Point(280, 300);
            this.tbPersNo.Name = "tbPersNo";
            this.tbPersNo.ReadOnly = true;
            this.tbPersNo.Size = new System.Drawing.Size(200, 20);
            this.tbPersNo.TabIndex = 37;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbEmail.Location = new System.Drawing.Point(280, 250);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 20);
            this.tbEmail.TabIndex = 36;
            // 
            // tbContact
            // 
            this.tbContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbContact.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbContact.Location = new System.Drawing.Point(280, 200);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(200, 20);
            this.tbContact.TabIndex = 35;
            // 
            // tbSurname
            // 
            this.tbSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSurname.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbSurname.Location = new System.Drawing.Point(280, 150);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(200, 20);
            this.tbSurname.TabIndex = 30;
            // 
            // pName
            // 
            this.pName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pName.Location = new System.Drawing.Point(280, 120);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(200, 3);
            this.pName.TabIndex = 29;
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
            this.btnCancel.TabIndex = 28;
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
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDateAdded
            // 
            this.dtpDateAdded.CalendarFont = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDateAdded.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDateAdded.Location = new System.Drawing.Point(280, 350);
            this.dtpDateAdded.Name = "dtpDateAdded";
            this.dtpDateAdded.Size = new System.Drawing.Size(200, 20);
            this.dtpDateAdded.TabIndex = 26;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbName.Location = new System.Drawing.Point(280, 100);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 25;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblEmail.Location = new System.Drawing.Point(140, 250);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 19);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblContact.Location = new System.Drawing.Point(140, 200);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(74, 19);
            this.lblContact.TabIndex = 23;
            this.lblContact.Text = "Contact";
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblDateAdded.Location = new System.Drawing.Point(140, 350);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(102, 19);
            this.lblDateAdded.TabIndex = 22;
            this.lblDateAdded.Text = "Date Added";
            // 
            // lblPersNo
            // 
            this.lblPersNo.AutoSize = true;
            this.lblPersNo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblPersNo.Location = new System.Drawing.Point(140, 300);
            this.lblPersNo.Name = "lblPersNo";
            this.lblPersNo.Size = new System.Drawing.Size(103, 19);
            this.lblPersNo.TabIndex = 21;
            this.lblPersNo.Text = "Personal №";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblSurname.Location = new System.Drawing.Point(140, 150);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(83, 19);
            this.lblSurname.TabIndex = 20;
            this.lblSurname.Text = "Surname";
            // 
            // pAddReader
            // 
            this.pAddReader.Controls.Add(this.lblAddReader);
            this.pAddReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAddReader.Location = new System.Drawing.Point(120, 0);
            this.pAddReader.Name = "pAddReader";
            this.pAddReader.Size = new System.Drawing.Size(380, 40);
            this.pAddReader.TabIndex = 19;
            // 
            // lblAddReader
            // 
            this.lblAddReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddReader.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddReader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblAddReader.Location = new System.Drawing.Point(0, 0);
            this.lblAddReader.Name = "lblAddReader";
            this.lblAddReader.Size = new System.Drawing.Size(380, 40);
            this.lblAddReader.TabIndex = 8;
            this.lblAddReader.Text = "Add Reader";
            this.lblAddReader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lblName.Location = new System.Drawing.Point(140, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 19);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // pSide
            // 
            this.pSide.BackgroundImage = global::MunicipalLibrary.Properties.Resources.reader;
            this.pSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSide.Location = new System.Drawing.Point(0, 0);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(120, 500);
            this.pSide.TabIndex = 17;
            // 
            // AddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pSurname);
            this.Controls.Add(this.pContact);
            this.Controls.Add(this.pEmail);
            this.Controls.Add(this.pPersNo);
            this.Controls.Add(this.tbPersNo);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDateAdded);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblDateAdded);
            this.Controls.Add(this.lblPersNo);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.pAddReader);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReader";
            this.Load += new System.EventHandler(this.AddReader_Load);
            this.pAddReader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pSurname;
        private System.Windows.Forms.Panel pContact;
        private System.Windows.Forms.Panel pEmail;
        private System.Windows.Forms.Panel pPersNo;
        private System.Windows.Forms.TextBox tbPersNo;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Panel pName;
        private Options.Elements.CustomButton btnCancel;
        private Options.Elements.CustomButton btnSave;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.Label lblPersNo;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Panel pAddReader;
        private System.Windows.Forms.Label lblAddReader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pSide;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
    }
}