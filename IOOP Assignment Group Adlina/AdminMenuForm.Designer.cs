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
            this.RbtnManageAdmin = new System.Windows.Forms.RadioButton();
            this.RbtnFeedback = new System.Windows.Forms.RadioButton();
            this.RbtnSales = new System.Windows.Forms.RadioButton();
            this.RbtnProfile = new System.Windows.Forms.RadioButton();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
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
            // RbtnManageAdmin
            // 
            this.RbtnManageAdmin.AutoSize = true;
            this.RbtnManageAdmin.Location = new System.Drawing.Point(262, 158);
            this.RbtnManageAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbtnManageAdmin.Name = "RbtnManageAdmin";
            this.RbtnManageAdmin.Size = new System.Drawing.Size(94, 17);
            this.RbtnManageAdmin.TabIndex = 5;
            this.RbtnManageAdmin.TabStop = true;
            this.RbtnManageAdmin.Text = "Manage Users";
            this.RbtnManageAdmin.UseVisualStyleBackColor = true;
            this.RbtnManageAdmin.CheckedChanged += new System.EventHandler(this.RbtnManageAdmin_CheckedChanged);
            // 
            // RbtnFeedback
            // 
            this.RbtnFeedback.AutoSize = true;
            this.RbtnFeedback.Location = new System.Drawing.Point(262, 186);
            this.RbtnFeedback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbtnFeedback.Name = "RbtnFeedback";
            this.RbtnFeedback.Size = new System.Drawing.Size(73, 17);
            this.RbtnFeedback.TabIndex = 6;
            this.RbtnFeedback.TabStop = true;
            this.RbtnFeedback.Text = "Feedback";
            this.RbtnFeedback.UseVisualStyleBackColor = true;
            // 
            // RbtnSales
            // 
            this.RbtnSales.AutoSize = true;
            this.RbtnSales.Location = new System.Drawing.Point(262, 214);
            this.RbtnSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbtnSales.Name = "RbtnSales";
            this.RbtnSales.Size = new System.Drawing.Size(51, 17);
            this.RbtnSales.TabIndex = 7;
            this.RbtnSales.TabStop = true;
            this.RbtnSales.Text = "Sales";
            this.RbtnSales.UseVisualStyleBackColor = true;
            // 
            // RbtnProfile
            // 
            this.RbtnProfile.AutoSize = true;
            this.RbtnProfile.Location = new System.Drawing.Point(262, 243);
            this.RbtnProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbtnProfile.Name = "RbtnProfile";
            this.RbtnProfile.Size = new System.Drawing.Size(96, 17);
            this.RbtnProfile.TabIndex = 8;
            this.RbtnProfile.TabStop = true;
            this.RbtnProfile.Text = "Manage Profile";
            this.RbtnProfile.UseVisualStyleBackColor = true;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(126, 329);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(58, 29);
            this.BtnLogout.TabIndex = 9;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(452, 329);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(59, 29);
            this.BtnNext.TabIndex = 10;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(600, 396);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.RbtnProfile);
            this.Controls.Add(this.RbtnSales);
            this.Controls.Add(this.RbtnFeedback);
            this.Controls.Add(this.RbtnManageAdmin);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminMenuForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.RadioButton RbtnManageAdmin;
        private System.Windows.Forms.RadioButton RbtnFeedback;
        private System.Windows.Forms.RadioButton RbtnSales;
        private System.Windows.Forms.RadioButton RbtnProfile;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnNext;
    }
}