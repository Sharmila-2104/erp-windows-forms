namespace ERP.Purchase.Item.Master
{
    partial class ExpenseCode
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
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.LedgerName_Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LedgerAccount_Cmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpenseCode_Txt_Special = new System.Windows.Forms.TextBox();
            this.EC_Description_Txt_Special = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExpenseCodeNumber_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.GV_ExpenseCodeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_ExpenseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_EC_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LedgerAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LedgerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel1.Size = new System.Drawing.Size(1141, 578);
            this.panel1.TabIndex = 18;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(15, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(1111, 563);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.LedgerName_Txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LedgerAccount_Cmbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ExpenseCode_Txt_Special);
            this.groupBox1.Controls.Add(this.EC_Description_Txt_Special);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ExpenseCodeNumber_Txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(320, 533);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expense Code";
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Location = new System.Drawing.Point(115, 266);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(65, 31);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Location = new System.Drawing.Point(115, 266);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(65, 31);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(207, 266);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(73, 31);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // LedgerName_Txt
            // 
            this.LedgerName_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LedgerName_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LedgerName_Txt.Location = new System.Drawing.Point(115, 226);
            this.LedgerName_Txt.MaxLength = 50;
            this.LedgerName_Txt.Name = "LedgerName_Txt";
            this.LedgerName_Txt.ReadOnly = true;
            this.LedgerName_Txt.Size = new System.Drawing.Size(190, 23);
            this.LedgerName_Txt.TabIndex = 0;
            this.LedgerName_Txt.Tag = "";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 40);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ledger Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 38);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ledger Account";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LedgerAccount_Cmbx
            // 
            this.LedgerAccount_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LedgerAccount_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LedgerAccount_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LedgerAccount_Cmbx.FormattingEnabled = true;
            this.LedgerAccount_Cmbx.Location = new System.Drawing.Point(115, 183);
            this.LedgerAccount_Cmbx.Name = "LedgerAccount_Cmbx";
            this.LedgerAccount_Cmbx.Size = new System.Drawing.Size(190, 24);
            this.LedgerAccount_Cmbx.TabIndex = 3;
            this.LedgerAccount_Cmbx.Tag = "LedgerAccount";
            this.LedgerAccount_Cmbx.SelectionChangeCommitted += new System.EventHandler(this.DDL_AccountNumber_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 41);
            this.label2.TabIndex = 30;
            this.label2.Text = "Expense Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ExpenseCode_Txt_Special
            // 
            this.ExpenseCode_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpenseCode_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpenseCode_Txt_Special.Location = new System.Drawing.Point(115, 53);
            this.ExpenseCode_Txt_Special.MaxLength = 30;
            this.ExpenseCode_Txt_Special.Name = "ExpenseCode_Txt_Special";
            this.ExpenseCode_Txt_Special.Size = new System.Drawing.Size(190, 23);
            this.ExpenseCode_Txt_Special.TabIndex = 1;
            this.ExpenseCode_Txt_Special.Tag = "ExpenseCode";
            this.ExpenseCode_Txt_Special.Leave += new System.EventHandler(this.ExpenseCode_Txt_Leave);
            // 
            // EC_Description_Txt_Special
            // 
            this.EC_Description_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EC_Description_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EC_Description_Txt_Special.Location = new System.Drawing.Point(115, 94);
            this.EC_Description_Txt_Special.MaxLength = 50;
            this.EC_Description_Txt_Special.Multiline = true;
            this.EC_Description_Txt_Special.Name = "EC_Description_Txt_Special";
            this.EC_Description_Txt_Special.Size = new System.Drawing.Size(190, 71);
            this.EC_Description_Txt_Special.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Description";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExpenseCodeNumber_Txt
            // 
            this.ExpenseCodeNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpenseCodeNumber_Txt.Location = new System.Drawing.Point(115, 19);
            this.ExpenseCodeNumber_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.ExpenseCodeNumber_Txt.Name = "ExpenseCodeNumber_Txt";
            this.ExpenseCodeNumber_Txt.Size = new System.Drawing.Size(190, 23);
            this.ExpenseCodeNumber_Txt.TabIndex = 25;
            this.ExpenseCodeNumber_Txt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 170);
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
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(742, 503);
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
            this.GV_ExpenseCodeNumber,
            this.GV_ExpenseCode,
            this.GV_EC_Description,
            this.LedgerAccount,
            this.LedgerName,
            this.DeleteColumn,
            this.UpdateColumn});
            this.GV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_List.Location = new System.Drawing.Point(15, 15);
            this.GV_List.Name = "GV_List";
            this.GV_List.ReadOnly = true;
            this.GV_List.RowTemplate.Height = 25;
            this.GV_List.Size = new System.Drawing.Size(712, 473);
            this.GV_List.TabIndex = 14;
            this.GV_List.TabStop = false;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            // 
            // GV_ExpenseCodeNumber
            // 
            this.GV_ExpenseCodeNumber.DataPropertyName = "ExpenseCodeNumber";
            this.GV_ExpenseCodeNumber.HeaderText = "Number";
            this.GV_ExpenseCodeNumber.Name = "GV_ExpenseCodeNumber";
            this.GV_ExpenseCodeNumber.ReadOnly = true;
            this.GV_ExpenseCodeNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GV_ExpenseCodeNumber.Visible = false;
            // 
            // GV_ExpenseCode
            // 
            this.GV_ExpenseCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_ExpenseCode.DataPropertyName = "ExpenseCode";
            this.GV_ExpenseCode.HeaderText = "Expense Code";
            this.GV_ExpenseCode.Name = "GV_ExpenseCode";
            this.GV_ExpenseCode.ReadOnly = true;
            this.GV_ExpenseCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GV_EC_Description
            // 
            this.GV_EC_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_EC_Description.DataPropertyName = "EC_Description";
            this.GV_EC_Description.HeaderText = "Description";
            this.GV_EC_Description.Name = "GV_EC_Description";
            this.GV_EC_Description.ReadOnly = true;
            this.GV_EC_Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LedgerAccount
            // 
            this.LedgerAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LedgerAccount.DataPropertyName = "LedgerAccount";
            this.LedgerAccount.HeaderText = "Ledger Account";
            this.LedgerAccount.Name = "LedgerAccount";
            this.LedgerAccount.ReadOnly = true;
            this.LedgerAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LedgerName
            // 
            this.LedgerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LedgerName.DataPropertyName = "LedgerName";
            this.LedgerName.HeaderText = "Ledger Name";
            this.LedgerName.Name = "LedgerName";
            this.LedgerName.ReadOnly = true;
            this.LedgerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(742, 60);
            this.panel2.TabIndex = 10;
            // 
            // ExpenseCode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1141, 578);
            this.Controls.Add(this.panel1);
            this.Name = "ExpenseCode";
            this.Text = "Expense Code";
            this.Load += new System.EventHandler(this.ExpenseCode_Load);
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
        private System.Windows.Forms.TextBox ExpenseCodeNumber_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LedgerAccount_Cmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExpenseCode_Txt_Special;
        private System.Windows.Forms.TextBox EC_Description_Txt_Special;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LedgerName_Txt;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ExpenseCodeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ExpenseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_EC_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn LedgerAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LedgerName;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn UpdateColumn;
    }
}