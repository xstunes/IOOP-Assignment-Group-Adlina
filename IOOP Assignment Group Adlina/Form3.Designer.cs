namespace IOOP_Assignment_Group_Adlina
{
    partial class Form3
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
            this.RbtnAddNew = new System.Windows.Forms.RadioButton();
            this.RbtnViewUsers = new System.Windows.Forms.RadioButton();
            this.RbtnDeleteUser = new System.Windows.Forms.RadioButton();
            this.BtnNext1 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(282, 73);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(222, 25);
            this.LblKL.TabIndex = 5;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(142, 19);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(523, 54);
            this.LblRestaurant.TabIndex = 4;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // LblManageUser
            // 
            this.LblManageUser.AutoSize = true;
            this.LblManageUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblManageUser.Location = new System.Drawing.Point(297, 114);
            this.LblManageUser.Name = "LblManageUser";
            this.LblManageUser.Size = new System.Drawing.Size(181, 29);
            this.LblManageUser.TabIndex = 6;
            this.LblManageUser.Text = "Manage Users";
            // 
            // RbtnAddNew
            // 
            this.RbtnAddNew.AutoSize = true;
            this.RbtnAddNew.Location = new System.Drawing.Point(320, 205);
            this.RbtnAddNew.Name = "RbtnAddNew";
            this.RbtnAddNew.Size = new System.Drawing.Size(115, 20);
            this.RbtnAddNew.TabIndex = 7;
            this.RbtnAddNew.TabStop = true;
            this.RbtnAddNew.Text = "Add New User";
            this.RbtnAddNew.UseVisualStyleBackColor = true;
            // 
            // RbtnViewUsers
            // 
            this.RbtnViewUsers.AutoSize = true;
            this.RbtnViewUsers.Location = new System.Drawing.Point(320, 250);
            this.RbtnViewUsers.Name = "RbtnViewUsers";
            this.RbtnViewUsers.Size = new System.Drawing.Size(166, 20);
            this.RbtnViewUsers.TabIndex = 8;
            this.RbtnViewUsers.TabStop = true;
            this.RbtnViewUsers.Text = "View Registered Users";
            this.RbtnViewUsers.UseVisualStyleBackColor = true;
            // 
            // RbtnDeleteUser
            // 
            this.RbtnDeleteUser.AutoSize = true;
            this.RbtnDeleteUser.Location = new System.Drawing.Point(320, 294);
            this.RbtnDeleteUser.Name = "RbtnDeleteUser";
            this.RbtnDeleteUser.Size = new System.Drawing.Size(170, 20);
            this.RbtnDeleteUser.TabIndex = 9;
            this.RbtnDeleteUser.TabStop = true;
            this.RbtnDeleteUser.Text = "Delete Registered User";
            this.RbtnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // BtnNext1
            // 
            this.BtnNext1.Location = new System.Drawing.Point(586, 389);
            this.BtnNext1.Name = "BtnNext1";
            this.BtnNext1.Size = new System.Drawing.Size(79, 36);
            this.BtnNext1.TabIndex = 11;
            this.BtnNext1.Text = "Next";
            this.BtnNext1.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(151, 389);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(79, 36);
            this.BtnBack.TabIndex = 12;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnNext1);
            this.Controls.Add(this.RbtnDeleteUser);
            this.Controls.Add(this.RbtnViewUsers);
            this.Controls.Add(this.RbtnAddNew);
            this.Controls.Add(this.LblManageUser);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Label LblManageUser;
        private System.Windows.Forms.RadioButton RbtnAddNew;
        private System.Windows.Forms.RadioButton RbtnViewUsers;
        private System.Windows.Forms.RadioButton RbtnDeleteUser;
        private System.Windows.Forms.Button BtnNext1;
        private System.Windows.Forms.Button BtnBack;
    }
}