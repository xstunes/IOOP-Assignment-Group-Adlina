﻿namespace IOOP_Assignment_Group_Adlina
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
            this.LviewList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // LblViewUser
            // 
            this.LblViewUser.AutoSize = true;
            this.LblViewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblViewUser.Location = new System.Drawing.Point(186, 98);
            this.LblViewUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblViewUser.Name = "LblViewUser";
            this.LblViewUser.Size = new System.Drawing.Size(222, 24);
            this.LblViewUser.TabIndex = 11;
            this.LblViewUser.Text = "View Registered Users";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(211, 58);
            this.LblKL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(176, 20);
            this.LblKL.TabIndex = 10;
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
            this.LblRestaurant.TabIndex = 9;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // BtnBack2
            // 
            this.BtnBack2.Location = new System.Drawing.Point(112, 494);
            this.BtnBack2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBack2.Name = "BtnBack2";
            this.BtnBack2.Size = new System.Drawing.Size(59, 29);
            this.BtnBack2.TabIndex = 19;
            this.BtnBack2.Text = "Back";
            this.BtnBack2.UseVisualStyleBackColor = true;
            this.BtnBack2.Click += new System.EventHandler(this.BtnBack2_Click);
            // 
            // LviewList
            // 
            this.LviewList.HideSelection = false;
            this.LviewList.Location = new System.Drawing.Point(114, 141);
            this.LviewList.Name = "LviewList";
            this.LviewList.Size = new System.Drawing.Size(372, 309);
            this.LviewList.TabIndex = 20;
            this.LviewList.UseCompatibleStateImageBehavior = false;
            this.LviewList.SelectedIndexChanged += new System.EventHandler(this.LviewList_SelectedIndexChanged);
            // 
            // ViewUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(600, 548);
            this.Controls.Add(this.LviewList);
            this.Controls.Add(this.BtnBack2);
            this.Controls.Add(this.LblViewUser);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewUsersForm";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.ViewUsersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblViewUser;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Button BtnBack2;
        private System.Windows.Forms.ListView LviewList;
    }
}