namespace IOOP_Assignment_Group_Adlina
{
    partial class ManageUserForm
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
            this.LblManageUser = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnViewReg = new System.Windows.Forms.Button();
            this.BtnAddNewus = new System.Windows.Forms.Button();
            this.BtnDelReguser = new System.Windows.Forms.Button();
            this.BtnChangeRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(212, 59);
            this.LblKL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(176, 20);
            this.LblKL.TabIndex = 5;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(106, 15);
            this.LblRestaurant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(426, 44);
            this.LblRestaurant.TabIndex = 4;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // LblManageUser
            // 
            this.LblManageUser.AutoSize = true;
            this.LblManageUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblManageUser.Location = new System.Drawing.Point(223, 93);
            this.LblManageUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblManageUser.Name = "LblManageUser";
            this.LblManageUser.Size = new System.Drawing.Size(144, 24);
            this.LblManageUser.TabIndex = 6;
            this.LblManageUser.Text = "Manage Users";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(114, 347);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(59, 29);
            this.BtnBack.TabIndex = 12;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnViewReg
            // 
            this.BtnViewReg.Location = new System.Drawing.Point(227, 143);
            this.BtnViewReg.Name = "BtnViewReg";
            this.BtnViewReg.Size = new System.Drawing.Size(129, 31);
            this.BtnViewReg.TabIndex = 13;
            this.BtnViewReg.Text = "Registered Users";
            this.BtnViewReg.UseVisualStyleBackColor = true;
            this.BtnViewReg.Click += new System.EventHandler(this.BtnViewReg_Click);
            // 
            // BtnAddNewus
            // 
            this.BtnAddNewus.Location = new System.Drawing.Point(227, 195);
            this.BtnAddNewus.Name = "BtnAddNewus";
            this.BtnAddNewus.Size = new System.Drawing.Size(129, 31);
            this.BtnAddNewus.TabIndex = 14;
            this.BtnAddNewus.Text = "Add New User";
            this.BtnAddNewus.UseVisualStyleBackColor = true;
            this.BtnAddNewus.Click += new System.EventHandler(this.BtnAddNewus_Click);
            // 
            // BtnDelReguser
            // 
            this.BtnDelReguser.Location = new System.Drawing.Point(227, 295);
            this.BtnDelReguser.Name = "BtnDelReguser";
            this.BtnDelReguser.Size = new System.Drawing.Size(129, 31);
            this.BtnDelReguser.TabIndex = 15;
            this.BtnDelReguser.Text = "Delete Registered User";
            this.BtnDelReguser.UseVisualStyleBackColor = true;
            this.BtnDelReguser.Click += new System.EventHandler(this.BtnDelReguser_Click);
            // 
            // BtnChangeRole
            // 
            this.BtnChangeRole.Location = new System.Drawing.Point(227, 245);
            this.BtnChangeRole.Name = "BtnChangeRole";
            this.BtnChangeRole.Size = new System.Drawing.Size(129, 30);
            this.BtnChangeRole.TabIndex = 16;
            this.BtnChangeRole.Text = "Change Roles";
            this.BtnChangeRole.UseVisualStyleBackColor = true;
            this.BtnChangeRole.Click += new System.EventHandler(this.BtnChangeRole_Click);
            // 
            // ManageUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.BtnChangeRole);
            this.Controls.Add(this.BtnDelReguser);
            this.Controls.Add(this.BtnAddNewus);
            this.Controls.Add(this.BtnViewReg);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblManageUser);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageUserForm";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Label LblManageUser;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnViewReg;
        private System.Windows.Forms.Button BtnAddNewus;
        private System.Windows.Forms.Button BtnDelReguser;
        private System.Windows.Forms.Button BtnChangeRole;
    }
}