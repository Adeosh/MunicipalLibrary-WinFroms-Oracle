namespace MunicipalLibrary
{
    partial class Login
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panAuth = new System.Windows.Forms.Panel();
            this.lblMinimized = new System.Windows.Forms.Label();
            this.lblCloseButton = new System.Windows.Forms.Label();
            this.lblAuth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.panAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.lblRegister.Location = new System.Drawing.Point(367, 479);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(116, 17);
            this.lblRegister.TabIndex = 9;
            this.lblRegister.Text = "Create an account?";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            this.lblRegister.MouseEnter += new System.EventHandler(this.lblRegister_MouseEnter);
            this.lblRegister.MouseLeave += new System.EventHandler(this.lblRegister_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLogin.Location = new System.Drawing.Point(109, 385);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(356, 64);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.Location = new System.Drawing.Point(109, 275);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(356, 35);
            this.tbPass.TabIndex = 11;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.Enter += new System.EventHandler(this.tbPass_Enter);
            this.tbPass.Leave += new System.EventHandler(this.tbPass_Leave);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(109, 165);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(356, 35);
            this.tbName.TabIndex = 10;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // pbPass
            // 
            this.pbPass.Image = global::MunicipalLibrary.Properties.Resources._lock;
            this.pbPass.Location = new System.Drawing.Point(30, 275);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(64, 64);
            this.pbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPass.TabIndex = 8;
            this.pbPass.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Image = global::MunicipalLibrary.Properties.Resources.user;
            this.pbUser.Location = new System.Drawing.Point(30, 165);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(64, 64);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 7;
            this.pbUser.TabStop = false;
            // 
            // panAuth
            // 
            this.panAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.panAuth.Controls.Add(this.lblMinimized);
            this.panAuth.Controls.Add(this.lblCloseButton);
            this.panAuth.Controls.Add(this.lblAuth);
            this.panAuth.Dock = System.Windows.Forms.DockStyle.Top;
            this.panAuth.Location = new System.Drawing.Point(0, 0);
            this.panAuth.Name = "panAuth";
            this.panAuth.Size = new System.Drawing.Size(500, 100);
            this.panAuth.TabIndex = 6;
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
            this.lblMinimized.TabIndex = 2;
            this.lblMinimized.Text = "_";
            this.lblMinimized.Click += new System.EventHandler(this.lblMinimized_Click);
            this.lblMinimized.MouseEnter += new System.EventHandler(this.lblMinimized_MouseEnter);
            this.lblMinimized.MouseLeave += new System.EventHandler(this.lblMinimized_MouseLeave);
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
            this.lblCloseButton.TabIndex = 1;
            this.lblCloseButton.Text = "x";
            this.lblCloseButton.Click += new System.EventHandler(this.lblCloseButton_Click);
            this.lblCloseButton.MouseEnter += new System.EventHandler(this.lblCloseButton_MouseEnter);
            this.lblCloseButton.MouseLeave += new System.EventHandler(this.lblCloseButton_MouseLeave);
            // 
            // lblAuth
            // 
            this.lblAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuth.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAuth.Location = new System.Drawing.Point(0, 0);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(500, 100);
            this.lblAuth.TabIndex = 0;
            this.lblAuth.Text = "Authorization";
            this.lblAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAuth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAuth_MouseDown);
            this.lblAuth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAuth_MouseMove);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pbPass);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.panAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.panAuth.ResumeLayout(false);
            this.panAuth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Panel panAuth;
        private System.Windows.Forms.Label lblMinimized;
        private System.Windows.Forms.Label lblCloseButton;
        private System.Windows.Forms.Label lblAuth;
    }
}