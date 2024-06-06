namespace IOOP_Assignment_Group_Adlina
{
    partial class ChefForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnUpdateprofile = new System.Windows.Forms.Button();
            this.btnManageInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chef";
            // 
            // btnorder
            // 
            this.btnorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.Location = new System.Drawing.Point(283, 203);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(230, 44);
            this.btnorder.TabIndex = 2;
            this.btnorder.Text = "Orders";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnUpdateprofile
            // 
            this.btnUpdateprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateprofile.Location = new System.Drawing.Point(283, 253);
            this.btnUpdateprofile.Name = "btnUpdateprofile";
            this.btnUpdateprofile.Size = new System.Drawing.Size(230, 44);
            this.btnUpdateprofile.TabIndex = 4;
            this.btnUpdateprofile.Text = "Update Profile";
            this.btnUpdateprofile.UseVisualStyleBackColor = true;
            this.btnUpdateprofile.Click += new System.EventHandler(this.btnUpdateprofile_Click);
            // 
            // btnManageInventory
            // 
            this.btnManageInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInventory.Location = new System.Drawing.Point(283, 303);
            this.btnManageInventory.Name = "btnManageInventory";
            this.btnManageInventory.Size = new System.Drawing.Size(230, 44);
            this.btnManageInventory.TabIndex = 5;
            this.btnManageInventory.Text = "Manage Inventory";
            this.btnManageInventory.UseVisualStyleBackColor = true;
            this.btnManageInventory.Click += new System.EventHandler(this.btnManageInventory_Click);
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageInventory);
            this.Controls.Add(this.btnUpdateprofile);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.label1);
            this.Name = "ChefForm";
            this.Text = "ChefForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnUpdateprofile;
        private System.Windows.Forms.Button btnManageInventory;
    }
}