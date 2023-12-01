namespace MunicipalLibrary
{
    partial class RentalDetails
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
            this.dgIssuedBooks = new System.Windows.Forms.DataGridView();
            this.dgReturnedBooks = new System.Windows.Forms.DataGridView();
            this.lblReturnedBooks = new System.Windows.Forms.Label();
            this.lblIssuedBooks = new System.Windows.Forms.Label();
            this.lblCloseButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgIssuedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReturnedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgIssuedBooks
            // 
            this.dgIssuedBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIssuedBooks.Location = new System.Drawing.Point(12, 40);
            this.dgIssuedBooks.Name = "dgIssuedBooks";
            this.dgIssuedBooks.Size = new System.Drawing.Size(776, 200);
            this.dgIssuedBooks.TabIndex = 0;
            // 
            // dgReturnedBooks
            // 
            this.dgReturnedBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.dgReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReturnedBooks.Location = new System.Drawing.Point(12, 288);
            this.dgReturnedBooks.Name = "dgReturnedBooks";
            this.dgReturnedBooks.Size = new System.Drawing.Size(776, 200);
            this.dgReturnedBooks.TabIndex = 1;
            // 
            // lblReturnedBooks
            // 
            this.lblReturnedBooks.AutoSize = true;
            this.lblReturnedBooks.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnedBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.lblReturnedBooks.Location = new System.Drawing.Point(320, 255);
            this.lblReturnedBooks.Name = "lblReturnedBooks";
            this.lblReturnedBooks.Size = new System.Drawing.Size(167, 22);
            this.lblReturnedBooks.TabIndex = 49;
            this.lblReturnedBooks.Text = "Returned Books";
            // 
            // lblIssuedBooks
            // 
            this.lblIssuedBooks.AutoSize = true;
            this.lblIssuedBooks.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIssuedBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.lblIssuedBooks.Location = new System.Drawing.Point(320, 9);
            this.lblIssuedBooks.Name = "lblIssuedBooks";
            this.lblIssuedBooks.Size = new System.Drawing.Size(138, 22);
            this.lblIssuedBooks.TabIndex = 50;
            this.lblIssuedBooks.Text = "Issued Books";
            // 
            // lblCloseButton
            // 
            this.lblCloseButton.AutoSize = true;
            this.lblCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.lblCloseButton.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.lblCloseButton.Location = new System.Drawing.Point(764, 9);
            this.lblCloseButton.Name = "lblCloseButton";
            this.lblCloseButton.Size = new System.Drawing.Size(24, 21);
            this.lblCloseButton.TabIndex = 51;
            this.lblCloseButton.Text = "X";
            this.lblCloseButton.Click += new System.EventHandler(this.lblCloseButton_Click);
            this.lblCloseButton.MouseEnter += new System.EventHandler(this.lblCloseButton_MouseEnter);
            this.lblCloseButton.MouseLeave += new System.EventHandler(this.lblCloseButton_MouseLeave);
            // 
            // RentalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblCloseButton);
            this.Controls.Add(this.lblIssuedBooks);
            this.Controls.Add(this.lblReturnedBooks);
            this.Controls.Add(this.dgReturnedBooks);
            this.Controls.Add(this.dgIssuedBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentalDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalDetails";
            this.Load += new System.EventHandler(this.RentalDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgIssuedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReturnedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgIssuedBooks;
        private System.Windows.Forms.DataGridView dgReturnedBooks;
        private System.Windows.Forms.Label lblReturnedBooks;
        private System.Windows.Forms.Label lblIssuedBooks;
        private System.Windows.Forms.Label lblCloseButton;
    }
}