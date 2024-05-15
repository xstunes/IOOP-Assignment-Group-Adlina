namespace IOOP_Assignment_Group_Adlina
{
    partial class ViewUsersForm
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
            this.LblViewUser = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.BtnBack2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblViewUser
            // 
            this.LblViewUser.AutoSize = true;
            this.LblViewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblViewUser.Location = new System.Drawing.Point(248, 121);
            this.LblViewUser.Name = "LblViewUser";
            this.LblViewUser.Size = new System.Drawing.Size(281, 29);
            this.LblViewUser.TabIndex = 11;
            this.LblViewUser.Text = "View Registered Users";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(281, 72);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(222, 25);
            this.LblKL.TabIndex = 10;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(141, 18);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(523, 54);
            this.LblRestaurant.TabIndex = 9;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // BtnBack2
            // 
            this.BtnBack2.Location = new System.Drawing.Point(150, 608);
            this.BtnBack2.Name = "BtnBack2";
            this.BtnBack2.Size = new System.Drawing.Size(79, 36);
            this.BtnBack2.TabIndex = 19;
            this.BtnBack2.Text = "Back";
            this.BtnBack2.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.BtnBack2);
            this.Controls.Add(this.LblViewUser);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblViewUser;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Button BtnBack2;
    }
}