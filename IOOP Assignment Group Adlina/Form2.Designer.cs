namespace IOOP_Assignment_Group_Adlina
{
    partial class Form2
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
            this.LblKL.Location = new System.Drawing.Point(299, 74);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(222, 25);
            this.LblKL.TabIndex = 3;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(159, 20);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(523, 54);
            this.LblRestaurant.TabIndex = 2;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.Location = new System.Drawing.Point(305, 118);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(216, 29);
            this.LblAdmin.TabIndex = 4;
            this.LblAdmin.Text = "Welcome, Admin.";
            // 
            // RbtnManageAdmin
            // 
            this.RbtnManageAdmin.AutoSize = true;
            this.RbtnManageAdmin.Location = new System.Drawing.Point(350, 195);
            this.RbtnManageAdmin.Name = "RbtnManageAdmin";
            this.RbtnManageAdmin.Size = new System.Drawing.Size(117, 20);
            this.RbtnManageAdmin.TabIndex = 5;
            this.RbtnManageAdmin.TabStop = true;
            this.RbtnManageAdmin.Text = "Manage Users";
            this.RbtnManageAdmin.UseVisualStyleBackColor = true;
            // 
            // RbtnFeedback
            // 
            this.RbtnFeedback.AutoSize = true;
            this.RbtnFeedback.Location = new System.Drawing.Point(349, 229);
            this.RbtnFeedback.Name = "RbtnFeedback";
            this.RbtnFeedback.Size = new System.Drawing.Size(90, 20);
            this.RbtnFeedback.TabIndex = 6;
            this.RbtnFeedback.TabStop = true;
            this.RbtnFeedback.Text = "Feedback";
            this.RbtnFeedback.UseVisualStyleBackColor = true;
            // 
            // RbtnSales
            // 
            this.RbtnSales.AutoSize = true;
            this.RbtnSales.Location = new System.Drawing.Point(349, 264);
            this.RbtnSales.Name = "RbtnSales";
            this.RbtnSales.Size = new System.Drawing.Size(63, 20);
            this.RbtnSales.TabIndex = 7;
            this.RbtnSales.TabStop = true;
            this.RbtnSales.Text = "Sales";
            this.RbtnSales.UseVisualStyleBackColor = true;
            // 
            // RbtnProfile
            // 
            this.RbtnProfile.AutoSize = true;
            this.RbtnProfile.Location = new System.Drawing.Point(349, 299);
            this.RbtnProfile.Name = "RbtnProfile";
            this.RbtnProfile.Size = new System.Drawing.Size(119, 20);
            this.RbtnProfile.TabIndex = 8;
            this.RbtnProfile.TabStop = true;
            this.RbtnProfile.Text = "Manage Profile";
            this.RbtnProfile.UseVisualStyleBackColor = true;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(168, 405);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(78, 36);
            this.BtnLogout.TabIndex = 9;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(603, 405);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(79, 36);
            this.BtnNext.TabIndex = 10;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.RbtnProfile);
            this.Controls.Add(this.RbtnSales);
            this.Controls.Add(this.RbtnFeedback);
            this.Controls.Add(this.RbtnManageAdmin);
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Name = "Form2";
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