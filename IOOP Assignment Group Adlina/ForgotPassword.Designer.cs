﻿namespace IOOP_Assignment_Group_Adlina
{
    partial class ForgotPassword
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
            this.BtnGen = new System.Windows.Forms.Button();
            this.LblGenPass = new System.Windows.Forms.Label();
            this.LblNewPass = new System.Windows.Forms.Label();
            this.LblShowForgotpass = new System.Windows.Forms.Label();
            this.BtnBack3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGen
            // 
            this.BtnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGen.Location = new System.Drawing.Point(476, 445);
            this.BtnGen.Name = "BtnGen";
            this.BtnGen.Size = new System.Drawing.Size(93, 42);
            this.BtnGen.TabIndex = 34;
            this.BtnGen.Text = "Generate";
            this.BtnGen.UseVisualStyleBackColor = true;
            // 
            // LblGenPass
            // 
            this.LblGenPass.AutoSize = true;
            this.LblGenPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenPass.Location = new System.Drawing.Point(473, 398);
            this.LblGenPass.Name = "LblGenPass";
            this.LblGenPass.Size = new System.Drawing.Size(136, 24);
            this.LblGenPass.TabIndex = 33;
            this.LblGenPass.Text = "New Password";
            // 
            // LblNewPass
            // 
            this.LblNewPass.AutoSize = true;
            this.LblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewPass.Location = new System.Drawing.Point(473, 354);
            this.LblNewPass.Name = "LblNewPass";
            this.LblNewPass.Size = new System.Drawing.Size(238, 24);
            this.LblNewPass.TabIndex = 32;
            this.LblNewPass.Text = "Auto-generated Password :";
            // 
            // LblShowForgotpass
            // 
            this.LblShowForgotpass.AutoSize = true;
            this.LblShowForgotpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShowForgotpass.Location = new System.Drawing.Point(471, 246);
            this.LblShowForgotpass.Name = "LblShowForgotpass";
            this.LblShowForgotpass.Size = new System.Drawing.Size(235, 31);
            this.LblShowForgotpass.TabIndex = 35;
            this.LblShowForgotpass.Text = "Forgot Password";
            // 
            // BtnBack3
            // 
            this.BtnBack3.Location = new System.Drawing.Point(477, 507);
            this.BtnBack3.Name = "BtnBack3";
            this.BtnBack3.Size = new System.Drawing.Size(92, 36);
            this.BtnBack3.TabIndex = 36;
            this.BtnBack3.Text = "Back";
            this.BtnBack3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.LblRestaurant);
            this.panel1.Controls.Add(this.LblKL);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 129);
            this.panel1.TabIndex = 37;
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(372, 30);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(426, 44);
            this.LblRestaurant.TabIndex = 6;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(494, 74);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(176, 20);
            this.LblKL.TabIndex = 7;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnBack3);
            this.Controls.Add(this.LblShowForgotpass);
            this.Controls.Add(this.BtnGen);
            this.Controls.Add(this.LblGenPass);
            this.Controls.Add(this.LblNewPass);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForgotPassword";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGen;
        private System.Windows.Forms.Label LblGenPass;
        private System.Windows.Forms.Label LblNewPass;
        private System.Windows.Forms.Label LblShowForgotpass;
        private System.Windows.Forms.Button BtnBack3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Label LblKL;
    }
}