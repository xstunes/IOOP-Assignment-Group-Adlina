namespace IOOP_Assignment_Group_Adlina
{
    partial class SalesForm
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
            this.CbSales = new System.Windows.Forms.ComboBox();
            this.LblFilter1 = new System.Windows.Forms.Label();
            this.BtnNext4 = new System.Windows.Forms.Button();
            this.BtnBack5 = new System.Windows.Forms.Button();
            this.LblSales = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbSales
            // 
            this.CbSales.FormattingEnabled = true;
            this.CbSales.Location = new System.Drawing.Point(332, 197);
            this.CbSales.Name = "CbSales";
            this.CbSales.Size = new System.Drawing.Size(163, 24);
            this.CbSales.TabIndex = 31;
            // 
            // LblFilter1
            // 
            this.LblFilter1.AutoSize = true;
            this.LblFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilter1.Location = new System.Drawing.Point(264, 201);
            this.LblFilter1.Name = "LblFilter1";
            this.LblFilter1.Size = new System.Drawing.Size(62, 20);
            this.LblFilter1.TabIndex = 30;
            this.LblFilter1.Text = "Filter : ";
            // 
            // BtnNext4
            // 
            this.BtnNext4.Location = new System.Drawing.Point(583, 643);
            this.BtnNext4.Name = "BtnNext4";
            this.BtnNext4.Size = new System.Drawing.Size(79, 36);
            this.BtnNext4.TabIndex = 29;
            this.BtnNext4.Text = "Next";
            this.BtnNext4.UseVisualStyleBackColor = true;
            // 
            // BtnBack5
            // 
            this.BtnBack5.Location = new System.Drawing.Point(148, 643);
            this.BtnBack5.Name = "BtnBack5";
            this.BtnBack5.Size = new System.Drawing.Size(79, 36);
            this.BtnBack5.TabIndex = 28;
            this.BtnBack5.Text = "Back";
            this.BtnBack5.UseVisualStyleBackColor = true;
            // 
            // LblSales
            // 
            this.LblSales.AutoSize = true;
            this.LblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSales.Location = new System.Drawing.Point(355, 147);
            this.LblSales.Name = "LblSales";
            this.LblSales.Size = new System.Drawing.Size(79, 29);
            this.LblSales.TabIndex = 27;
            this.LblSales.Text = "Sales";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(279, 96);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(222, 25);
            this.LblKL.TabIndex = 26;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(139, 42);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(523, 54);
            this.LblRestaurant.TabIndex = 25;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.CbSales);
            this.Controls.Add(this.LblFilter1);
            this.Controls.Add(this.BtnNext4);
            this.Controls.Add(this.BtnBack5);
            this.Controls.Add(this.LblSales);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbSales;
        private System.Windows.Forms.Label LblFilter1;
        private System.Windows.Forms.Button BtnNext4;
        private System.Windows.Forms.Button BtnBack5;
        private System.Windows.Forms.Label LblSales;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
    }
}