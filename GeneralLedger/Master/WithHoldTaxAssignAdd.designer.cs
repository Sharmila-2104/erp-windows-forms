namespace ERP.Purchase.Tax.Master
{
    partial class WithHoldTaxAssignAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Txt_Description = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Txt_Code = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GV_WithHoldTaxAssign_D = new System.Windows.Forms.DataGridView();
            this.Txt_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ddl_AssesseNumber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Txt_FromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_ToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_Single = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_Aggregate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ddl_TaxNumber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Txt_Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_Pan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ddl_LedgerNumber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_WithHoldTaxAssign_D)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.Txt_Description);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Txt_Code);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.Btn_Back);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(352, 426);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WithHold Tax Assign";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tax Code\r\n";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(180, 264);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 36);
            this.Btn_Clear.TabIndex = 21;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Txt_Description
            // 
            this.Txt_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Description.Location = new System.Drawing.Point(84, 170);
            this.Txt_Description.MaxLength = 50;
            this.Txt_Description.Multiline = true;
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Size = new System.Drawing.Size(250, 71);
            this.Txt_Description.TabIndex = 17;
            this.Txt_Description.Tag = "Description";
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Location = new System.Drawing.Point(84, 264);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 36);
            this.Btn_Save.TabIndex = 20;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Txt_Code
            // 
            this.Txt_Code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Code.Location = new System.Drawing.Point(84, 127);
            this.Txt_Code.MaxLength = 25;
            this.Txt_Code.Name = "Txt_Code";
            this.Txt_Code.Size = new System.Drawing.Size(250, 20);
            this.Txt_Code.TabIndex = 16;
            this.Txt_Code.Tag = "Tax Code";
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Location = new System.Drawing.Point(84, 264);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 36);
            this.Btn_Update.TabIndex = 18;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Location = new System.Drawing.Point(249, 79);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(85, 24);
            this.Btn_Back.TabIndex = 19;
            this.Btn_Back.Text = "Back To List";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.GV_WithHoldTaxAssign_D);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(969, 450);
            this.panel1.TabIndex = 24;
            // 
            // GV_WithHoldTaxAssign_D
            // 
            this.GV_WithHoldTaxAssign_D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GV_WithHoldTaxAssign_D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_WithHoldTaxAssign_D.BackgroundColor = System.Drawing.Color.White;
            this.GV_WithHoldTaxAssign_D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_WithHoldTaxAssign_D.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Txt_Number,
            this.Ddl_AssesseNumber,
            this.Txt_FromDate,
            this.Txt_ToDate,
            this.Txt_Single,
            this.Txt_Aggregate,
            this.Ddl_TaxNumber,
            this.Txt_Percentage,
            this.Txt_Pan,
            this.Ddl_LedgerNumber,
            this.DeleteColumn});
            this.GV_WithHoldTaxAssign_D.Location = new System.Drawing.Point(370, 110);
            this.GV_WithHoldTaxAssign_D.Name = "GV_WithHoldTaxAssign_D";
            this.GV_WithHoldTaxAssign_D.Size = new System.Drawing.Size(587, 202);
            this.GV_WithHoldTaxAssign_D.TabIndex = 22;
            this.GV_WithHoldTaxAssign_D.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_WithHoldTaxAssign_D_CellContentClick);
            // 
            // Txt_Number
            // 
            this.Txt_Number.DataPropertyName = "Number";
            this.Txt_Number.HeaderText = "Number";
            this.Txt_Number.Name = "Txt_Number";
            this.Txt_Number.Visible = false;
            // 
            // Ddl_AssesseNumber
            // 
            this.Ddl_AssesseNumber.DataPropertyName = "AssesseNumber";
            this.Ddl_AssesseNumber.HeaderText = "Nature Of Assesse";
            this.Ddl_AssesseNumber.Name = "Ddl_AssesseNumber";
            this.Ddl_AssesseNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ddl_AssesseNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Txt_FromDate
            // 
            this.Txt_FromDate.DataPropertyName = "FromDate";
            this.Txt_FromDate.HeaderText = "From Date";
            this.Txt_FromDate.Name = "Txt_FromDate";
            // 
            // Txt_ToDate
            // 
            this.Txt_ToDate.DataPropertyName = "ToDate";
            this.Txt_ToDate.HeaderText = "To Date";
            this.Txt_ToDate.Name = "Txt_ToDate";
            // 
            // Txt_Single
            // 
            this.Txt_Single.DataPropertyName = "Single";
            this.Txt_Single.HeaderText = "Single Transaction";
            this.Txt_Single.Name = "Txt_Single";
            this.Txt_Single.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Txt_Aggregate
            // 
            this.Txt_Aggregate.DataPropertyName = "Aggregate";
            this.Txt_Aggregate.HeaderText = "Aggregate Transaction";
            this.Txt_Aggregate.Name = "Txt_Aggregate";
            // 
            // Ddl_TaxNumber
            // 
            this.Ddl_TaxNumber.DataPropertyName = "TaxNumber";
            this.Ddl_TaxNumber.HeaderText = "Include Tax";
            this.Ddl_TaxNumber.Name = "Ddl_TaxNumber";
            this.Ddl_TaxNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ddl_TaxNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Txt_Percentage
            // 
            this.Txt_Percentage.DataPropertyName = "Percentage";
            this.Txt_Percentage.HeaderText = "Tax Percentage";
            this.Txt_Percentage.Name = "Txt_Percentage";
            // 
            // Txt_Pan
            // 
            this.Txt_Pan.DataPropertyName = "Pan";
            this.Txt_Pan.HeaderText = "PAN non-availability %";
            this.Txt_Pan.Name = "Txt_Pan";
            // 
            // Ddl_LedgerNumber
            // 
            this.Ddl_LedgerNumber.DataPropertyName = "LedgerNumber";
            this.Ddl_LedgerNumber.HeaderText = "Assign COA";
            this.Ddl_LedgerNumber.Name = "Ddl_LedgerNumber";
            this.Ddl_LedgerNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ddl_LedgerNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Image = global::ERP.Properties.Resources.delete;
            this.DeleteColumn.Name = "DeleteColumn";
            // 
            // WithHoldTaxAssignAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.panel1);
            this.Name = "WithHoldTaxAssignAdd";
            this.Text = "WithHold Tax Assign Add";
            this.Load += new System.EventHandler(this.WithHoldTaxAssignAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_WithHoldTaxAssign_D)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.TextBox Txt_Description;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox Txt_Code;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GV_WithHoldTaxAssign_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txt_Number;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ddl_AssesseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txt_FromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txt_ToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txt_Single;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txt_Aggregate;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ddl_TaxNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txt_Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txt_Pan;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ddl_LedgerNumber;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
    }
}