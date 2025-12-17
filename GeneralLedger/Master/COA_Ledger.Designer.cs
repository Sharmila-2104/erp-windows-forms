namespace ERP.Purchase.COA.Master
{
    partial class COA_Ledger
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
            this.GroupNature_Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LedgerGroup_Cmbx = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.LedgerAccount_Txt_Special = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.LedgerName_Txt_Special = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LedgerNumber_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.GV_LedgerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_LedgerAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_LedgerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_LedgerGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_GroupNature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.panel1.Size = new System.Drawing.Size(1370, 636);
            this.panel1.TabIndex = 16;
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
            this.splitContainer1.Size = new System.Drawing.Size(1340, 621);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GroupNature_Txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LedgerGroup_Cmbx);
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.LedgerAccount_Txt_Special);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.LedgerName_Txt_Special);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LedgerNumber_Txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(320, 591);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COA Ledger";
            // 
            // GroupNature_Txt
            // 
            this.GroupNature_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNature_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupNature_Txt.Location = new System.Drawing.Point(140, 186);
            this.GroupNature_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.GroupNature_Txt.Name = "GroupNature_Txt";
            this.GroupNature_Txt.ReadOnly = true;
            this.GroupNature_Txt.Size = new System.Drawing.Size(158, 23);
            this.GroupNature_Txt.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nature Of Group";
            // 
            // LedgerGroup_Cmbx
            // 
            this.LedgerGroup_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LedgerGroup_Cmbx.FormattingEnabled = true;
            this.LedgerGroup_Cmbx.Location = new System.Drawing.Point(140, 143);
            this.LedgerGroup_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.LedgerGroup_Cmbx.Name = "LedgerGroup_Cmbx";
            this.LedgerGroup_Cmbx.Size = new System.Drawing.Size(158, 24);
            this.LedgerGroup_Cmbx.TabIndex = 3;
            this.LedgerGroup_Cmbx.Tag = "LedgerGroup";
            this.LedgerGroup_Cmbx.SelectionChangeCommitted += new System.EventHandler(this.DDL_LedgerGroup_SelectionChangeCommitted);
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(39, 146);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(94, 16);
            this.Category.TabIndex = 37;
            this.Category.Text = "Ledger Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ledger Account";
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Location = new System.Drawing.Point(140, 227);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(85, 34);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(227, 227);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(85, 34);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // LedgerAccount_Txt_Special
            // 
            this.LedgerAccount_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LedgerAccount_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LedgerAccount_Txt_Special.Location = new System.Drawing.Point(140, 61);
            this.LedgerAccount_Txt_Special.Margin = new System.Windows.Forms.Padding(4);
            this.LedgerAccount_Txt_Special.MaxLength = 6;
            this.LedgerAccount_Txt_Special.Name = "LedgerAccount_Txt_Special";
            this.LedgerAccount_Txt_Special.Size = new System.Drawing.Size(158, 23);
            this.LedgerAccount_Txt_Special.TabIndex = 1;
            this.LedgerAccount_Txt_Special.Tag = "LedgerAccount";
            this.LedgerAccount_Txt_Special.Leave += new System.EventHandler(this.LedgerAccount_Txt_Special_Leave);
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Location = new System.Drawing.Point(140, 227);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(85, 34);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // LedgerName_Txt_Special
            // 
            this.LedgerName_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LedgerName_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LedgerName_Txt_Special.Location = new System.Drawing.Point(140, 102);
            this.LedgerName_Txt_Special.Margin = new System.Windows.Forms.Padding(4);
            this.LedgerName_Txt_Special.MaxLength = 50;
            this.LedgerName_Txt_Special.Name = "LedgerName_Txt_Special";
            this.LedgerName_Txt_Special.Size = new System.Drawing.Size(158, 23);
            this.LedgerName_Txt_Special.TabIndex = 2;
            this.LedgerName_Txt_Special.Tag = "LedgerName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ledger Name";
            // 
            // LedgerNumber_Txt
            // 
            this.LedgerNumber_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LedgerNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LedgerNumber_Txt.Location = new System.Drawing.Point(140, 31);
            this.LedgerNumber_Txt.Margin = new System.Windows.Forms.Padding(5);
            this.LedgerNumber_Txt.Name = "LedgerNumber_Txt";
            this.LedgerNumber_Txt.Size = new System.Drawing.Size(158, 23);
            this.LedgerNumber_Txt.TabIndex = 25;
            this.LedgerNumber_Txt.Visible = false;
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
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.GV_List);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(15, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(970, 561);
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
            this.GV_LedgerNumber,
            this.GV_LedgerAccount,
            this.GV_LedgerName,
            this.GV_LedgerGroup,
            this.GV_GroupNature,
            this.DeleteColumn,
            this.EditColumn});
            this.GV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_List.Location = new System.Drawing.Point(15, 15);
            this.GV_List.Margin = new System.Windows.Forms.Padding(4);
            this.GV_List.Name = "GV_List";
            this.GV_List.ReadOnly = true;
            this.GV_List.RowTemplate.Height = 25;
            this.GV_List.Size = new System.Drawing.Size(940, 531);
            this.GV_List.TabIndex = 17;
            this.GV_List.TabStop = false;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            // 
            // GV_LedgerNumber
            // 
            this.GV_LedgerNumber.DataPropertyName = "LedgerNumber";
            this.GV_LedgerNumber.HeaderText = "Number";
            this.GV_LedgerNumber.Name = "GV_LedgerNumber";
            this.GV_LedgerNumber.ReadOnly = true;
            this.GV_LedgerNumber.Visible = false;
            // 
            // GV_LedgerAccount
            // 
            this.GV_LedgerAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_LedgerAccount.DataPropertyName = "LedgerAccount";
            this.GV_LedgerAccount.FillWeight = 39.90535F;
            this.GV_LedgerAccount.HeaderText = "Ledger Account";
            this.GV_LedgerAccount.Name = "GV_LedgerAccount";
            this.GV_LedgerAccount.ReadOnly = true;
            // 
            // GV_LedgerName
            // 
            this.GV_LedgerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_LedgerName.DataPropertyName = "LedgerName";
            this.GV_LedgerName.FillWeight = 39.90535F;
            this.GV_LedgerName.HeaderText = "Ledger Name";
            this.GV_LedgerName.Name = "GV_LedgerName";
            this.GV_LedgerName.ReadOnly = true;
            // 
            // GV_LedgerGroup
            // 
            this.GV_LedgerGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_LedgerGroup.DataPropertyName = "LedgerGroup";
            this.GV_LedgerGroup.FillWeight = 39.90535F;
            this.GV_LedgerGroup.HeaderText = "Ledger Group ";
            this.GV_LedgerGroup.Name = "GV_LedgerGroup";
            this.GV_LedgerGroup.ReadOnly = true;
            // 
            // GV_GroupNature
            // 
            this.GV_GroupNature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_GroupNature.DataPropertyName = "GroupNature";
            this.GV_GroupNature.FillWeight = 39.90535F;
            this.GV_GroupNature.HeaderText = "Nature Of Group";
            this.GV_GroupNature.Name = "GV_GroupNature";
            this.GV_GroupNature.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.FillWeight = 108.3189F;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Image = global::ERP.Properties.Resources.delete;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteColumn.Width = 60;
            // 
            // EditColumn
            // 
            this.EditColumn.FillWeight = 87.7068F;
            this.EditColumn.HeaderText = "Edit";
            this.EditColumn.Image = global::ERP.Properties.Resources.edit;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditColumn.Width = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(15, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(970, 60);
            this.panel2.TabIndex = 10;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::ERP.Properties.Resources.delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Edit";
            this.dataGridViewImageColumn2.Image = global::ERP.Properties.Resources.edit;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // COA_Ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 636);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "COA_Ledger";
            this.Text = "COA Ledger";
            this.Load += new System.EventHandler(this.COALedger_Load);
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
        private System.Windows.Forms.TextBox LedgerNumber_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.TextBox GroupNature_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LedgerGroup_Cmbx;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.TextBox LedgerAccount_Txt_Special;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox LedgerName_Txt_Special;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_LedgerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_LedgerAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_LedgerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_LedgerGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_GroupNature;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
    }
}