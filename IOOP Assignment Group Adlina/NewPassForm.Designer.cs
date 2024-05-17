namespace IOOP_Assignment_Group_Adlina
{
    partial class NewPassForm
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
            this.LblNewPass = new System.Windows.Forms.Label();
            this.TbNewPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbProfileSett
            // 
            this.CbProfileSett.FormattingEnabled = true;
            this.CbProfileSett.Location = new System.Drawing.Point(235, 144);
            this.CbProfileSett.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbProfileSett.Name = "CbProfileSett";
            this.CbProfileSett.Size = new System.Drawing.Size(122, 21);
            this.CbProfileSett.TabIndex = 22;
            // 
            // LblProfileSett
            // 
            this.LblProfileSett.AutoSize = true;
            this.LblProfileSett.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfileSett.Location = new System.Drawing.Point(231, 103);
            this.LblProfileSett.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProfileSett.Name = "LblProfileSett";
            this.LblProfileSett.Size = new System.Drawing.Size(139, 24);
            this.LblProfileSett.TabIndex = 21;
            this.LblProfileSett.Text = "Profile Setting";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(214, 62);
            this.LblKL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(176, 20);
            this.LblKL.TabIndex = 20;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(110, 18);
            this.LblRestaurant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(426, 44);
            this.LblRestaurant.TabIndex = 19;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(442, 314);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(59, 29);
            this.BtnUpdate.TabIndex = 34;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnBack6
            // 
            this.BtnBack6.Location = new System.Drawing.Point(116, 314);
            this.BtnBack6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBack6.Name = "BtnBack6";
            this.BtnBack6.Size = new System.Drawing.Size(59, 29);
            this.BtnBack6.TabIndex = 33;
            this.BtnBack6.Text = "Back";
            this.BtnBack6.UseVisualStyleBackColor = true;
            // 
            // LblNewPass
            // 
            this.LblNewPass.AutoSize = true;
            this.LblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewPass.Location = new System.Drawing.Point(195, 186);
            this.LblNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewPass.Name = "LblNewPass";
            this.LblNewPass.Size = new System.Drawing.Size(100, 17);
            this.LblNewPass.TabIndex = 35;
            this.LblNewPass.Text = "New Password";
            // 
            // TbNewPass
            // 
            this.TbNewPass.Location = new System.Drawing.Point(198, 217);
            this.TbNewPass.Name = "TbNewPass";
            this.TbNewPass.Size = new System.Drawing.Size(203, 20);
            this.TbNewPass.TabIndex = 36;
            // 
            // NewPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.TbNewPass);
            this.Controls.Add(this.LblNewPass);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnBack6);
            this.Controls.Add(this.CbProfileSett);
            this.Controls.Add(this.LblProfileSett);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewPassForm";
            this.Text = "Form11";
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
        private System.Windows.Forms.Label LblNewPass;
        private System.Windows.Forms.TextBox TbNewPass;
    }
}