namespace ERP.Purchase.Item.Master
{
    partial class ItemSubCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Category = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UnderISubCategory_Cmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.ItemSubCategory_Txt_Special = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.ISC_Description_Txt_Special = new System.Windows.Forms.TextBox();
            this.ItemSubCategoryNumber_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GV_ItemSubCategoryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_ItemSubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_ISC_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UnderISubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel1.Size = new System.Drawing.Size(1057, 497);
            this.panel1.TabIndex = 17;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(15, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1027, 482);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UnderISubCategory_Cmbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.ItemSubCategory_Txt_Special);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.ISC_Description_Txt_Special);
            this.groupBox1.Controls.Add(this.ItemSubCategoryNumber_Txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(320, 452);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Subcategory";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(55, 202);
            this.Category.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(45, 16);
            this.Category.TabIndex = 34;
            this.Category.Text = "Under";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Description";
            // 
            // UnderISubCategory_Cmbx
            // 
            this.UnderISubCategory_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderISubCategory_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnderISubCategory_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UnderISubCategory_Cmbx.FormattingEnabled = true;
            this.UnderISubCategory_Cmbx.Location = new System.Drawing.Point(113, 199);
            this.UnderISubCategory_Cmbx.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UnderISubCategory_Cmbx.Name = "UnderISubCategory_Cmbx";
            this.UnderISubCategory_Cmbx.Size = new System.Drawing.Size(192, 24);
            this.UnderISubCategory_Cmbx.TabIndex = 3;
            this.UnderISubCategory_Cmbx.Tag = "UnderISubCategory";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(95, 34);
            this.label2.TabIndex = 26;
            this.label2.Text = "Item Subcategory";
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Location = new System.Drawing.Point(113, 243);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(73, 31);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(208, 243);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(73, 31);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // ItemSubCategory_Txt_Special
            // 
            this.ItemSubCategory_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemSubCategory_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemSubCategory_Txt_Special.Location = new System.Drawing.Point(113, 57);
            this.ItemSubCategory_Txt_Special.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ItemSubCategory_Txt_Special.MaxLength = 30;
            this.ItemSubCategory_Txt_Special.Name = "ItemSubCategory_Txt_Special";
            this.ItemSubCategory_Txt_Special.Size = new System.Drawing.Size(192, 23);
            this.ItemSubCategory_Txt_Special.TabIndex = 1;
            this.ItemSubCategory_Txt_Special.Tag = "ItemSubCategory";
            this.ItemSubCategory_Txt_Special.Leave += new System.EventHandler(this.ItemSubCategory_Txt_Leave);
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Location = new System.Drawing.Point(113, 243);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(73, 31);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // ISC_Description_Txt_Special
            // 
            this.ISC_Description_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ISC_Description_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ISC_Description_Txt_Special.Location = new System.Drawing.Point(113, 96);
            this.ISC_Description_Txt_Special.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ISC_Description_Txt_Special.MaxLength = 50;
            this.ISC_Description_Txt_Special.Multiline = true;
            this.ISC_Description_Txt_Special.Name = "ISC_Description_Txt_Special";
            this.ISC_Description_Txt_Special.Size = new System.Drawing.Size(192, 87);
            this.ISC_Description_Txt_Special.TabIndex = 2;
            this.ISC_Description_Txt_Special.Tag = "";
            // 
            // ItemSubCategoryNumber_Txt
            // 
            this.ItemSubCategoryNumber_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemSubCategoryNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemSubCategoryNumber_Txt.Location = new System.Drawing.Point(113, 22);
            this.ItemSubCategoryNumber_Txt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ItemSubCategoryNumber_Txt.Name = "ItemSubCategoryNumber_Txt";
            this.ItemSubCategoryNumber_Txt.Size = new System.Drawing.Size(192, 23);
            this.ItemSubCategoryNumber_Txt.TabIndex = 25;
            this.ItemSubCategoryNumber_Txt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.GV_List);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(15, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(656, 422);
            this.panel3.TabIndex = 11;
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_ItemSubCategoryNumber,
            this.GV_ItemSubCategory,
            this.GV_ISC_Description,
            this.GV_UnderISubCategory,
            this.DeleteColumn,
            this.UpdateColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GV_List.DefaultCellStyle = dataGridViewCellStyle2;
            this.GV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_List.Location = new System.Drawing.Point(15, 15);
            this.GV_List.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GV_List.Name = "GV_List";
            this.GV_List.ReadOnly = true;
            this.GV_List.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.GV_List.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.GV_List.RowTemplate.Height = 25;
            this.GV_List.Size = new System.Drawing.Size(626, 392);
            this.GV_List.TabIndex = 17;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(15, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(656, 60);
            this.panel2.TabIndex = 10;
            // 
            // GV_ItemSubCategoryNumber
            // 
            this.GV_ItemSubCategoryNumber.DataPropertyName = "ItemSubCategoryNumber";
            this.GV_ItemSubCategoryNumber.HeaderText = "Number";
            this.GV_ItemSubCategoryNumber.Name = "GV_ItemSubCategoryNumber";
            this.GV_ItemSubCategoryNumber.ReadOnly = true;
            this.GV_ItemSubCategoryNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GV_ItemSubCategoryNumber.Visible = false;
            // 
            // GV_ItemSubCategory
            // 
            this.GV_ItemSubCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_ItemSubCategory.DataPropertyName = "ItemSubCategory";
            this.GV_ItemSubCategory.FillWeight = 49.22903F;
            this.GV_ItemSubCategory.HeaderText = "Item Subcategory";
            this.GV_ItemSubCategory.Name = "GV_ItemSubCategory";
            this.GV_ItemSubCategory.ReadOnly = true;
            this.GV_ItemSubCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GV_ISC_Description
            // 
            this.GV_ISC_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_ISC_Description.DataPropertyName = "ISC_Description";
            this.GV_ISC_Description.FillWeight = 49.22903F;
            this.GV_ISC_Description.HeaderText = "Description";
            this.GV_ISC_Description.Name = "GV_ISC_Description";
            this.GV_ISC_Description.ReadOnly = true;
            this.GV_ISC_Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GV_UnderISubCategory
            // 
            this.GV_UnderISubCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_UnderISubCategory.DataPropertyName = "UnderISubCategory";
            this.GV_UnderISubCategory.FillWeight = 49.22903F;
            this.GV_UnderISubCategory.HeaderText = "Under";
            this.GV_UnderISubCategory.Name = "GV_UnderISubCategory";
            this.GV_UnderISubCategory.ReadOnly = true;
            this.GV_UnderISubCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.FillWeight = 174.6479F;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Image = global::ERP.Properties.Resources.delete;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteColumn.Width = 60;
            // 
            // UpdateColumn
            // 
            this.UpdateColumn.FillWeight = 177.665F;
            this.UpdateColumn.HeaderText = "Edit";
            this.UpdateColumn.Image = global::ERP.Properties.Resources.edit;
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.ReadOnly = true;
            this.UpdateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UpdateColumn.Width = 60;
            // 
            // ItemSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 497);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ItemSubCategory";
            this.Text = "Item Subcategory";
            this.Load += new System.EventHandler(this.ItemSubCategory_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ItemSubCategoryNumber_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.ComboBox UnderISubCategory_Cmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.TextBox ItemSubCategory_Txt_Special;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox ISC_Description_Txt_Special;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ItemSubCategoryNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ItemSubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ISC_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnderISubCategory;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn UpdateColumn;
    }
}