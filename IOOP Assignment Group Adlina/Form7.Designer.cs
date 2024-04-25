namespace IOOP_Assignment_Group_Adlina
{
    partial class Form7
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
            this.LblFeedback = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.BtnBack4 = new System.Windows.Forms.Button();
            this.BtnNext3 = new System.Windows.Forms.Button();
            this.LblFilter = new System.Windows.Forms.Label();
            this.CbFeedback = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblFeedback
            // 
            this.LblFeedback.AutoSize = true;
            this.LblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFeedback.Location = new System.Drawing.Point(332, 125);
            this.LblFeedback.Name = "LblFeedback";
            this.LblFeedback.Size = new System.Drawing.Size(129, 29);
            this.LblFeedback.TabIndex = 17;
            this.LblFeedback.Text = "Feedback";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(278, 74);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(222, 25);
            this.LblKL.TabIndex = 16;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(138, 20);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(523, 54);
            this.LblRestaurant.TabIndex = 15;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // BtnBack4
            // 
            this.BtnBack4.Location = new System.Drawing.Point(147, 621);
            this.BtnBack4.Name = "BtnBack4";
            this.BtnBack4.Size = new System.Drawing.Size(79, 36);
            this.BtnBack4.TabIndex = 21;
            this.BtnBack4.Text = "Back";
            this.BtnBack4.UseVisualStyleBackColor = true;
            // 
            // BtnNext3
            // 
            this.BtnNext3.Location = new System.Drawing.Point(582, 621);
            this.BtnNext3.Name = "BtnNext3";
            this.BtnNext3.Size = new System.Drawing.Size(79, 36);
            this.BtnNext3.TabIndex = 22;
            this.BtnNext3.Text = "Next";
            this.BtnNext3.UseVisualStyleBackColor = true;
            // 
            // LblFilter
            // 
            this.LblFilter.AutoSize = true;
            this.LblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilter.Location = new System.Drawing.Point(263, 179);
            this.LblFilter.Name = "LblFilter";
            this.LblFilter.Size = new System.Drawing.Size(62, 20);
            this.LblFilter.TabIndex = 23;
            this.LblFilter.Text = "Filter : ";
            // 
            // CbFeedback
            // 
            this.CbFeedback.FormattingEnabled = true;
            this.CbFeedback.Location = new System.Drawing.Point(331, 175);
            this.CbFeedback.Name = "CbFeedback";
            this.CbFeedback.Size = new System.Drawing.Size(163, 24);
            this.CbFeedback.TabIndex = 24;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.CbFeedback);
            this.Controls.Add(this.LblFilter);
            this.Controls.Add(this.BtnNext3);
            this.Controls.Add(this.BtnBack4);
            this.Controls.Add(this.LblFeedback);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFeedback;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Button BtnBack4;
        private System.Windows.Forms.Button BtnNext3;
        private System.Windows.Forms.Label LblFilter;
        private System.Windows.Forms.ComboBox CbFeedback;
    }
}