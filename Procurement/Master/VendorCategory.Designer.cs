namespace ERP.Purchase.Vendor.Master
{
    partial class VendorCategory
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
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.GV_VendorCategoryNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_VendorCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_VC_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UnderVCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VendorCategoryNumber_Txt = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.UnderVCategory_Cmbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VendorCategory_Txt_Special = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VC_Description_Txt_Special = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_VendorCategoryNumber,
            this.GV_VendorCategory,
            this.GV_VC_Description,
            this.GV_UnderVCategory,
            this.DeleteColumn,
            this.UpdateColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GV_List.DefaultCellStyle = dataGridViewCellStyle2;
            this.GV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_List.Location = new System.Drawing.Point(15, 15);
            this.GV_List.Margin = new System.Windows.Forms.Padding(4);
            this.GV_List.Name = "GV_List";
            this.GV_List.ReadOnly = true;
            this.GV_List.RowTemplate.Height = 25;
            this.GV_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_List.Size = new System.Drawing.Size(685, 434);
            this.GV_List.TabIndex = 13;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            // 
            // GV_VendorCategoryNumber
            // 
            this.GV_VendorCategoryNumber.DataPropertyName = "VendorCategoryNumber";
            this.GV_VendorCategoryNumber.HeaderText = "Number";
            this.GV_VendorCategoryNumber.Name = "GV_VendorCategoryNumber";
            this.GV_VendorCategoryNumber.ReadOnly = true;
            this.GV_VendorCategoryNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GV_VendorCategoryNumber.Visible = false;
            // 
            // GV_VendorCategory
            // 
            this.GV_VendorCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_VendorCategory.DataPropertyName = "VendorCategory";
            this.GV_VendorCategory.HeaderText = "Vendor Category";
            this.GV_VendorCategory.Name = "GV_VendorCategory";
            this.GV_VendorCategory.ReadOnly = true;
            this.GV_VendorCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GV_VC_Description
            // 
            this.GV_VC_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_VC_Description.DataPropertyName = "VC_Description";
            this.GV_VC_Description.HeaderText = "Description";
            this.GV_VC_Description.Name = "GV_VC_Description";
            this.GV_VC_Description.ReadOnly = true;
            this.GV_VC_Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GV_UnderVCategory
            // 
            this.GV_UnderVCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_UnderVCategory.DataPropertyName = "UnderVCategory";
            this.GV_UnderVCategory.HeaderText = "Under";
            this.GV_UnderVCategory.Name = "GV_UnderVCategory";
            this.GV_UnderVCategory.ReadOnly = true;
            this.GV_UnderVCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.UpdateColumn.HeaderText = "Edit";
            this.UpdateColumn.Image = global::ERP.Properties.Resources.edit;
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.ReadOnly = true;
            this.UpdateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.panel1.Size = new System.Drawing.Size(715, 464);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(15, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(715, 60);
            this.panel2.TabIndex = 15;
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
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1085, 524);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VendorCategoryNumber_Txt);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.UnderVCategory_Cmbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.VendorCategory_Txt_Special);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.VC_Description_Txt_Special);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(320, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendor Category";
            // 
            // VendorCategoryNumber_Txt
            // 
            this.VendorCategoryNumber_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VendorCategoryNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VendorCategoryNumber_Txt.Location = new System.Drawing.Point(136, 35);
            this.VendorCategoryNumber_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.VendorCategoryNumber_Txt.MaxLength = 32875;
            this.VendorCategoryNumber_Txt.Name = "VendorCategoryNumber_Txt";
            this.VendorCategoryNumber_Txt.Size = new System.Drawing.Size(165, 23);
            this.VendorCategoryNumber_Txt.TabIndex = 0;
            this.VendorCategoryNumber_Txt.Tag = "";
            this.VendorCategoryNumber_Txt.Visible = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Location = new System.Drawing.Point(134, 270);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(78, 28);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(220, 270);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(80, 28);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // UnderVCategory_Cmbx
            // 
            this.UnderVCategory_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderVCategory_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnderVCategory_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UnderVCategory_Cmbx.FormattingEnabled = true;
            this.UnderVCategory_Cmbx.Location = new System.Drawing.Point(136, 226);
            this.UnderVCategory_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.UnderVCategory_Cmbx.Name = "UnderVCategory_Cmbx";
            this.UnderVCategory_Cmbx.Size = new System.Drawing.Size(165, 24);
            this.UnderVCategory_Cmbx.TabIndex = 3;
            this.UnderVCategory_Cmbx.Tag = "UnderVCategory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Under";
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Location = new System.Drawing.Point(134, 270);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(78, 28);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Vendor Category";
            // 
            // VendorCategory_Txt_Special
            // 
            this.VendorCategory_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VendorCategory_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VendorCategory_Txt_Special.Location = new System.Drawing.Point(136, 67);
            this.VendorCategory_Txt_Special.Margin = new System.Windows.Forms.Padding(4);
            this.VendorCategory_Txt_Special.MaxLength = 30;
            this.VendorCategory_Txt_Special.Name = "VendorCategory_Txt_Special";
            this.VendorCategory_Txt_Special.Size = new System.Drawing.Size(165, 23);
            this.VendorCategory_Txt_Special.TabIndex = 1;
            this.VendorCategory_Txt_Special.Tag = "VendorCategory";
            this.VendorCategory_Txt_Special.Leave += new System.EventHandler(this.VendorCategory_Txt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Description";
            // 
            // VC_Description_Txt_Special
            // 
            this.VC_Description_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VC_Description_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VC_Description_Txt_Special.Location = new System.Drawing.Point(136, 107);
            this.VC_Description_Txt_Special.Margin = new System.Windows.Forms.Padding(4);
            this.VC_Description_Txt_Special.MaxLength = 50;
            this.VC_Description_Txt_Special.Multiline = true;
            this.VC_Description_Txt_Special.Name = "VC_Description_Txt_Special";
            this.VC_Description_Txt_Special.Size = new System.Drawing.Size(165, 100);
            this.VC_Description_Txt_Special.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel3.Size = new System.Drawing.Size(1115, 539);
            this.panel3.TabIndex = 17;
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
            this.dataGridViewImageColumn2.HeaderText = "Edit";
            this.dataGridViewImageColumn2.Image = global::ERP.Properties.Resources.edit;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // VendorCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 539);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VendorCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vendor Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VendorCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.ComboBox UnderVCategory_Cmbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VendorCategory_Txt_Special;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VC_Description_Txt_Special;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox VendorCategoryNumber_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_VendorCategoryNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_VendorCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_VC_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnderVCategory;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn UpdateColumn;
    }
}