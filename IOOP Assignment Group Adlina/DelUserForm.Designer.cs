namespace IOOP_Assignment_Group_Adlina
{
    partial class DelUserForm
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
            this.LblDelUser = new System.Windows.Forms.Label();
            this.LblKL = new System.Windows.Forms.Label();
            this.LblRestaurant = new System.Windows.Forms.Label();
            this.LblUserID = new System.Windows.Forms.Label();
            this.TbUserID = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnBack3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDelUser
            // 
            this.LblDelUser.AutoSize = true;
            this.LblDelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDelUser.Location = new System.Drawing.Point(257, 123);
            this.LblDelUser.Name = "LblDelUser";
            this.LblDelUser.Size = new System.Drawing.Size(288, 29);
            this.LblDelUser.TabIndex = 14;
            this.LblDelUser.Text = "Delete Registered User";
            // 
            // LblKL
            // 
            this.LblKL.AutoSize = true;
            this.LblKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKL.Location = new System.Drawing.Point(290, 74);
            this.LblKL.Name = "LblKL";
            this.LblKL.Size = new System.Drawing.Size(222, 25);
            this.LblKL.TabIndex = 13;
            this.LblKL.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblRestaurant
            // 
            this.LblRestaurant.AutoSize = true;
            this.LblRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestaurant.Location = new System.Drawing.Point(150, 20);
            this.LblRestaurant.Name = "LblRestaurant";
            this.LblRestaurant.Size = new System.Drawing.Size(523, 54);
            this.LblRestaurant.TabIndex = 12;
            this.LblRestaurant.Text = "Hashbrown Restaurant";
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserID.Location = new System.Drawing.Point(258, 183);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(62, 20);
            this.LblUserID.TabIndex = 15;
            this.LblUserID.Text = "UserID";
            // 
            // TbUserID
            // 
            this.TbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUserID.Location = new System.Drawing.Point(262, 206);
            this.TbUserID.Name = "TbUserID";
            this.TbUserID.Size = new System.Drawing.Size(280, 24);
            this.TbUserID.TabIndex = 16;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(351, 255);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(89, 33);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnBack3
            // 
            this.BtnBack3.Location = new System.Drawing.Point(159, 379);
            this.BtnBack3.Name = "BtnBack3";
            this.BtnBack3.Size = new System.Drawing.Size(79, 36);
            this.BtnBack3.TabIndex = 20;
            this.BtnBack3.Text = "Back";
            this.BtnBack3.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack3);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TbUserID);
            this.Controls.Add(this.LblUserID);
            this.Controls.Add(this.LblDelUser);
            this.Controls.Add(this.LblKL);
            this.Controls.Add(this.LblRestaurant);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDelUser;
        private System.Windows.Forms.Label LblKL;
        private System.Windows.Forms.Label LblRestaurant;
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.TextBox TbUserID;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnBack3;
    }
}