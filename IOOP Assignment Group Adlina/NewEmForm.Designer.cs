namespace IOOP_Assignment_Group_Adlina
{
    partial class NewEmForm
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
            this.CbProfileSett = new System.Windows.Forms.ComboBox();
            this.LblProfileSett = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnBack6 = new System.Windows.Forms.Button();
            this.LblNewEmail = new System.Windows.Forms.Label();
            this.TbNewEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbProfileSett
            // 
            this.CbProfileSett.FormattingEnabled = true;
            this.CbProfileSett.Location = new System.Drawing.Point(312, 178);
            this.CbProfileSett.Name = "CbProfileSett";
            this.CbProfileSett.Size = new System.Drawing.Size(162, 24);
            this.CbProfileSett.TabIndex = 22;
            // 
            // LblProfileSett
            // 
            this.LblProfileSett.AutoSize = true;
            this.LblProfileSett.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfileSett.Location = new System.Drawing.Point(307, 128);
            this.LblProfileSett.Name = "LblProfileSett";
            this.LblProfileSett.Size = new System.Drawing.Size(179, 29);
            this.LblProfileSett.TabIndex = 21;
            this.LblProfileSett.Text = "Profile Setting";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(285, 77);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(222, 25);
            this.LblKL.TabIndex = 20;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(145, 23);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(523, 54);
            this.LblRestaurant.TabIndex = 19;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(589, 387);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(79, 36);
            this.BtnUpdate.TabIndex = 34;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnBack6
            // 
            this.BtnBack6.Location = new System.Drawing.Point(154, 387);
            this.BtnBack6.Name = "BtnBack6";
            this.BtnBack6.Size = new System.Drawing.Size(79, 36);
            this.BtnBack6.TabIndex = 33;
            this.BtnBack6.Text = "Back";
            this.BtnBack6.UseVisualStyleBackColor = true;
            // 
            // LblNewEmail
            // 
            this.LblNewEmail.AutoSize = true;
            this.LblNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewEmail.Location = new System.Drawing.Point(268, 226);
            this.LblNewEmail.Name = "LblNewEmail";
            this.LblNewEmail.Size = new System.Drawing.Size(89, 20);
            this.LblNewEmail.TabIndex = 32;
            this.LblNewEmail.Text = "New Email";
            // 
            // TbNewEmail
            // 
            this.TbNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNewEmail.Location = new System.Drawing.Point(272, 259);
            this.TbNewEmail.Name = "TbNewEmail";
            this.TbNewEmail.Size = new System.Drawing.Size(265, 24);
            this.TbNewEmail.TabIndex = 31;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnBack6);
            this.Controls.Add(this.LblNewEmail);
            this.Controls.Add(this.TbNewEmail);
            this.Controls.Add(this.CbProfileSett);
            this.Controls.Add(this.LblProfileSett);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbProfileSett;
        private System.Windows.Forms.Label LblProfileSett;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnBack6;
        private System.Windows.Forms.Label LblNewEmail;
        private System.Windows.Forms.TextBox TbNewEmail;
    }
}