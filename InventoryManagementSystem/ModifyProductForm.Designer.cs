namespace InventoryManagementSystem
{
    partial class ModifyProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCandidateParts = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.btnAddAssociatedPart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteAssociatedPart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProductMax = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductInventory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductMin = new System.Windows.Forms.TextBox();
            this.txtProductMax = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductInventory = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCandidatePartSearch = new System.Windows.Forms.TextBox();
            this.btnCandidatePartSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidateParts
            // 
            this.dgvCandidateParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidateParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCandidateParts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCandidateParts.Location = new System.Drawing.Point(592, 92);
            this.dgvCandidateParts.Name = "dgvCandidateParts";
            this.dgvCandidateParts.ReadOnly = true;
            this.dgvCandidateParts.RowHeadersVisible = false;
            this.dgvCandidateParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCandidateParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidateParts.Size = new System.Drawing.Size(533, 199);
            this.dgvCandidateParts.TabIndex = 20;
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssociatedParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssociatedParts.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(592, 363);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.ReadOnly = true;
            this.dgvAssociatedParts.RowHeadersVisible = false;
            this.dgvAssociatedParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(533, 199);
            this.dgvAssociatedParts.TabIndex = 21;
            // 
            // btnAddAssociatedPart
            // 
            this.btnAddAssociatedPart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAssociatedPart.Location = new System.Drawing.Point(1028, 308);
            this.btnAddAssociatedPart.Name = "btnAddAssociatedPart";
            this.btnAddAssociatedPart.Size = new System.Drawing.Size(75, 31);
            this.btnAddAssociatedPart.TabIndex = 22;
            this.btnAddAssociatedPart.Text = "Add";
            this.btnAddAssociatedPart.UseVisualStyleBackColor = true;
            this.btnAddAssociatedPart.Click += new System.EventHandler(this.btnAddAssociatedPart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1032, 633);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteAssociatedPart
            // 
            this.btnDeleteAssociatedPart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAssociatedPart.Location = new System.Drawing.Point(1032, 580);
            this.btnDeleteAssociatedPart.Name = "btnDeleteAssociatedPart";
            this.btnDeleteAssociatedPart.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteAssociatedPart.TabIndex = 24;
            this.btnDeleteAssociatedPart.Text = "Delete";
            this.btnDeleteAssociatedPart.UseVisualStyleBackColor = true;
            this.btnDeleteAssociatedPart.Click += new System.EventHandler(this.btnDeleteAssociatedPart_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(938, 633);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProductMax
            // 
            this.lblProductMax.AutoSize = true;
            this.lblProductMax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductMax.Location = new System.Drawing.Point(148, 392);
            this.lblProductMax.Name = "lblProductMax";
            this.lblProductMax.Size = new System.Drawing.Size(33, 17);
            this.lblProductMax.TabIndex = 43;
            this.lblProductMax.Text = "Max";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(307, 392);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(30, 17);
            this.lblProduct.TabIndex = 42;
            this.lblProduct.Text = "Min";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(98, 343);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(75, 17);
            this.lblProductPrice.TabIndex = 41;
            this.lblProductPrice.Text = "Price / Cost";
            // 
            // lblProductInventory
            // 
            this.lblProductInventory.AutoSize = true;
            this.lblProductInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductInventory.Location = new System.Drawing.Point(117, 294);
            this.lblProductInventory.Name = "lblProductInventory";
            this.lblProductInventory.Size = new System.Drawing.Size(61, 17);
            this.lblProductInventory.TabIndex = 40;
            this.lblProductInventory.Text = "Inventory";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(136, 245);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(43, 17);
            this.lblProductName.TabIndex = 39;
            this.lblProductName.Text = "Name";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(162, 196);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(20, 17);
            this.lblProductID.TabIndex = 38;
            this.lblProductID.Text = "ID";
            // 
            // txtProductMin
            // 
            this.txtProductMin.BackColor = System.Drawing.Color.MistyRose;
            this.txtProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductMin.Location = new System.Drawing.Point(341, 392);
            this.txtProductMin.Name = "txtProductMin";
            this.txtProductMin.Size = new System.Drawing.Size(81, 26);
            this.txtProductMin.TabIndex = 36;
            this.toolTip5.SetToolTip(this.txtProductMin, "Min must be a whole number less than or equal to Max");
            this.txtProductMin.TextChanged += new System.EventHandler(this.txtProductMin_TextChanged);
            // 
            // txtProductMax
            // 
            this.txtProductMax.BackColor = System.Drawing.Color.MistyRose;
            this.txtProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductMax.Location = new System.Drawing.Point(221, 392);
            this.txtProductMax.Name = "txtProductMax";
            this.txtProductMax.Size = new System.Drawing.Size(80, 26);
            this.txtProductMax.TabIndex = 35;
            this.toolTip4.SetToolTip(this.txtProductMax, "Max must be a whole number greater than or equal to min");
            this.txtProductMax.TextChanged += new System.EventHandler(this.txtProductMax_TextChanged);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.BackColor = System.Drawing.Color.MistyRose;
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(221, 343);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(200, 26);
            this.txtProductPrice.TabIndex = 34;
            this.toolTip3.SetToolTip(this.txtProductPrice, "Price must be a number");
            this.txtProductPrice.TextChanged += new System.EventHandler(this.txtProductPrice_TextChanged);
            // 
            // txtProductInventory
            // 
            this.txtProductInventory.BackColor = System.Drawing.Color.MistyRose;
            this.txtProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductInventory.Location = new System.Drawing.Point(221, 294);
            this.txtProductInventory.Name = "txtProductInventory";
            this.txtProductInventory.Size = new System.Drawing.Size(200, 26);
            this.txtProductInventory.TabIndex = 33;
            this.toolTip2.SetToolTip(this.txtProductInventory, "Inventory Must be a whole number between Min and Max");
            this.txtProductInventory.TextChanged += new System.EventHandler(this.txtProductInventory_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.MistyRose;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(221, 245);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 26);
            this.txtProductName.TabIndex = 32;
            this.toolTip1.SetToolTip(this.txtProductName, "Name cannot be empty");
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(221, 196);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(200, 26);
            this.txtProductID.TabIndex = 31;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(39, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 21);
            this.lblTitle.TabIndex = 45;
            this.lblTitle.Text = "Modify Product";
            // 
            // txtCandidatePartSearch
            // 
            this.txtCandidatePartSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidatePartSearch.Location = new System.Drawing.Point(921, 46);
            this.txtCandidatePartSearch.Name = "txtCandidatePartSearch";
            this.txtCandidatePartSearch.Size = new System.Drawing.Size(204, 26);
            this.txtCandidatePartSearch.TabIndex = 47;
            // 
            // btnCandidatePartSearch
            // 
            this.btnCandidatePartSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidatePartSearch.Location = new System.Drawing.Point(836, 44);
            this.btnCandidatePartSearch.Name = "btnCandidatePartSearch";
            this.btnCandidatePartSearch.Size = new System.Drawing.Size(75, 31);
            this.btnCandidatePartSearch.TabIndex = 46;
            this.btnCandidatePartSearch.Text = "Search";
            this.btnCandidatePartSearch.UseVisualStyleBackColor = true;
            this.btnCandidatePartSearch.Click += new System.EventHandler(this.btnCandidatePartSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "All candidate Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Parts Associated with this Product";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 699);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCandidatePartSearch);
            this.Controls.Add(this.btnCandidatePartSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblProductMax);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductInventory);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.txtProductMin);
            this.Controls.Add(this.txtProductMax);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductInventory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteAssociatedPart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddAssociatedPart);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvCandidateParts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Product";
            this.toolTip1.SetToolTip(this, "Name cannot be empty");
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidateParts;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.Button btnAddAssociatedPart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteAssociatedPart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProductMax;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductInventory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductMin;
        private System.Windows.Forms.TextBox txtProductMax;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductInventory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCandidatePartSearch;
        private System.Windows.Forms.Button btnCandidatePartSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
    }
}