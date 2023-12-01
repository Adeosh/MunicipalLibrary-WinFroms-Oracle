namespace MunicipalLibrary
{
    partial class Register
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
            this.btnRegistration = new System.Windows.Forms.Button();
            this.panAuth = new System.Windows.Forms.Panel();
            this.lblMinimized = new System.Windows.Forms.Label();
            this.lblCloseButton = new System.Windows.Forms.Label();
            this.lblRegistr = new System.Windows.Forms.Label();
            this.lblAuth = new System.Windows.Forms.Label();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pcCountries = new System.Windows.Forms.PictureBox();
            this.pcEmail = new System.Windows.Forms.PictureBox();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistration.FlatAppearance.BorderSize = 0;
            this.btnRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRegistration.Location = new System.Drawing.Point(109, 408);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(356, 64);
            this.btnRegistration.TabIndex = 22;
            this.btnRegistration.Text = "Register";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // panAuth
            // 
            this.panAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.panAuth.Controls.Add(this.lblMinimized);
            this.panAuth.Controls.Add(this.lblCloseButton);
            this.panAuth.Controls.Add(this.lblRegistr);
            this.panAuth.Dock = System.Windows.Forms.DockStyle.Top;
            this.panAuth.Location = new System.Drawing.Point(0, 0);
            this.panAuth.Name = "panAuth";
            this.panAuth.Size = new System.Drawing.Size(500, 100);
            this.panAuth.TabIndex = 17;
            // 
            // lblMinimized
            // 
            this.lblMinimized.AutoSize = true;
            this.lblMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimized.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinimized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblMinimized.Location = new System.Drawing.Point(440, -6);
            this.lblMinimized.Name = "lblMinimized";
            this.lblMinimized.Size = new System.Drawing.Size(29, 35);
            this.lblMinimized.TabIndex = 1;
            this.lblMinimized.Text = "_";
            this.lblMinimized.Click += new System.EventHandler(this.lblMinimized_Click);
            this.lblMinimized.Leave += new System.EventHandler(this.lblMinimized_Leave);
            this.lblMinimized.MouseEnter += new System.EventHandler(this.lblMinimized_MouseEnter);
            // 
            // lblCloseButton
            // 
            this.lblCloseButton.AutoSize = true;
            this.lblCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseButton.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCloseButton.Location = new System.Drawing.Point(470, -3);
            this.lblCloseButton.Name = "lblCloseButton";
            this.lblCloseButton.Size = new System.Drawing.Size(29, 35);
            this.lblCloseButton.TabIndex = 2;
            this.lblCloseButton.Text = "x";
            this.lblCloseButton.Click += new System.EventHandler(this.lblCloseButton_Click);
            this.lblCloseButton.MouseEnter += new System.EventHandler(this.lblCloseButton_MouseEnter);
            this.lblCloseButton.MouseLeave += new System.EventHandler(this.lblCloseButton_MouseLeave);
            // 
            // lblRegistr
            // 
            this.lblRegistr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegistr.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegistr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRegistr.Location = new System.Drawing.Point(0, 0);
            this.lblRegistr.Name = "lblRegistr";
            this.lblRegistr.Size = new System.Drawing.Size(500, 100);
            this.lblRegistr.TabIndex = 10;
            this.lblRegistr.Text = "Registration";
            this.lblRegistr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAuth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.lblAuth.Location = new System.Drawing.Point(400, 475);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(83, 17);
            this.lblAuth.TabIndex = 3;
            this.lblAuth.Text = "Authorization";
            this.lblAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAuth.Click += new System.EventHandler(this.lblAuth_Click);
            this.lblAuth.MouseEnter += new System.EventHandler(this.lblAuth_MouseEnter);
            this.lblAuth.MouseLeave += new System.EventHandler(this.lblAuth_MouseLeave);
            // 
            // cbCountries
            // 
            this.cbCountries.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Austria",
            "Azerbaijan",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Channel Islands",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Costa Rica",
            "Côte d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "DR Congo",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Faeroe Islands",
            "Finland",
            "France",
            "French Guiana",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Isle of Man",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macao",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nepal",
            "Netherlands",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Panama",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Réunion",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Helena",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "State of Palestine",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "The Bahamas",
            "Timor-Leste",
            "Togo",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Venezuela",
            "Vietnam",
            "Western Sahara",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.cbCountries.Location = new System.Drawing.Point(109, 318);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(356, 21);
            this.cbCountries.TabIndex = 26;
            this.cbCountries.Enter += new System.EventHandler(this.cbCountries_Enter);
            this.cbCountries.Leave += new System.EventHandler(this.cbCountries_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.Location = new System.Drawing.Point(109, 247);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(356, 35);
            this.tbEmail.TabIndex = 24;
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.Location = new System.Drawing.Point(109, 176);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(356, 35);
            this.tbPass.TabIndex = 21;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.Enter += new System.EventHandler(this.tbPass_Enter);
            this.tbPass.Leave += new System.EventHandler(this.tbPass_Leave);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(109, 106);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(356, 35);
            this.tbName.TabIndex = 20;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // pcCountries
            // 
            this.pcCountries.Image = global::MunicipalLibrary.Properties.Resources.country;
            this.pcCountries.Location = new System.Drawing.Point(30, 317);
            this.pcCountries.Name = "pcCountries";
            this.pcCountries.Size = new System.Drawing.Size(64, 64);
            this.pcCountries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCountries.TabIndex = 25;
            this.pcCountries.TabStop = false;
            // 
            // pcEmail
            // 
            this.pcEmail.Image = global::MunicipalLibrary.Properties.Resources.email;
            this.pcEmail.Location = new System.Drawing.Point(30, 246);
            this.pcEmail.Name = "pcEmail";
            this.pcEmail.Size = new System.Drawing.Size(64, 64);
            this.pcEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEmail.TabIndex = 23;
            this.pcEmail.TabStop = false;
            // 
            // pbPass
            // 
            this.pbPass.Image = global::MunicipalLibrary.Properties.Resources._lock;
            this.pbPass.Location = new System.Drawing.Point(30, 176);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(64, 64);
            this.pbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPass.TabIndex = 19;
            this.pbPass.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Image = global::MunicipalLibrary.Properties.Resources.user;
            this.pbUser.Location = new System.Drawing.Point(30, 106);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(64, 64);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 18;
            this.pbUser.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.panAuth);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.pcCountries);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.pcEmail);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pbPass);
            this.Controls.Add(this.pbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Register_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            this.panAuth.ResumeLayout(false);
            this.panAuth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Panel panAuth;
        private System.Windows.Forms.Label lblMinimized;
        private System.Windows.Forms.Label lblCloseButton;
        private System.Windows.Forms.Label lblRegistr;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.PictureBox pcCountries;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.PictureBox pcEmail;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.PictureBox pbUser;
    }
}