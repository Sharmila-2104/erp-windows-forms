namespace ERP.Purchase.Item.Master
{
    partial class ItemCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.GV_ItemCategoryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_ItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_IC_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UnderICategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemCategoryNumber_Txt = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.UnderICategory_Cmbx = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.ItemCategory_Txt_Special = new System.Windows.Forms.TextBox();
            this.IC_Description_Txt_Special = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GV_List
            // 
            this.GV_List.AllowUserToAddRows = false;
            this.GV_List.AllowUserToDeleteRows = false;
            this.GV_List.AllowUserToOrderColumns = true;
            this.GV_List.BackgroundColor = System.Drawing.Color.White;
            this.GV_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_ItemCategoryNumber,
            this.GV_ItemCategory,
            this.GV_IC_Description,
            this.GV_UnderICategory,
            this.DeleteColumn,
            this.UpdateColumn});
            this.GV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_List.Location = new System.Drawing.Point(15, 15);
            this.GV_List.Margin = new System.Windows.Forms.Padding(4);
            this.GV_List.Name = "GV_List";
            this.GV_List.ReadOnly = true;
            this.GV_List.RowTemplate.Height = 25;
            this.GV_List.Size = new System.Drawing.Size(680, 520);
            this.GV_List.TabIndex = 12;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            // 
            // GV_ItemCategoryNumber
            // 
            this.GV_ItemCategoryNumber.DataPropertyName = "ItemCategoryNumber";
            this.GV_ItemCategoryNumber.HeaderText = "Number";
            this.GV_ItemCategoryNumber.Name = "GV_ItemCategoryNumber";
            this.GV_ItemCategoryNumber.ReadOnly = true;
            this.GV_ItemCategoryNumber.Visible = false;
            // 
            // GV_ItemCategory
            // 
            this.GV_ItemCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_ItemCategory.DataPropertyName = "ItemCategory";
            this.GV_ItemCategory.FillWeight = 74.93917F;
            this.GV_ItemCategory.HeaderText = "Category";
            this.GV_ItemCategory.Name = "GV_ItemCategory";
            this.GV_ItemCategory.ReadOnly = true;
            // 
            // GV_IC_Description
            // 
            this.GV_IC_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_IC_Description.DataPropertyName = "IC_Description";
            this.GV_IC_Description.FillWeight = 74.93917F;
            this.GV_IC_Description.HeaderText = "Description";
            this.GV_IC_Description.Name = "GV_IC_Description";
            this.GV_IC_Description.ReadOnly = true;
            // 
            // GV_UnderICategory
            // 
            this.GV_UnderICategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_UnderICategory.DataPropertyName = "UnderICategory";
            this.GV_UnderICategory.FillWeight = 74.93917F;
            this.GV_UnderICategory.HeaderText = "Under";
            this.GV_UnderICategory.Name = "GV_UnderICategory";
            this.GV_UnderICategory.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Image = global::ERP.Properties.Resources.delete;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteColumn.Width = 60;
            // 
            // UpdateColumn
            // 
            this.UpdateColumn.FillWeight = 175.1825F;
            this.UpdateColumn.HeaderText = "Edit";
            this.UpdateColumn.Image = global::ERP.Properties.Resources.edit;
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.ReadOnly = true;
            this.UpdateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UpdateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UpdateColumn.Width = 60;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.GV_List);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(15, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(710, 550);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel2.Size = new System.Drawing.Size(1158, 625);
            this.panel2.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(15, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(15);
            this.splitContainer1.Panel1MinSize = 350;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1128, 610);
            this.splitContainer1.SplitterDistance = 398;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ItemCategoryNumber_Txt);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.UnderICategory_Cmbx);
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.ItemCategory_Txt_Special);
            this.groupBox1.Controls.Add(this.IC_Description_Txt_Special);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(368, 580);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Category";
            // 
            // ItemCategoryNumber_Txt
            // 
            this.ItemCategoryNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemCategoryNumber_Txt.Location = new System.Drawing.Point(127, 20);
            this.ItemCategoryNumber_Txt.Margin = new System.Windows.Forms.Padding(5);
            this.ItemCategoryNumber_Txt.Name = "ItemCategoryNumber_Txt";
            this.ItemCategoryNumber_Txt.Size = new System.Drawing.Size(226, 23);
            this.ItemCategoryNumber_Txt.TabIndex = 44;
            this.ItemCategoryNumber_Txt.Visible = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Location = new System.Drawing.Point(127, 244);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(82, 37);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // UnderICategory_Cmbx
            // 
            this.UnderICategory_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderICategory_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnderICategory_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UnderICategory_Cmbx.FormattingEnabled = true;
            this.UnderICategory_Cmbx.Location = new System.Drawing.Point(127, 201);
            this.UnderICategory_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.UnderICategory_Cmbx.Name = "UnderICategory_Cmbx";
            this.UnderICategory_Cmbx.Size = new System.Drawing.Size(226, 24);
            this.UnderICategory_Cmbx.TabIndex = 3;
            this.UnderICategory_Cmbx.Tag = "UnderICategory";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(77, 205);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(45, 16);
            this.Category.TabIndex = 23;
            this.Category.Text = "Under";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Item Category";
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Location = new System.Drawing.Point(127, 244);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(82, 37);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(217, 244);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(82, 37);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // ItemCategory_Txt_Special
            // 
            this.ItemCategory_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemCategory_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemCategory_Txt_Special.Location = new System.Drawing.Point(127, 60);
            this.ItemCategory_Txt_Special.Margin = new System.Windows.Forms.Padding(4);
            this.ItemCategory_Txt_Special.MaxLength = 30;
            this.ItemCategory_Txt_Special.Name = "ItemCategory_Txt_Special";
            this.ItemCategory_Txt_Special.Size = new System.Drawing.Size(226, 23);
            this.ItemCategory_Txt_Special.TabIndex = 1;
            this.ItemCategory_Txt_Special.Tag = "ItemCategory";
            this.ItemCategory_Txt_Special.Leave += new System.EventHandler(this.ItemCategory_txt_Leave);
            // 
            // IC_Description_Txt_Special
            // 
            this.IC_Description_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IC_Description_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IC_Description_Txt_Special.Location = new System.Drawing.Point(127, 98);
            this.IC_Description_Txt_Special.Margin = new System.Windows.Forms.Padding(4);
            this.IC_Description_Txt_Special.MaxLength = 50;
            this.IC_Description_Txt_Special.Multiline = true;
            this.IC_Description_Txt_Special.Name = "IC_Description_Txt_Special";
            this.IC_Description_Txt_Special.Size = new System.Drawing.Size(226, 86);
            this.IC_Description_Txt_Special.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Description";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(15, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(710, 60);
            this.panel3.TabIndex = 14;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::ERP.Properties.Resources.delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 175.1825F;
            this.dataGridViewImageColumn2.HeaderText = "Edit";
            this.dataGridViewImageColumn2.Image = global::ERP.Properties.Resources.edit;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // ItemCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 625);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Item Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox UnderICategory_Cmbx;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.TextBox IC_Description_Txt_Special;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox ItemCategoryNumber_Txt;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox ItemCategory_Txt_Special;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ItemCategoryNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_IC_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnderICategory;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn UpdateColumn;
    }
}