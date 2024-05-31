namespace IOOP_Assignment_Group_Adlina
{
    partial class AdminMenuForm
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
            this.LblKL = new System.Windows.Forms.Label();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.LblAdmin = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.ManAllUser = new System.Windows.Forms.Button();
            this.BtnViewFeed = new System.Windows.Forms.Button();
            this.BtnViewSales = new System.Windows.Forms.Button();
            this.BtnManProfile1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(224, 60);
            this.LblKL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(176, 20);
            this.LblKL.TabIndex = 3;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(119, 16);
            this.LblRestaurant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(426, 44);
            this.LblRestaurant.TabIndex = 2;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.Location = new System.Drawing.Point(229, 96);
            this.LblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(176, 24);
            this.LblAdmin.TabIndex = 4;
            this.LblAdmin.Text = "Welcome, Admin.";
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(127, 396);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(58, 29);
            this.BtnLogout.TabIndex = 9;
            this.BtnLogout.Text = "Sign out";
            this.BtnLogout.UseVisualStyleBackColor = true;
            // 
            // ManAllUser
            // 
            this.ManAllUser.Location = new System.Drawing.Point(258, 151);
            this.ManAllUser.Name = "ManAllUser";
            this.ManAllUser.Size = new System.Drawing.Size(116, 34);
            this.ManAllUser.TabIndex = 11;
            this.ManAllUser.Text = "Manage Users";
            this.ManAllUser.UseVisualStyleBackColor = true;
            this.ManAllUser.Click += new System.EventHandler(this.ManAllUser_Click);
            // 
            // BtnViewFeed
            // 
            this.BtnViewFeed.Location = new System.Drawing.Point(258, 203);
            this.BtnViewFeed.Name = "BtnViewFeed";
            this.BtnViewFeed.Size = new System.Drawing.Size(114, 34);
            this.BtnViewFeed.TabIndex = 12;
            this.BtnViewFeed.Text = "View Feedback";
            this.BtnViewFeed.UseVisualStyleBackColor = true;
            this.BtnViewFeed.Click += new System.EventHandler(this.BtnViewFeed_Click);
            // 
            // BtnViewSales
            // 
            this.BtnViewSales.Location = new System.Drawing.Point(258, 254);
            this.BtnViewSales.Name = "BtnViewSales";
            this.BtnViewSales.Size = new System.Drawing.Size(114, 35);
            this.BtnViewSales.TabIndex = 13;
            this.BtnViewSales.Text = "View Sales";
            this.BtnViewSales.UseVisualStyleBackColor = true;
            this.BtnViewSales.Click += new System.EventHandler(this.BtnViewSales_Click);
            // 
            // BtnManProfile1
            // 
            this.BtnManProfile1.Location = new System.Drawing.Point(258, 307);
            this.BtnManProfile1.Name = "BtnManProfile1";
            this.BtnManProfile1.Size = new System.Drawing.Size(116, 36);
            this.BtnManProfile1.TabIndex = 14;
            this.BtnManProfile1.Text = "Manage Profile";
            this.BtnManProfile1.UseVisualStyleBackColor = true;
            this.BtnManProfile1.Click += new System.EventHandler(this.BtnManProfile1_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(600, 464);
            this.Controls.Add(this.BtnManProfile1);
            this.Controls.Add(this.BtnViewSales);
            this.Controls.Add(this.BtnViewFeed);
            this.Controls.Add(this.ManAllUser);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMenuForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AdminMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button ManAllUser;
        private System.Windows.Forms.Button BtnViewFeed;
        private System.Windows.Forms.Button BtnViewSales;
        private System.Windows.Forms.Button BtnManProfile1;
    }
}