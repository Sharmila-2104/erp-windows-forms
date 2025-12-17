namespace ERP.Purchase.Vendor.Master
{
    partial class VendorGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VendorGroupNumber_Txt = new System.Windows.Forms.TextBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.UnderVGroup_Cmbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VendorGroup_Txt_Special = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VG_Description_Txt_Special = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.GV_VendorGroupNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_VendorGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_VG_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UnderVGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::ERP.Properties.Resources.delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn2.HeaderText = "Update";
            this.dataGridViewImageColumn2.Image = global::ERP.Properties.Resources.edit;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel1.Size = new System.Drawing.Size(1141, 526);
            this.panel1.TabIndex = 0;
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
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1111, 511);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VendorGroupNumber_Txt);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.UnderVGroup_Cmbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.VendorGroup_Txt_Special);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.VG_Description_Txt_Special);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(320, 481);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendor Group";
            // 
            // VendorGroupNumber_Txt
            // 
            this.VendorGroupNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VendorGroupNumber_Txt.Location = new System.Drawing.Point(115, 22);
            this.VendorGroupNumber_Txt.Margin = new System.Windows.Forms.Padding(5);
            this.VendorGroupNumber_Txt.Name = "VendorGroupNumber_Txt";
            this.VendorGroupNumber_Txt.Size = new System.Drawing.Size(185, 23);
            this.VendorGroupNumber_Txt.TabIndex = 44;
            this.VendorGroupNumber_Txt.Visible = false;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(218, 267);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(82, 35);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // UnderVGroup_Cmbx
            // 
            this.UnderVGroup_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderVGroup_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnderVGroup_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UnderVGroup_Cmbx.FormattingEnabled = true;
            this.UnderVGroup_Cmbx.Location = new System.Drawing.Point(115, 223);
            this.UnderVGroup_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.UnderVGroup_Cmbx.Name = "UnderVGroup_Cmbx";
            this.UnderVGroup_Cmbx.Size = new System.Drawing.Size(186, 24);
            this.UnderVGroup_Cmbx.TabIndex = 3;
            this.UnderVGroup_Cmbx.Tag = "UnderVGroup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Under";
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Location = new System.Drawing.Point(115, 267);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(85, 35);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Location = new System.Drawing.Point(115, 267);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(85, 35);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vendor Group";
            // 
            // VendorGroup_Txt_Special
            // 
            this.VendorGroup_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VendorGroup_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VendorGroup_Txt_Special.Location = new System.Drawing.Point(115, 60);
            this.VendorGroup_Txt_Special.Margin = new System.Windows.Forms.Padding(4);
            this.VendorGroup_Txt_Special.MaxLength = 30;
            this.VendorGroup_Txt_Special.Name = "VendorGroup_Txt_Special";
            this.VendorGroup_Txt_Special.Size = new System.Drawing.Size(186, 23);
            this.VendorGroup_Txt_Special.TabIndex = 1;
            this.VendorGroup_Txt_Special.Tag = "VendorGroup";
            this.VendorGroup_Txt_Special.Leave += new System.EventHandler(this.VendorGroup_Txt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description";
            // 
            // VG_Description_Txt_Special
            // 
            this.VG_Description_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VG_Description_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VG_Description_Txt_Special.Location = new System.Drawing.Point(115, 102);
            this.VG_Description_Txt_Special.Margin = new System.Windows.Forms.Padding(4);
            this.VG_Description_Txt_Special.MaxLength = 50;
            this.VG_Description_Txt_Special.Multiline = true;
            this.VG_Description_Txt_Special.Name = "VG_Description_Txt_Special";
            this.VG_Description_Txt_Special.Size = new System.Drawing.Size(186, 100);
            this.VG_Description_Txt_Special.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.GV_List);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(15, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(741, 451);
            this.panel2.TabIndex = 13;
            // 
            // GV_List
            // 
            this.GV_List.AllowUserToAddRows = false;
            this.GV_List.AllowUserToDeleteRows = false;
            this.GV_List.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.GV_List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GV_List.BackgroundColor = System.Drawing.Color.White;
            this.GV_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GV_List.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.GV_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GV_List.ColumnHeadersHeight = 35;
            this.GV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_VendorGroupNumber,
            this.GV_VendorGroup,
            this.GV_VG_Description,
            this.GV_UnderVGroup,
            this.DeleteColumn,
            this.UpdateColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GV_List.DefaultCellStyle = dataGridViewCellStyle3;
            this.GV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GV_List.Location = new System.Drawing.Point(15, 15);
            this.GV_List.Margin = new System.Windows.Forms.Padding(4);
            this.GV_List.Name = "GV_List";
            this.GV_List.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GV_List.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.GV_List.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GV_List.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.GV_List.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GV_List.RowTemplate.Height = 35;
            this.GV_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_List.Size = new System.Drawing.Size(711, 421);
            this.GV_List.StandardTab = true;
            this.GV_List.TabIndex = 0;
            this.GV_List.TabStop = false;
            this.GV_List.VirtualMode = true;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            this.GV_List.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GV_List_DataBindingComplete);
            // 
            // GV_VendorGroupNumber
            // 
            this.GV_VendorGroupNumber.DataPropertyName = "VendorGroupNumber";
            this.GV_VendorGroupNumber.HeaderText = "Number";
            this.GV_VendorGroupNumber.Name = "GV_VendorGroupNumber";
            this.GV_VendorGroupNumber.ReadOnly = true;
            this.GV_VendorGroupNumber.Visible = false;
            this.GV_VendorGroupNumber.Width = 92;
            // 
            // GV_VendorGroup
            // 
            this.GV_VendorGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_VendorGroup.DataPropertyName = "VendorGroup";
            this.GV_VendorGroup.HeaderText = "Vendor Group";
            this.GV_VendorGroup.Name = "GV_VendorGroup";
            this.GV_VendorGroup.ReadOnly = true;
            // 
            // GV_VG_Description
            // 
            this.GV_VG_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_VG_Description.DataPropertyName = "VG_Description";
            this.GV_VG_Description.HeaderText = "Description";
            this.GV_VG_Description.Name = "GV_VG_Description";
            this.GV_VG_Description.ReadOnly = true;
            // 
            // GV_UnderVGroup
            // 
            this.GV_UnderVGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_UnderVGroup.DataPropertyName = "UnderVGroup";
            this.GV_UnderVGroup.HeaderText = "Under";
            this.GV_UnderVGroup.Name = "GV_UnderVGroup";
            this.GV_UnderVGroup.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Image = global::ERP.Properties.Resources.delete;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteColumn.Width = 60;
            // 
            // UpdateColumn
            // 
            this.UpdateColumn.HeaderText = "Edit";
            this.UpdateColumn.Image = global::ERP.Properties.Resources.edit;
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.ReadOnly = true;
            this.UpdateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UpdateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UpdateColumn.Width = 60;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(15, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(741, 60);
            this.panel3.TabIndex = 14;
            // 
            // VendorGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1141, 526);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VendorGroup";
            this.Text = "Vendor Group";
            this.Load += new System.EventHandler(this.VendorGroup_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox VendorGroupNumber_Txt;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.ComboBox UnderVGroup_Cmbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VendorGroup_Txt_Special;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VG_Description_Txt_Special;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_VendorGroupNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_VendorGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_VG_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnderVGroup;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn UpdateColumn;
    }
}