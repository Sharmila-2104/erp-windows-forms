namespace ERP.Purchase.COA.Master
{
    partial class Currency
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ForeignCurrency_Rbtn = new System.Windows.Forms.RadioButton();
            this.LocalCurrency_Rbtn = new System.Windows.Forms.RadioButton();
            this.DecimalPlaces_Txt_Digit = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.DecimalPortionName_Txt_Special = new System.Windows.Forms.TextBox();
            this.Symbol_Txt = new System.Windows.Forms.TextBox();
            this.FormalName_Txt_Char = new System.Windows.Forms.TextBox();
            this.CurrencyCode_Txt_Char = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CurrencyNumber_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.GV_CurrencyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_CurrencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_FormalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel1.Size = new System.Drawing.Size(1211, 610);
            this.panel1.TabIndex = 17;
            // 
            // splitContainer1
            // 
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
            this.splitContainer1.Size = new System.Drawing.Size(1181, 595);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ForeignCurrency_Rbtn);
            this.groupBox1.Controls.Add(this.LocalCurrency_Rbtn);
            this.groupBox1.Controls.Add(this.DecimalPlaces_Txt_Digit);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.DecimalPortionName_Txt_Special);
            this.groupBox1.Controls.Add(this.Symbol_Txt);
            this.groupBox1.Controls.Add(this.FormalName_Txt_Char);
            this.groupBox1.Controls.Add(this.CurrencyCode_Txt_Char);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CurrencyNumber_Txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(320, 565);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 283);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(97, 54);
            this.label8.TabIndex = 41;
            this.label8.Text = "Currency Location";
            // 
            // ForeignCurrency_Rbtn
            // 
            this.ForeignCurrency_Rbtn.AutoSize = true;
            this.ForeignCurrency_Rbtn.Location = new System.Drawing.Point(121, 313);
            this.ForeignCurrency_Rbtn.Name = "ForeignCurrency_Rbtn";
            this.ForeignCurrency_Rbtn.Size = new System.Drawing.Size(137, 20);
            this.ForeignCurrency_Rbtn.TabIndex = 7;
            this.ForeignCurrency_Rbtn.TabStop = true;
            this.ForeignCurrency_Rbtn.Text = "Foreign Currency";
            this.ForeignCurrency_Rbtn.UseVisualStyleBackColor = true;
            // 
            // LocalCurrency_Rbtn
            // 
            this.LocalCurrency_Rbtn.AutoSize = true;
            this.LocalCurrency_Rbtn.Location = new System.Drawing.Point(121, 283);
            this.LocalCurrency_Rbtn.Name = "LocalCurrency_Rbtn";
            this.LocalCurrency_Rbtn.Size = new System.Drawing.Size(123, 20);
            this.LocalCurrency_Rbtn.TabIndex = 6;
            this.LocalCurrency_Rbtn.TabStop = true;
            this.LocalCurrency_Rbtn.Text = "Local Currency";
            this.LocalCurrency_Rbtn.UseVisualStyleBackColor = true;
            // 
            // DecimalPlaces_Txt_Digit
            // 
            this.DecimalPlaces_Txt_Digit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalPlaces_Txt_Digit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecimalPlaces_Txt_Digit.Location = new System.Drawing.Point(121, 174);
            this.DecimalPlaces_Txt_Digit.MaxLength = 2;
            this.DecimalPlaces_Txt_Digit.Name = "DecimalPlaces_Txt_Digit";
            this.DecimalPlaces_Txt_Digit.Size = new System.Drawing.Size(181, 23);
            this.DecimalPlaces_Txt_Digit.TabIndex = 4;
            this.DecimalPlaces_Txt_Digit.Tag = "DecimalPlaces";
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Location = new System.Drawing.Point(113, 384);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(66, 27);
            this.Btn_Save.TabIndex = 8;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(201, 385);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(73, 26);
            this.Btn_Clear.TabIndex = 10;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Location = new System.Drawing.Point(113, 384);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(66, 27);
            this.Btn_Update.TabIndex = 9;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // DecimalPortionName_Txt_Special
            // 
            this.DecimalPortionName_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalPortionName_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecimalPortionName_Txt_Special.Location = new System.Drawing.Point(121, 224);
            this.DecimalPortionName_Txt_Special.MaxLength = 15;
            this.DecimalPortionName_Txt_Special.Name = "DecimalPortionName_Txt_Special";
            this.DecimalPortionName_Txt_Special.Size = new System.Drawing.Size(181, 23);
            this.DecimalPortionName_Txt_Special.TabIndex = 5;
            // 
            // Symbol_Txt
            // 
            this.Symbol_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Symbol_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Symbol_Txt.Location = new System.Drawing.Point(121, 134);
            this.Symbol_Txt.MaxLength = 3;
            this.Symbol_Txt.Name = "Symbol_Txt";
            this.Symbol_Txt.Size = new System.Drawing.Size(181, 23);
            this.Symbol_Txt.TabIndex = 3;
            // 
            // FormalName_Txt_Char
            // 
            this.FormalName_Txt_Char.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormalName_Txt_Char.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormalName_Txt_Char.Location = new System.Drawing.Point(121, 97);
            this.FormalName_Txt_Char.MaxLength = 30;
            this.FormalName_Txt_Char.Name = "FormalName_Txt_Char";
            this.FormalName_Txt_Char.Size = new System.Drawing.Size(181, 23);
            this.FormalName_Txt_Char.TabIndex = 2;
            this.FormalName_Txt_Char.Tag = "FormalName";
            // 
            // CurrencyCode_Txt_Char
            // 
            this.CurrencyCode_Txt_Char.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrencyCode_Txt_Char.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrencyCode_Txt_Char.Location = new System.Drawing.Point(121, 58);
            this.CurrencyCode_Txt_Char.MaxLength = 10;
            this.CurrencyCode_Txt_Char.Name = "CurrencyCode_Txt_Char";
            this.CurrencyCode_Txt_Char.Size = new System.Drawing.Size(181, 23);
            this.CurrencyCode_Txt_Char.TabIndex = 1;
            this.CurrencyCode_Txt_Char.Tag = "CurrencyCode";
            this.CurrencyCode_Txt_Char.Leave += new System.EventHandler(this.CurrencyCode_Txt_Char_Leave);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 215);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(97, 54);
            this.label6.TabIndex = 40;
            this.label6.Text = "Name of Decimal Portion";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 170);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(97, 40);
            this.label5.TabIndex = 39;
            this.label5.Text = "Number of Decimal places";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Symbol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(97, 34);
            this.label2.TabIndex = 35;
            this.label2.Text = "Currency Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Formal Name";
            // 
            // CurrencyNumber_Txt
            // 
            this.CurrencyNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrencyNumber_Txt.Location = new System.Drawing.Point(121, 22);
            this.CurrencyNumber_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.CurrencyNumber_Txt.Name = "CurrencyNumber_Txt";
            this.CurrencyNumber_Txt.Size = new System.Drawing.Size(181, 23);
            this.CurrencyNumber_Txt.TabIndex = 25;
            this.CurrencyNumber_Txt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 142);
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
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(812, 535);
            this.panel3.TabIndex = 11;
            // 
            // GV_List
            // 
            this.GV_List.AllowUserToAddRows = false;
            this.GV_List.AllowUserToDeleteRows = false;
            this.GV_List.AllowUserToOrderColumns = true;
            this.GV_List.BackgroundColor = System.Drawing.Color.White;
            this.GV_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GV_CurrencyNumber,
            this.GV_CurrencyCode,
            this.GV_FormalName,
            this.GV_Symbol,
            this.DeleteColumn,
            this.UpdateColumn});
            this.GV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_List.Location = new System.Drawing.Point(15, 15);
            this.GV_List.Name = "GV_List";
            this.GV_List.ReadOnly = true;
            this.GV_List.RowTemplate.Height = 25;
            this.GV_List.Size = new System.Drawing.Size(782, 505);
            this.GV_List.TabIndex = 17;
            this.GV_List.TabStop = false;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            // 
            // GV_CurrencyNumber
            // 
            this.GV_CurrencyNumber.DataPropertyName = "CurrencyNumber";
            this.GV_CurrencyNumber.HeaderText = "Number";
            this.GV_CurrencyNumber.Name = "GV_CurrencyNumber";
            this.GV_CurrencyNumber.ReadOnly = true;
            this.GV_CurrencyNumber.Visible = false;
            // 
            // GV_CurrencyCode
            // 
            this.GV_CurrencyCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_CurrencyCode.DataPropertyName = "CurrencyCode";
            this.GV_CurrencyCode.FillWeight = 65.40792F;
            this.GV_CurrencyCode.HeaderText = "Currency Code";
            this.GV_CurrencyCode.Name = "GV_CurrencyCode";
            this.GV_CurrencyCode.ReadOnly = true;
            // 
            // GV_FormalName
            // 
            this.GV_FormalName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_FormalName.DataPropertyName = "FormalName";
            this.GV_FormalName.FillWeight = 65.40792F;
            this.GV_FormalName.HeaderText = "Formal Name";
            this.GV_FormalName.Name = "GV_FormalName";
            this.GV_FormalName.ReadOnly = true;
            // 
            // GV_Symbol
            // 
            this.GV_Symbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_Symbol.DataPropertyName = "Symbol";
            this.GV_Symbol.FillWeight = 65.40792F;
            this.GV_Symbol.HeaderText = "Symbol";
            this.GV_Symbol.Name = "GV_Symbol";
            this.GV_Symbol.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.FillWeight = 151.4919F;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Image = global::ERP.Properties.Resources.delete;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteColumn.Width = 60;
            // 
            // UpdateColumn
            // 
            this.UpdateColumn.FillWeight = 152.2842F;
            this.UpdateColumn.HeaderText = "Edit";
            this.UpdateColumn.Image = global::ERP.Properties.Resources.edit;
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.ReadOnly = true;
            this.UpdateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UpdateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UpdateColumn.Width = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(15, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(812, 60);
            this.panel2.TabIndex = 10;
            // 
            // Currency
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1211, 610);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Currency";
            this.Text = "Currency";
            this.Load += new System.EventHandler(this.Currency_Load);
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
        private System.Windows.Forms.TextBox CurrencyNumber_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton LocalCurrency_Rbtn;
        private System.Windows.Forms.RadioButton ForeignCurrency_Rbtn;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox DecimalPortionName_Txt_Special;
        private System.Windows.Forms.TextBox Symbol_Txt;
        private System.Windows.Forms.TextBox FormalName_Txt_Char;
        private System.Windows.Forms.TextBox CurrencyCode_Txt_Char;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_CurrencyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_CurrencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_FormalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_Symbol;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn UpdateColumn;
        private System.Windows.Forms.TextBox DecimalPlaces_Txt_Digit;
        private System.Windows.Forms.Label label8;
    }
}