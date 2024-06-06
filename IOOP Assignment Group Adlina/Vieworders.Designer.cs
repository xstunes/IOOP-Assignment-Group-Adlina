namespace IOOP_Assignment_Group_Adlina
{
    partial class Vieworders
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
            this.listOrder = new System.Windows.Forms.ListBox();
            this.btnUpdateorder = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Oreders";
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 16;
            this.listOrder.Location = new System.Drawing.Point(157, 99);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(517, 276);
            this.listOrder.TabIndex = 1;
            this.listOrder.SelectedIndexChanged += new System.EventHandler(this.listOrder_SelectedIndexChanged);
            // 
            // btnUpdateorder
            // 
            this.btnUpdateorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateorder.Location = new System.Drawing.Point(533, 388);
            this.btnUpdateorder.Name = "btnUpdateorder";
            this.btnUpdateorder.Size = new System.Drawing.Size(141, 40);
            this.btnUpdateorder.TabIndex = 3;
            this.btnUpdateorder.Text = "Update Status";
            this.btnUpdateorder.UseVisualStyleBackColor = true;
            this.btnUpdateorder.Click += new System.EventHandler(this.btnUpdateorder_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "In Progres",
            "Completed"});
            this.comboBox1.Location = new System.Drawing.Point(406, 388);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // Vieworders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUpdateorder);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.label1);
            this.Name = "Vieworders";
            this.Text = "Vieworders";
            this.Load += new System.EventHandler(this.Vieworders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.Button btnUpdateorder;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}