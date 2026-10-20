namespace InventoryManagementSystem
{
    partial class ModifyPartForm
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.txtPartInventory = new System.Windows.Forms.TextBox();
            this.txtPartPrice = new System.Windows.Forms.TextBox();
            this.txtPartMax = new System.Windows.Forms.TextBox();
            this.txtPartMin = new System.Windows.Forms.TextBox();
            this.txtPartDynamic = new System.Windows.Forms.TextBox();
            this.lblPartID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblPartDynamic = new System.Windows.Forms.Label();
            this.rbInHouse = new System.Windows.Forms.RadioButton();
            this.rbOutsourced = new System.Windows.Forms.RadioButton();
            this.lblModifyParts = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(336, 430);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 430);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPartID
            // 
            this.txtPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartID.Location = new System.Drawing.Point(189, 83);
            this.txtPartID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.ReadOnly = true;
            this.txtPartID.Size = new System.Drawing.Size(233, 26);
            this.txtPartID.TabIndex = 16;
            // 
            // txtPartName
            // 
            this.txtPartName.BackColor = System.Drawing.Color.MistyRose;
            this.txtPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartName.Location = new System.Drawing.Point(189, 140);
            this.txtPartName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(233, 26);
            this.txtPartName.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtPartName, "Name cannot be empty");
            this.txtPartName.TextChanged += new System.EventHandler(this.txtPartName_TextChanged);
            // 
            // txtPartInventory
            // 
            this.txtPartInventory.BackColor = System.Drawing.Color.MistyRose;
            this.txtPartInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartInventory.Location = new System.Drawing.Point(189, 196);
            this.txtPartInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPartInventory.Name = "txtPartInventory";
            this.txtPartInventory.Size = new System.Drawing.Size(233, 26);
            this.txtPartInventory.TabIndex = 18;
            this.toolTip2.SetToolTip(this.txtPartInventory, "Inventory Must be a whole number between Min and Max");
            this.txtPartInventory.TextChanged += new System.EventHandler(this.txtPartInventory_TextChanged);
            // 
            // txtPartPrice
            // 
            this.txtPartPrice.BackColor = System.Drawing.Color.MistyRose;
            this.txtPartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartPrice.Location = new System.Drawing.Point(189, 253);
            this.txtPartPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPartPrice.Name = "txtPartPrice";
            this.txtPartPrice.Size = new System.Drawing.Size(233, 26);
            this.txtPartPrice.TabIndex = 19;
            this.toolTip3.SetToolTip(this.txtPartPrice, "Price must be a number");
            this.txtPartPrice.TextChanged += new System.EventHandler(this.txtPartPrice_TextChanged);
            // 
            // txtPartMax
            // 
            this.txtPartMax.BackColor = System.Drawing.Color.MistyRose;
            this.txtPartMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartMax.Location = new System.Drawing.Point(189, 309);
            this.txtPartMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPartMax.Name = "txtPartMax";
            this.txtPartMax.Size = new System.Drawing.Size(93, 26);
            this.txtPartMax.TabIndex = 21;
            this.toolTip4.SetToolTip(this.txtPartMax, "Max must be a whole number greater than or equal to min");
            this.txtPartMax.TextChanged += new System.EventHandler(this.txtPartMax_TextChanged);
            // 
            // txtPartMin
            // 
            this.txtPartMin.BackColor = System.Drawing.Color.MistyRose;
            this.txtPartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartMin.Location = new System.Drawing.Point(329, 309);
            this.txtPartMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPartMin.Name = "txtPartMin";
            this.txtPartMin.Size = new System.Drawing.Size(94, 26);
            this.txtPartMin.TabIndex = 22;
            this.toolTip5.SetToolTip(this.txtPartMin, "Min must be a whole number less than or equal to Max");
            this.txtPartMin.TextChanged += new System.EventHandler(this.txtPartMin_TextChanged);
            // 
            // txtPartDynamic
            // 
            this.txtPartDynamic.BackColor = System.Drawing.Color.MistyRose;
            this.txtPartDynamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartDynamic.Location = new System.Drawing.Point(189, 366);
            this.txtPartDynamic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPartDynamic.Name = "txtPartDynamic";
            this.txtPartDynamic.Size = new System.Drawing.Size(233, 26);
            this.txtPartDynamic.TabIndex = 23;
            this.toolTip6.SetToolTip(this.txtPartDynamic, "Machine ID must be a whole number");
            this.txtPartDynamic.TextChanged += new System.EventHandler(this.txtPartDynamic_TextChanged);
            // 
            // lblPartID
            // 
            this.lblPartID.AutoSize = true;
            this.lblPartID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartID.Location = new System.Drawing.Point(130, 83);
            this.lblPartID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartID.Name = "lblPartID";
            this.lblPartID.Size = new System.Drawing.Size(20, 17);
            this.lblPartID.TabIndex = 24;
            this.lblPartID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(107, 140);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 17);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(89, 196);
            this.lblInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(61, 17);
            this.lblInventory.TabIndex = 26;
            this.lblInventory.Text = "Inventory";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(75, 253);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 17);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "Price / Cost";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(289, 309);
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(28, 15);
            this.lblMin.TabIndex = 28;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(117, 309);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(33, 17);
            this.lblMax.TabIndex = 29;
            this.lblMax.Text = "Max";
            // 
            // lblPartDynamic
            // 
            this.lblPartDynamic.AutoSize = true;
            this.lblPartDynamic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartDynamic.Location = new System.Drawing.Point(77, 366);
            this.lblPartDynamic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartDynamic.Name = "lblPartDynamic";
            this.lblPartDynamic.Size = new System.Drawing.Size(73, 17);
            this.lblPartDynamic.TabIndex = 30;
            this.lblPartDynamic.Text = "Machine ID";
            // 
            // rbInHouse
            // 
            this.rbInHouse.AutoSize = true;
            this.rbInHouse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInHouse.Location = new System.Drawing.Point(197, 32);
            this.rbInHouse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(87, 24);
            this.rbInHouse.TabIndex = 33;
            this.rbInHouse.TabStop = true;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.UseVisualStyleBackColor = true;
            this.rbInHouse.CheckedChanged += new System.EventHandler(this.rbInHouse_CheckedChanged);
            // 
            // rbOutsourced
            // 
            this.rbOutsourced.AutoSize = true;
            this.rbOutsourced.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutsourced.Location = new System.Drawing.Point(307, 32);
            this.rbOutsourced.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(103, 24);
            this.rbOutsourced.TabIndex = 34;
            this.rbOutsourced.TabStop = true;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.UseVisualStyleBackColor = true;
            // 
            // lblModifyParts
            // 
            this.lblModifyParts.AutoSize = true;
            this.lblModifyParts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyParts.Location = new System.Drawing.Point(26, 21);
            this.lblModifyParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModifyParts.Name = "lblModifyParts";
            this.lblModifyParts.Size = new System.Drawing.Size(100, 21);
            this.lblModifyParts.TabIndex = 35;
            this.lblModifyParts.Text = "Modify Part";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5500;
            this.toolTip1.InitialDelay = 220;
            this.toolTip1.ReshowDelay = 110;
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 5500;
            this.toolTip2.InitialDelay = 220;
            this.toolTip2.ReshowDelay = 110;
            // 
            // toolTip3
            // 
            this.toolTip3.AutoPopDelay = 5500;
            this.toolTip3.InitialDelay = 220;
            this.toolTip3.ReshowDelay = 110;
            // 
            // toolTip4
            // 
            this.toolTip4.AutoPopDelay = 5500;
            this.toolTip4.InitialDelay = 220;
            this.toolTip4.ReshowDelay = 110;
            // 
            // toolTip5
            // 
            this.toolTip5.AutoPopDelay = 5500;
            this.toolTip5.InitialDelay = 220;
            this.toolTip5.ReshowDelay = 110;
            // 
            // toolTip6
            // 
            this.toolTip6.AutoPopDelay = 5500;
            this.toolTip6.InitialDelay = 220;
            this.toolTip6.ReshowDelay = 110;
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 532);
            this.Controls.Add(this.lblModifyParts);
            this.Controls.Add(this.rbOutsourced);
            this.Controls.Add(this.rbInHouse);
            this.Controls.Add(this.lblPartDynamic);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPartID);
            this.Controls.Add(this.txtPartDynamic);
            this.Controls.Add(this.txtPartMin);
            this.Controls.Add(this.txtPartMax);
            this.Controls.Add(this.txtPartPrice);
            this.Controls.Add(this.txtPartInventory);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.TextBox txtPartInventory;
        private System.Windows.Forms.TextBox txtPartPrice;
        private System.Windows.Forms.TextBox txtPartMax;
        private System.Windows.Forms.TextBox txtPartMin;
        private System.Windows.Forms.TextBox txtPartDynamic;
        private System.Windows.Forms.Label lblPartID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPartDynamic;
        private System.Windows.Forms.RadioButton rbInHouse;
        private System.Windows.Forms.RadioButton rbOutsourced;
        private System.Windows.Forms.Label lblModifyParts;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}