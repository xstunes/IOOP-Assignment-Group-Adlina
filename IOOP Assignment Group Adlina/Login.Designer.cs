﻿namespace IOOP_Assignment_Group_Adlina
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblLoginUserEmail = new System.Windows.Forms.Label();
            this.LblLoginPass = new System.Windows.Forms.Label();
            this.TbLoginUserEmail = new System.Windows.Forms.TextBox();
            this.TbLoginPass = new System.Windows.Forms.TextBox();
            this.LlForgotPass = new System.Windows.Forms.LinkLabel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnSignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.BackColor = System.Drawing.Color.Bisque;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(152, 23);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(634, 65);
            this.LblRestaurant.TabIndex = 0;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(338, 91);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(267, 29);
            this.LblKL.TabIndex = 1;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(429, 143);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(90, 32);
            this.LblLogin.TabIndex = 2;
            this.LblLogin.Text = "Login";
            // 
            // LblLoginUserEmail
            // 
            this.LblLoginUserEmail.AutoSize = true;
            this.LblLoginUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoginUserEmail.Location = new System.Drawing.Point(242, 197);
            this.LblLoginUserEmail.Name = "LblLoginUserEmail";
            this.LblLoginUserEmail.Size = new System.Drawing.Size(194, 25);
            this.LblLoginUserEmail.TabIndex = 3;
            this.LblLoginUserEmail.Text = "Username or Email";
            // 
            // LblLoginPass
            // 
            this.LblLoginPass.AutoSize = true;
            this.LblLoginPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoginPass.Location = new System.Drawing.Point(242, 283);
            this.LblLoginPass.Name = "LblLoginPass";
            this.LblLoginPass.Size = new System.Drawing.Size(106, 25);
            this.LblLoginPass.TabIndex = 4;
            this.LblLoginPass.Text = "Password";
            // 
            // TbLoginUserEmail
            // 
            this.TbLoginUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLoginUserEmail.Location = new System.Drawing.Point(246, 225);
            this.TbLoginUserEmail.Name = "TbLoginUserEmail";
            this.TbLoginUserEmail.Size = new System.Drawing.Size(379, 28);
            this.TbLoginUserEmail.TabIndex = 5;
            // 
            // TbLoginPass
            // 
            this.TbLoginPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLoginPass.Location = new System.Drawing.Point(246, 311);
            this.TbLoginPass.Name = "TbLoginPass";
            this.TbLoginPass.Size = new System.Drawing.Size(379, 28);
            this.TbLoginPass.TabIndex = 6;
            this.TbLoginPass.UseSystemPasswordChar = true;
            // 
            // LlForgotPass
            // 
            this.LlForgotPass.AutoSize = true;
            this.LlForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlForgotPass.Location = new System.Drawing.Point(474, 345);
            this.LlForgotPass.Name = "LlForgotPass";
            this.LlForgotPass.Size = new System.Drawing.Size(174, 25);
            this.LlForgotPass.TabIndex = 7;
            this.LlForgotPass.TabStop = true;
            this.LlForgotPass.Text = "Forgot Password";
            this.LlForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlForgotPass_LinkClicked);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(579, 418);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 49);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnSignup
            // 
            this.BtnSignup.Location = new System.Drawing.Point(224, 418);
            this.BtnSignup.Name = "BtnSignup";
            this.BtnSignup.Size = new System.Drawing.Size(100, 49);
            this.BtnSignup.TabIndex = 9;
            this.BtnSignup.Text = "Sign Up";
            this.BtnSignup.UseVisualStyleBackColor = true;
            this.BtnSignup.Click += new System.EventHandler(this.BtnSignup_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.BtnSignup);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LlForgotPass);
            this.Controls.Add(this.TbLoginPass);
            this.Controls.Add(this.TbLoginUserEmail);
            this.Controls.Add(this.LblLoginPass);
            this.Controls.Add(this.LblLoginUserEmail);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblLoginUserEmail;
        private System.Windows.Forms.Label LblLoginPass;
        private System.Windows.Forms.TextBox TbLoginUserEmail;
        private System.Windows.Forms.TextBox TbLoginPass;
        private System.Windows.Forms.LinkLabel LlForgotPass;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnSignup;
    }
}