namespace IOOP_Assignment_Group_Adlina
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
            this.SuspendLayout();
            // 
            // BtnGen
            // 
            this.BtnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGen.Location = new System.Drawing.Point(298, 224);
            this.BtnGen.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGen.Name = "BtnGen";
            this.BtnGen.Size = new System.Drawing.Size(62, 27);
            this.BtnGen.TabIndex = 34;
            this.BtnGen.Text = "Generate";
            this.BtnGen.UseVisualStyleBackColor = true;
            // 
            // LblGenPass
            // 
            this.LblGenPass.AutoSize = true;
            this.LblGenPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenPass.Location = new System.Drawing.Point(296, 194);
            this.LblGenPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGenPass.Name = "LblGenPass";
            this.LblGenPass.Size = new System.Drawing.Size(100, 17);
            this.LblGenPass.TabIndex = 33;
            this.LblGenPass.Text = "New Password";
            // 
            // LblNewPass
            // 
            this.LblNewPass.AutoSize = true;
            this.LblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewPass.Location = new System.Drawing.Point(296, 165);
            this.LblNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewPass.Name = "LblNewPass";
            this.LblNewPass.Size = new System.Drawing.Size(180, 17);
            this.LblNewPass.TabIndex = 32;
            this.LblNewPass.Text = "Auto-generated Password :";
            // 
            // LblShowForgotpass
            // 
            this.LblShowForgotpass.AutoSize = true;
            this.LblShowForgotpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShowForgotpass.Location = new System.Drawing.Point(295, 95);
            this.LblShowForgotpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblShowForgotpass.Name = "LblShowForgotpass";
            this.LblShowForgotpass.Size = new System.Drawing.Size(167, 24);
            this.LblShowForgotpass.TabIndex = 35;
            this.LblShowForgotpass.Text = "Forgot Password";
            // 
            // BtnBack3
            // 
            this.BtnBack3.Location = new System.Drawing.Point(355, 306);
            this.BtnBack3.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack3.Name = "BtnBack3";
            this.BtnBack3.Size = new System.Drawing.Size(59, 29);
            this.BtnBack3.TabIndex = 36;
            this.BtnBack3.Text = "Back";
            this.BtnBack3.UseVisualStyleBackColor = true;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack3);
            this.Controls.Add(this.LblShowForgotpass);
            this.Controls.Add(this.BtnGen);
            this.Controls.Add(this.LblGenPass);
            this.Controls.Add(this.LblNewPass);
            this.Name = "ForgotPassword";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGen;
        private System.Windows.Forms.Label LblGenPass;
        private System.Windows.Forms.Label LblNewPass;
        private System.Windows.Forms.Label LblShowForgotpass;
        private System.Windows.Forms.Button BtnBack3;
    }
}