namespace Bivens_VehicleInventory
{
    partial class VehicleInventoryForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbLicense = new System.Windows.Forms.TextBox();
            this.txbVIN = new System.Windows.Forms.TextBox();
            this.cmbxType = new System.Windows.Forms.ComboBox();
            this.lbInventory = new System.Windows.Forms.ListBox();
            this.txbSummary = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbResults = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txbResults);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.cmbxType);
            this.tabPage1.Controls.Add(this.txbVIN);
            this.tabPage1.Controls.Add(this.txbLicense);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Vehicle Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txbSummary);
            this.tabPage2.Controls.Add(this.lbInventory);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventory List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Vehicle Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "License";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "VIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // txbLicense
            // 
            this.txbLicense.Location = new System.Drawing.Point(197, 80);
            this.txbLicense.Name = "txbLicense";
            this.txbLicense.Size = new System.Drawing.Size(100, 20);
            this.txbLicense.TabIndex = 4;
            // 
            // txbVIN
            // 
            this.txbVIN.Location = new System.Drawing.Point(197, 127);
            this.txbVIN.Name = "txbVIN";
            this.txbVIN.Size = new System.Drawing.Size(100, 20);
            this.txbVIN.TabIndex = 5;
            // 
            // cmbxType
            // 
            this.cmbxType.FormattingEnabled = true;
            this.cmbxType.Items.AddRange(new object[] {
            "Sedan",
            "Truck"});
            this.cmbxType.Location = new System.Drawing.Point(197, 174);
            this.cmbxType.Name = "cmbxType";
            this.cmbxType.Size = new System.Drawing.Size(121, 21);
            this.cmbxType.TabIndex = 6;
            this.cmbxType.Text = "Sedan";
            // 
            // lbInventory
            // 
            this.lbInventory.FormattingEnabled = true;
            this.lbInventory.Location = new System.Drawing.Point(71, 48);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(357, 186);
            this.lbInventory.TabIndex = 0;
            this.lbInventory.SelectedIndexChanged += new System.EventHandler(this.lbInventory_SelectedIndexChanged);
            // 
            // txbSummary
            // 
            this.txbSummary.Location = new System.Drawing.Point(71, 252);
            this.txbSummary.Multiline = true;
            this.txbSummary.Name = "txbSummary";
            this.txbSummary.ReadOnly = true;
            this.txbSummary.Size = new System.Drawing.Size(357, 129);
            this.txbSummary.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbResults
            // 
            this.txbResults.Location = new System.Drawing.Point(125, 276);
            this.txbResults.Multiline = true;
            this.txbResults.Name = "txbResults";
            this.txbResults.Size = new System.Drawing.Size(233, 84);
            this.txbResults.TabIndex = 8;
            // 
            // VehicleInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 449);
            this.Controls.Add(this.tabControl1);
            this.Name = "VehicleInventoryForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxType;
        private System.Windows.Forms.TextBox txbVIN;
        private System.Windows.Forms.TextBox txbLicense;
        private System.Windows.Forms.TextBox txbSummary;
        private System.Windows.Forms.ListBox lbInventory;
        private System.Windows.Forms.TextBox txbResults;
        private System.Windows.Forms.Button btnAdd;
    }
}

