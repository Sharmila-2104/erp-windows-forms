namespace ERP.Purchase.COA.Master
{
    partial class COA_LedgerGroup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnderLGroup_Cmbx = new System.Windows.Forms.ComboBox();
            this.GroupNature_Cmbx = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.LedgerGroup_Txt_Special = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LedgerGroupNumber_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.GV_LedgerGroupNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_LedgerGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UnderLGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_GroupNature = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel1.Size = new System.Drawing.Size(958, 487);
            this.panel1.TabIndex = 17;
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
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(928, 472);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.UnderLGroup_Cmbx);
            this.groupBox1.Controls.Add(this.GroupNature_Cmbx);
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.LedgerGroup_Txt_Special);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LedgerGroupNumber_Txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(320, 442);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COA Group";
            // 
            // UnderLGroup_Cmbx
            // 
            this.UnderLGroup_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderLGroup_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnderLGroup_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UnderLGroup_Cmbx.FormattingEnabled = true;
            this.UnderLGroup_Cmbx.Location = new System.Drawing.Point(134, 80);
            this.UnderLGroup_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.UnderLGroup_Cmbx.Name = "UnderLGroup_Cmbx";
            this.UnderLGroup_Cmbx.Size = new System.Drawing.Size(167, 24);
            this.UnderLGroup_Cmbx.TabIndex = 2;
            this.UnderLGroup_Cmbx.Tag = "UnderLGroup";
            // 
            // GroupNature_Cmbx
            // 
            this.GroupNature_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNature_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupNature_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupNature_Cmbx.FormattingEnabled = true;
            this.GroupNature_Cmbx.Location = new System.Drawing.Point(134, 112);
            this.GroupNature_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.GroupNature_Cmbx.Name = "GroupNature_Cmbx";
            this.GroupNature_Cmbx.Size = new System.Drawing.Size(167, 24);
            this.GroupNature_Cmbx.TabIndex = 3;
            this.GroupNature_Cmbx.Tag = "GroupNature";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(19, 115);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(114, 16);
            this.Category.TabIndex = 33;
            this.Category.Text = "Nature Of Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ledger Group";
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Location = new System.Drawing.Point(134, 151);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 35);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(217, 151);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 35);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // LedgerGroup_Txt_Special
            // 
            this.LedgerGroup_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LedgerGroup_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LedgerGroup_Txt_Special.Location = new System.Drawing.Point(134, 47);
            this.LedgerGroup_Txt_Special.Margin = new System.Windows.Forms.Padding(4);
            this.LedgerGroup_Txt_Special.MaxLength = 50;
            this.LedgerGroup_Txt_Special.Name = "LedgerGroup_Txt_Special";
            this.LedgerGroup_Txt_Special.Size = new System.Drawing.Size(167, 23);
            this.LedgerGroup_Txt_Special.TabIndex = 1;
            this.LedgerGroup_Txt_Special.Tag = "LedgerGroup";
            this.LedgerGroup_Txt_Special.Leave += new System.EventHandler(this.LedgerGroup_Txt_Special_Leave);
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Location = new System.Drawing.Point(134, 151);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 35);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Under";
            // 
            // LedgerGroupNumber_Txt
            // 
            this.LedgerGroupNumber_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LedgerGroupNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LedgerGroupNumber_Txt.Location = new System.Drawing.Point(134, 17);
            this.LedgerGroupNumber_Txt.Margin = new System.Windows.Forms.Padding(5);
            this.LedgerGroupNumber_Txt.Name = "LedgerGroupNumber_Txt";
            this.LedgerGroupNumber_Txt.Size = new System.Drawing.Size(167, 23);
            this.LedgerGroupNumber_Txt.TabIndex = 32500;
            this.LedgerGroupNumber_Txt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(558, 412);
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_LedgerGroupNumber,
            this.GV_LedgerGroup,
            this.GV_UnderLGroup,
            this.GV_GroupNature,
            this.DeleteColumn,
            this.UpdateColumn});
            this.GV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_List.Location = new System.Drawing.Point(15, 15);
            this.GV_List.Margin = new System.Windows.Forms.Padding(4);
            this.GV_List.Name = "GV_List";
            this.GV_List.ReadOnly = true;
            this.GV_List.RowTemplate.Height = 25;
            this.GV_List.Size = new System.Drawing.Size(528, 382);
            this.GV_List.TabIndex = 22;
            this.GV_List.TabStop = false;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            // 
            // GV_LedgerGroupNumber
            // 
            this.GV_LedgerGroupNumber.DataPropertyName = "LedgerGroupNumber";
            this.GV_LedgerGroupNumber.HeaderText = "Number";
            this.GV_LedgerGroupNumber.Name = "GV_LedgerGroupNumber";
            this.GV_LedgerGroupNumber.ReadOnly = true;
            this.GV_LedgerGroupNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GV_LedgerGroupNumber.Visible = false;
            // 
            // GV_LedgerGroup
            // 
            this.GV_LedgerGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_LedgerGroup.DataPropertyName = "LedgerGroup";
            this.GV_LedgerGroup.HeaderText = "Ledger Group";
            this.GV_LedgerGroup.Name = "GV_LedgerGroup";
            this.GV_LedgerGroup.ReadOnly = true;
            this.GV_LedgerGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GV_UnderLGroup
            // 
            this.GV_UnderLGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_UnderLGroup.DataPropertyName = "UnderLGroup";
            this.GV_UnderLGroup.HeaderText = "Under";
            this.GV_UnderLGroup.Name = "GV_UnderLGroup";
            this.GV_UnderLGroup.ReadOnly = true;
            this.GV_UnderLGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GV_GroupNature
            // 
            this.GV_GroupNature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_GroupNature.DataPropertyName = "GroupNature";
            this.GV_GroupNature.HeaderText = "Nature Of Group";
            this.GV_GroupNature.Name = "GV_GroupNature";
            this.GV_GroupNature.ReadOnly = true;
            this.GV_GroupNature.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.panel2.Size = new System.Drawing.Size(558, 60);
            this.panel2.TabIndex = 10;
            // 
            // COA_LedgerGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(958, 487);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "COA_LedgerGroup";
            this.Text = "COA Group";
            this.Load += new System.EventHandler(this.COAGroup_Load);
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
        private System.Windows.Forms.TextBox LedgerGroupNumber_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.ComboBox UnderLGroup_Cmbx;
        private System.Windows.Forms.ComboBox GroupNature_Cmbx;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.TextBox LedgerGroup_Txt_Special;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_LedgerGroupNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_LedgerGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UnderLGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_GroupNature;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn UpdateColumn;
    }
}