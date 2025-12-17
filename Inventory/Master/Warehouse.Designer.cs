namespace ERP.Purchase.Item.Master
{
    partial class Warehouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.WarehouseCode_Txt_Special = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WarehouseCategory_Cmbx = new System.Windows.Forms.ComboBox();
            this.WarehouseGroup_Cmbx = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.WarehouseDescription_Txt_Special = new System.Windows.Forms.TextBox();
            this.WarehouseNumber_Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.GV_WarehouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_WarehouseCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_WarehouseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_WarehouseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_WarehouseGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel1.Size = new System.Drawing.Size(1312, 558);
            this.panel1.TabIndex = 24;
            // 
            // splitContainer1
            // 
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
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1282, 543);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.WarehouseCode_Txt_Special);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.WarehouseCategory_Cmbx);
            this.groupBox1.Controls.Add(this.WarehouseGroup_Cmbx);
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.WarehouseDescription_Txt_Special);
            this.groupBox1.Controls.Add(this.WarehouseNumber_Txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(320, 513);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warehouse";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Description";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Location = new System.Drawing.Point(105, 295);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(73, 31);
            this.Btn_Save.TabIndex = 5;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // WarehouseCode_Txt_Special
            // 
            this.WarehouseCode_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarehouseCode_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WarehouseCode_Txt_Special.Location = new System.Drawing.Point(105, 108);
            this.WarehouseCode_Txt_Special.Margin = new System.Windows.Forms.Padding(4);
            this.WarehouseCode_Txt_Special.MaxLength = 25;
            this.WarehouseCode_Txt_Special.Name = "WarehouseCode_Txt_Special";
            this.WarehouseCode_Txt_Special.Size = new System.Drawing.Size(196, 23);
            this.WarehouseCode_Txt_Special.TabIndex = 2;
            this.WarehouseCode_Txt_Special.Tag = "WarehouseCode";
            this.WarehouseCode_Txt_Special.Leave += new System.EventHandler(this.WarehouseCode_Txt_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(87, 34);
            this.label3.TabIndex = 35;
            this.label3.Text = "Warehouse Code";
            // 
            // WarehouseCategory_Cmbx
            // 
            this.WarehouseCategory_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarehouseCategory_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WarehouseCategory_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WarehouseCategory_Cmbx.FormattingEnabled = true;
            this.WarehouseCategory_Cmbx.Location = new System.Drawing.Point(105, 64);
            this.WarehouseCategory_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.WarehouseCategory_Cmbx.Name = "WarehouseCategory_Cmbx";
            this.WarehouseCategory_Cmbx.Size = new System.Drawing.Size(196, 24);
            this.WarehouseCategory_Cmbx.TabIndex = 1;
            this.WarehouseCategory_Cmbx.Tag = "WarehouseCategory";
            // 
            // WarehouseGroup_Cmbx
            // 
            this.WarehouseGroup_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarehouseGroup_Cmbx.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WarehouseGroup_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WarehouseGroup_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WarehouseGroup_Cmbx.FormattingEnabled = true;
            this.WarehouseGroup_Cmbx.Location = new System.Drawing.Point(105, 254);
            this.WarehouseGroup_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.WarehouseGroup_Cmbx.Name = "WarehouseGroup_Cmbx";
            this.WarehouseGroup_Cmbx.Size = new System.Drawing.Size(196, 24);
            this.WarehouseGroup_Cmbx.TabIndex = 4;
            this.WarehouseGroup_Cmbx.Tag = "WarehouseGroup";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(42, 257);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(45, 16);
            this.Category.TabIndex = 32;
            this.Category.Text = "Under";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(198, 295);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(73, 31);
            this.Btn_Clear.TabIndex = 7;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Location = new System.Drawing.Point(105, 295);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(73, 31);
            this.Btn_Update.TabIndex = 6;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // WarehouseDescription_Txt_Special
            // 
            this.WarehouseDescription_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarehouseDescription_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WarehouseDescription_Txt_Special.Location = new System.Drawing.Point(105, 144);
            this.WarehouseDescription_Txt_Special.Margin = new System.Windows.Forms.Padding(4);
            this.WarehouseDescription_Txt_Special.MaxLength = 50;
            this.WarehouseDescription_Txt_Special.Multiline = true;
            this.WarehouseDescription_Txt_Special.Name = "WarehouseDescription_Txt_Special";
            this.WarehouseDescription_Txt_Special.Size = new System.Drawing.Size(196, 87);
            this.WarehouseDescription_Txt_Special.TabIndex = 3;
            this.WarehouseDescription_Txt_Special.Tag = "WarehouseDescription";
            // 
            // WarehouseNumber_Txt
            // 
            this.WarehouseNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WarehouseNumber_Txt.Location = new System.Drawing.Point(105, 20);
            this.WarehouseNumber_Txt.Margin = new System.Windows.Forms.Padding(5);
            this.WarehouseNumber_Txt.Name = "WarehouseNumber_Txt";
            this.WarehouseNumber_Txt.Size = new System.Drawing.Size(195, 23);
            this.WarehouseNumber_Txt.TabIndex = 25;
            this.WarehouseNumber_Txt.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.GV_List);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(15, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(912, 483);
            this.panel3.TabIndex = 11;
            // 
            // GV_List
            // 
            this.GV_List.AllowUserToAddRows = false;
            this.GV_List.AllowUserToDeleteRows = false;
            this.GV_List.AllowUserToOrderColumns = true;
            this.GV_List.BackgroundColor = System.Drawing.Color.White;
            this.GV_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_WarehouseNumber,
            this.GV_WarehouseCategory,
            this.GV_WarehouseCode,
            this.GV_WarehouseDescription,
            this.GV_WarehouseGroup,
            this.DeleteColumn,
            this.UpdateColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GV_List.DefaultCellStyle = dataGridViewCellStyle5;
            this.GV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_List.GridColor = System.Drawing.Color.White;
            this.GV_List.Location = new System.Drawing.Point(15, 15);
            this.GV_List.Margin = new System.Windows.Forms.Padding(4);
            this.GV_List.Name = "GV_List";
            this.GV_List.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GV_List.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.GV_List.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.GV_List.RowTemplate.Height = 25;
            this.GV_List.Size = new System.Drawing.Size(882, 453);
            this.GV_List.TabIndex = 20;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            // 
            // GV_WarehouseNumber
            // 
            this.GV_WarehouseNumber.DataPropertyName = "WarehouseNumber";
            this.GV_WarehouseNumber.HeaderText = "Number";
            this.GV_WarehouseNumber.Name = "GV_WarehouseNumber";
            this.GV_WarehouseNumber.ReadOnly = true;
            this.GV_WarehouseNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GV_WarehouseNumber.Visible = false;
            this.GV_WarehouseNumber.Width = 5;
            // 
            // GV_WarehouseCategory
            // 
            this.GV_WarehouseCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_WarehouseCategory.DataPropertyName = "WarehouseCategory";
            this.GV_WarehouseCategory.HeaderText = "Category";
            this.GV_WarehouseCategory.Name = "GV_WarehouseCategory";
            this.GV_WarehouseCategory.ReadOnly = true;
            this.GV_WarehouseCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GV_WarehouseCode
            // 
            this.GV_WarehouseCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_WarehouseCode.DataPropertyName = "WarehouseCode";
            this.GV_WarehouseCode.HeaderText = "Warehouse Code";
            this.GV_WarehouseCode.Name = "GV_WarehouseCode";
            this.GV_WarehouseCode.ReadOnly = true;
            this.GV_WarehouseCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GV_WarehouseDescription
            // 
            this.GV_WarehouseDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_WarehouseDescription.DataPropertyName = "WarehouseDescription";
            this.GV_WarehouseDescription.HeaderText = "Description";
            this.GV_WarehouseDescription.Name = "GV_WarehouseDescription";
            this.GV_WarehouseDescription.ReadOnly = true;
            this.GV_WarehouseDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GV_WarehouseGroup
            // 
            this.GV_WarehouseGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_WarehouseGroup.DataPropertyName = "WarehouseGroup";
            this.GV_WarehouseGroup.HeaderText = "Under";
            this.GV_WarehouseGroup.Name = "GV_WarehouseGroup";
            this.GV_WarehouseGroup.ReadOnly = true;
            this.GV_WarehouseGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(15, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(912, 60);
            this.panel2.TabIndex = 10;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 558);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
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
        private System.Windows.Forms.TextBox WarehouseNumber_Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.TextBox WarehouseCode_Txt_Special;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox WarehouseGroup_Cmbx;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox WarehouseDescription_Txt_Special;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox WarehouseCategory_Cmbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_WarehouseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_WarehouseCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_WarehouseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_WarehouseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_WarehouseGroup;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn UpdateColumn;
    }
}