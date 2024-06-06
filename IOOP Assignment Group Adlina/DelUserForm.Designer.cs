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
            this.LblUserID = new System.Windows.Forms.Label();
            this.TbUserID = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnBack3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAddNew = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserID.Location = new System.Drawing.Point(256, 152);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(100, 31);
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
            this.BtnDelete.Location = new System.Drawing.Point(352, 244);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(89, 33);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnBack3
            // 
            this.BtnBack3.Location = new System.Drawing.Point(75, 378);
            this.BtnBack3.Name = "BtnBack3";
            this.BtnBack3.Size = new System.Drawing.Size(79, 36);
            this.BtnBack3.TabIndex = 20;
            this.BtnBack3.Text = "Back";
            this.BtnBack3.UseVisualStyleBackColor = true;
            this.BtnBack3.Click += new System.EventHandler(this.BtnBack3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblAddNew);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 130);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hashbrown Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kuala Lumpur, Malaysia";
            // 
            // LblAddNew
            // 
            this.LblAddNew.AutoSize = true;
            this.LblAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddNew.Location = new System.Drawing.Point(274, 91);
            this.LblAddNew.Name = "LblAddNew";
            this.LblAddNew.Size = new System.Drawing.Size(288, 29);
            this.LblAddNew.TabIndex = 8;
            this.LblAddNew.Text = "Delete Registered User";
            // 
            // DelUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnBack3);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TbUserID);
            this.Controls.Add(this.LblUserID);
            this.Name = "DelUserForm";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.DelUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.TextBox TbUserID;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnBack3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAddNew;
    }
}