﻿namespace IOOP_Assignment_Group_Adlina
{
    partial class NewPassForm
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
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnBack6 = new System.Windows.Forms.Button();
            this.LblNewPass = new System.Windows.Forms.Label();
            this.TbNewPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAddNew = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(750, 472);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(88, 45);
            this.BtnUpdate.TabIndex = 34;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnBack6
            // 
            this.BtnBack6.Location = new System.Drawing.Point(69, 472);
            this.BtnBack6.Name = "BtnBack6";
            this.BtnBack6.Size = new System.Drawing.Size(88, 45);
            this.BtnBack6.TabIndex = 33;
            this.BtnBack6.Text = "Back";
            this.BtnBack6.UseVisualStyleBackColor = true;
            this.BtnBack6.Click += new System.EventHandler(this.BtnBack6_Click);
            // 
            // LblNewPass
            // 
            this.LblNewPass.AutoSize = true;
            this.LblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewPass.Location = new System.Drawing.Point(296, 272);
            this.LblNewPass.Name = "LblNewPass";
            this.LblNewPass.Size = new System.Drawing.Size(160, 25);
            this.LblNewPass.TabIndex = 35;
            this.LblNewPass.Text = "New Password:";
            // 
            // TbNewPass
            // 
            this.TbNewPass.Location = new System.Drawing.Point(300, 320);
            this.TbNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbNewPass.Name = "TbNewPass";
            this.TbNewPass.Size = new System.Drawing.Size(302, 26);
            this.TbNewPass.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblAddNew);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 129);
            this.panel1.TabIndex = 37;
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
            this.LblAddNew.Location = new System.Drawing.Point(314, 93);
            this.LblAddNew.Name = "LblAddNew";
            this.LblAddNew.Size = new System.Drawing.Size(247, 24);
            this.LblAddNew.TabIndex = 8;
            this.LblAddNew.Text = "Profile Setting : Password";
            // 
            // NewPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TbNewPass);
            this.Controls.Add(this.LblNewPass);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnBack6);
            this.Name = "NewPassForm";
            this.Text = "Form11";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnBack6;
        private System.Windows.Forms.Label LblNewPass;
        private System.Windows.Forms.TextBox TbNewPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAddNew;
    }
}