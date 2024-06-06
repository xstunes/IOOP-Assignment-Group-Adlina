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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnViewReg = new System.Windows.Forms.Button();
            this.BtnAddNewus = new System.Windows.Forms.Button();
            this.BtnDelReguser = new System.Windows.Forms.Button();
            this.BtnChangeRole = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAddNew = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(96, 545);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(88, 45);
            this.BtnBack.TabIndex = 12;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnViewReg
            // 
            this.BtnViewReg.BackColor = System.Drawing.Color.Bisque;
            this.BtnViewReg.Location = new System.Drawing.Point(340, 220);
            this.BtnViewReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnViewReg.Name = "BtnViewReg";
            this.BtnViewReg.Size = new System.Drawing.Size(194, 48);
            this.BtnViewReg.TabIndex = 13;
            this.BtnViewReg.Text = "Registered Users";
            this.BtnViewReg.UseVisualStyleBackColor = false;
            this.BtnViewReg.Click += new System.EventHandler(this.BtnViewReg_Click);
            // 
            // BtnAddNewus
            // 
            this.BtnAddNewus.BackColor = System.Drawing.Color.Bisque;
            this.BtnAddNewus.Location = new System.Drawing.Point(340, 300);
            this.BtnAddNewus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddNewus.Name = "BtnAddNewus";
            this.BtnAddNewus.Size = new System.Drawing.Size(194, 48);
            this.BtnAddNewus.TabIndex = 14;
            this.BtnAddNewus.Text = "Add New User";
            this.BtnAddNewus.UseVisualStyleBackColor = false;
            this.BtnAddNewus.Click += new System.EventHandler(this.BtnAddNewus_Click);
            // 
            // BtnDelReguser
            // 
            this.BtnDelReguser.BackColor = System.Drawing.Color.Bisque;
            this.BtnDelReguser.Location = new System.Drawing.Point(340, 454);
            this.BtnDelReguser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDelReguser.Name = "BtnDelReguser";
            this.BtnDelReguser.Size = new System.Drawing.Size(194, 48);
            this.BtnDelReguser.TabIndex = 15;
            this.BtnDelReguser.Text = "Delete Registered User";
            this.BtnDelReguser.UseVisualStyleBackColor = false;
            this.BtnDelReguser.Click += new System.EventHandler(this.BtnDelReguser_Click);
            // 
            // BtnChangeRole
            // 
            this.BtnChangeRole.BackColor = System.Drawing.Color.Bisque;
            this.BtnChangeRole.Location = new System.Drawing.Point(340, 377);
            this.BtnChangeRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnChangeRole.Name = "BtnChangeRole";
            this.BtnChangeRole.Size = new System.Drawing.Size(194, 46);
            this.BtnChangeRole.TabIndex = 16;
            this.BtnChangeRole.Text = "Change Roles";
            this.BtnChangeRole.UseVisualStyleBackColor = false;
            this.BtnChangeRole.Click += new System.EventHandler(this.BtnChangeRole_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblAddNew);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 129);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hashbrown Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblAddNew
            // 
            this.LblAddNew.AutoSize = true;
            this.LblAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddNew.Location = new System.Drawing.Point(366, 93);
            this.LblAddNew.Name = "LblAddNew";
            this.LblAddNew.Size = new System.Drawing.Size(144, 24);
            this.LblAddNew.TabIndex = 8;
            this.LblAddNew.Text = "Manage Users";
            // 
            // ManageUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(900, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnChangeRole);
            this.Controls.Add(this.BtnDelReguser);
            this.Controls.Add(this.BtnAddNewus);
            this.Controls.Add(this.BtnViewReg);
            this.Controls.Add(this.BtnBack);
            this.Name = "ManageUserForm";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnViewReg;
        private System.Windows.Forms.Button BtnAddNewus;
        private System.Windows.Forms.Button BtnDelReguser;
        private System.Windows.Forms.Button BtnChangeRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAddNew;
    }
}