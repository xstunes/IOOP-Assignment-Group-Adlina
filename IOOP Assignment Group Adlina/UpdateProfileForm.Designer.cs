namespace IOOP_Assignment_Group_Adlina
{
    partial class UpdateProfileForm
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
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.LblProfileSett = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnNewUser = new System.Windows.Forms.Button();
            this.BtnNewEm = new System.Windows.Forms.Button();
            this.BtnNewPass = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(326, 12);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(634, 65);
            this.LblRestaurant.TabIndex = 18;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(482, 82);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(267, 29);
            this.LblKL.TabIndex = 19;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblProfileSett
            // 
            this.LblProfileSett.AutoSize = true;
            this.LblProfileSett.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfileSett.Location = new System.Drawing.Point(495, 128);
            this.LblProfileSett.Name = "LblProfileSett";
            this.LblProfileSett.Size = new System.Drawing.Size(220, 32);
            this.LblProfileSett.TabIndex = 20;
            this.LblProfileSett.Text = "Manage Profile";
            this.LblProfileSett.Click += new System.EventHandler(this.LblProfileSett_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.LblRestaurant);
            this.panel1.Controls.Add(this.LblKL);
            this.panel1.Controls.Add(this.LblProfileSett);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 172);
            this.panel1.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(129, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 48);
            this.button2.TabIndex = 37;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BtnNewUser
            // 
            this.BtnNewUser.Location = new System.Drawing.Point(506, 265);
            this.BtnNewUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNewUser.Name = "BtnNewUser";
            this.BtnNewUser.Size = new System.Drawing.Size(224, 66);
            this.BtnNewUser.TabIndex = 39;
            this.BtnNewUser.Text = "Change Username";
            this.BtnNewUser.UseVisualStyleBackColor = true;
            this.BtnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // BtnNewEm
            // 
            this.BtnNewEm.Location = new System.Drawing.Point(506, 355);
            this.BtnNewEm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNewEm.Name = "BtnNewEm";
            this.BtnNewEm.Size = new System.Drawing.Size(224, 60);
            this.BtnNewEm.TabIndex = 40;
            this.BtnNewEm.Text = "Change Email";
            this.BtnNewEm.UseVisualStyleBackColor = true;
            this.BtnNewEm.Click += new System.EventHandler(this.BtnNewEm_Click);
            // 
            // BtnNewPass
            // 
            this.BtnNewPass.Location = new System.Drawing.Point(506, 442);
            this.BtnNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNewPass.Name = "BtnNewPass";
            this.BtnNewPass.Size = new System.Drawing.Size(224, 63);
            this.BtnNewPass.TabIndex = 41;
            this.BtnNewPass.Text = "Change Password";
            this.BtnNewPass.UseVisualStyleBackColor = true;
            this.BtnNewPass.Click += new System.EventHandler(this.BtnNewPass_Click);
            // 
            // UpdateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BtnNewPass);
            this.Controls.Add(this.BtnNewEm);
            this.Controls.Add(this.BtnNewUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateProfileForm";
            this.Text = "0";
            this.Load += new System.EventHandler(this.UpdateProfileForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblProfileSett;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnNewUser;
        private System.Windows.Forms.Button BtnNewEm;
        private System.Windows.Forms.Button BtnNewPass;
    }
}