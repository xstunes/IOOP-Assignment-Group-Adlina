﻿namespace IOOP_Assignment_Group_Adlina
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
            this.TbNewUser = new System.Windows.Forms.TextBox();
            this.LblNewUser = new System.Windows.Forms.Label();
            this.BtnBack6 = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAddNew = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbNewUser
            // 
            this.TbNewUser.Location = new System.Drawing.Point(309, 320);
            this.TbNewUser.Name = "TbNewUser";
            this.TbNewUser.Size = new System.Drawing.Size(298, 26);
            this.TbNewUser.TabIndex = 19;
            // 
            // LblNewUser
            // 
            this.LblNewUser.AutoSize = true;
            this.LblNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewUser.Location = new System.Drawing.Point(304, 278);
            this.LblNewUser.Name = "LblNewUser";
            this.LblNewUser.Size = new System.Drawing.Size(246, 37);
            this.LblNewUser.TabIndex = 20;
            this.LblNewUser.Text = "New Username:";
            // 
            // BtnBack6
            // 
            this.BtnBack6.Location = new System.Drawing.Point(75, 480);
            this.BtnBack6.Name = "BtnBack6";
            this.BtnBack6.Size = new System.Drawing.Size(88, 45);
            this.BtnBack6.TabIndex = 29;
            this.BtnBack6.Text = "Back";
            this.BtnBack6.UseVisualStyleBackColor = true;
            this.BtnBack6.Click += new System.EventHandler(this.BtnBack6_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(737, 480);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(88, 45);
            this.BtnUpdate.TabIndex = 30;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblAddNew);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 162);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hashbrown Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblAddNew
            // 
            this.LblAddNew.AutoSize = true;
            this.LblAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddNew.Location = new System.Drawing.Point(305, 117);
            this.LblAddNew.Name = "LblAddNew";
            this.LblAddNew.Size = new System.Drawing.Size(371, 32);
            this.LblAddNew.TabIndex = 8;
            this.LblAddNew.Text = "Profile Setting : Username";
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnBack6);
            this.Controls.Add(this.LblNewUser);
            this.Controls.Add(this.TbNewUser);
            this.Name = "NewUserForm";
            this.Text = "New User Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbNewUser;
        private System.Windows.Forms.Label LblNewUser;
        private System.Windows.Forms.Button BtnBack6;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAddNew;
    }
}