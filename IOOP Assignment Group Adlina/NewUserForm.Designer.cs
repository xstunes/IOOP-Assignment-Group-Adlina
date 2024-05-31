namespace IOOP_Assignment_Group_Adlina
{
    partial class NewUserForm
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
            this.LblProfileSett = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.TbNewUser = new System.Windows.Forms.TextBox();
            this.LblNewUser = new System.Windows.Forms.Label();
            this.BtnBack6 = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblProfileSett
            // 
            this.LblProfileSett.AutoSize = true;
            this.LblProfileSett.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfileSett.Location = new System.Drawing.Point(178, 98);
            this.LblProfileSett.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProfileSett.Name = "LblProfileSett";
            this.LblProfileSett.Size = new System.Drawing.Size(252, 24);
            this.LblProfileSett.TabIndex = 17;
            this.LblProfileSett.Text = "Profile Setting : Username";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(216, 62);
            this.LblKL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(176, 20);
            this.LblKL.TabIndex = 16;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(111, 18);
            this.LblRestaurant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(426, 44);
            this.LblRestaurant.TabIndex = 15;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // TbNewUser
            // 
            this.TbNewUser.Location = new System.Drawing.Point(206, 208);
            this.TbNewUser.Margin = new System.Windows.Forms.Padding(2);
            this.TbNewUser.Name = "TbNewUser";
            this.TbNewUser.Size = new System.Drawing.Size(200, 20);
            this.TbNewUser.TabIndex = 19;
            // 
            // LblNewUser
            // 
            this.LblNewUser.AutoSize = true;
            this.LblNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewUser.Location = new System.Drawing.Point(203, 181);
            this.LblNewUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewUser.Name = "LblNewUser";
            this.LblNewUser.Size = new System.Drawing.Size(104, 17);
            this.LblNewUser.TabIndex = 20;
            this.LblNewUser.Text = "New Username";
            // 
            // BtnBack6
            // 
            this.BtnBack6.Location = new System.Drawing.Point(118, 312);
            this.BtnBack6.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack6.Name = "BtnBack6";
            this.BtnBack6.Size = new System.Drawing.Size(59, 29);
            this.BtnBack6.TabIndex = 29;
            this.BtnBack6.Text = "Back";
            this.BtnBack6.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(444, 312);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(59, 29);
            this.BtnUpdate.TabIndex = 30;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnBack6);
            this.Controls.Add(this.LblNewUser);
            this.Controls.Add(this.TbNewUser);
            this.Controls.Add(this.LblProfileSett);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewUserForm";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProfileSett;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.TextBox TbNewUser;
        private System.Windows.Forms.Label LblNewUser;
        private System.Windows.Forms.Button BtnBack6;
        private System.Windows.Forms.Button BtnUpdate;
    }
}