namespace ERP.Purchase.Tax.Master
{
    partial class TaxElement
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxElement));
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.CreatePanel = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RGV_List = new Telerik.WinControls.UI.RadGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LedgerName_Txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.COA_Cmbx = new System.Windows.Forms.ComboBox();
            this.TaxElement_Txt_Special = new System.Windows.Forms.TextBox();
            this.TaxType_Cmbx = new System.Windows.Forms.ComboBox();
            this.TaxCategory_Cmbx = new System.Windows.Forms.ComboBox();
            this.TaxElementNumber_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ElementDescription_Txt_Special = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.RightHeadPanel = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreatePanel)).BeginInit();
            this.CreatePanel.Panel1.SuspendLayout();
            this.CreatePanel.Panel2.SuspendLayout();
            this.CreatePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGV_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGV_List.MasterTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.RightHeadPanel.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.LeftPanel);
            this.MainPanel.Controls.Add(this.RightPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 7);
            this.MainPanel.Size = new System.Drawing.Size(1028, 495);
            this.MainPanel.TabIndex = 205;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.CreatePanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(8, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.LeftPanel.Size = new System.Drawing.Size(837, 488);
            this.LeftPanel.TabIndex = 1;
            // 
            // CreatePanel
            // 
            this.CreatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatePanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.CreatePanel.IsSplitterFixed = true;
            this.CreatePanel.Location = new System.Drawing.Point(0, 0);
            this.CreatePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreatePanel.Name = "CreatePanel";
            // 
            // CreatePanel.Panel1
            // 
            this.CreatePanel.Panel1.Controls.Add(this.panel3);
            // 
            // CreatePanel.Panel2
            // 
            this.CreatePanel.Panel2.BackColor = System.Drawing.Color.White;
            this.CreatePanel.Panel2.Controls.Add(this.groupBox1);
            this.CreatePanel.Panel2.Padding = new System.Windows.Forms.Padding(15);
            this.CreatePanel.Panel2MinSize = 350;
            this.CreatePanel.Size = new System.Drawing.Size(829, 488);
            this.CreatePanel.SplitterDistance = 438;
            this.CreatePanel.SplitterWidth = 5;
            this.CreatePanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.RGV_List);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(438, 488);
            this.panel3.TabIndex = 12;
            // 
            // RGV_List
            // 
            this.RGV_List.BackColor = System.Drawing.Color.White;
            this.RGV_List.Cursor = System.Windows.Forms.Cursors.Default;
            this.RGV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGV_List.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RGV_List.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RGV_List.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RGV_List.Location = new System.Drawing.Point(15, 15);
            // 
            // 
            // 
            this.RGV_List.MasterTemplate.AllowAddNewRow = false;
            this.RGV_List.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "TaxElementNumber";
            gridViewTextBoxColumn1.HeaderText = "TaxElement Number";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "GV_TaxElementNumber";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "TaxElement";
            gridViewTextBoxColumn2.HeaderText = "Tax Element";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "GV_TaxElement";
            gridViewTextBoxColumn2.Width = 62;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ElementDescription";
            gridViewTextBoxColumn3.HeaderText = "Tax Description";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "GV_ElementDescription";
            gridViewTextBoxColumn3.Width = 62;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "TaxCategory";
            gridViewTextBoxColumn4.HeaderText = "Category";
            gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn4.Name = "GV_TaxCategory";
            gridViewTextBoxColumn4.Width = 62;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "TaxType";
            gridViewTextBoxColumn5.HeaderText = "Type";
            gridViewTextBoxColumn5.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn5.Name = "GV_TaxType";
            gridViewTextBoxColumn5.Width = 42;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "COA";
            gridViewTextBoxColumn6.HeaderText = "Assign COA";
            gridViewTextBoxColumn6.Name = "GV_COA";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 46;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "LedgerName";
            gridViewTextBoxColumn7.HeaderText = "Ledger Name";
            gridViewTextBoxColumn7.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn7.Name = "GV_LedgerName";
            gridViewTextBoxColumn7.Width = 32;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Edit";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.MaxWidth = 50;
            gridViewCommandColumn1.Name = "Edit_Cmd";
            gridViewCommandColumn1.Width = 47;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "Delete";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.MaxWidth = 50;
            gridViewCommandColumn2.Name = "Delete_Cmd";
            gridViewCommandColumn2.Width = 41;
            this.RGV_List.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.RGV_List.MasterTemplate.EnableFiltering = true;
            this.RGV_List.MasterTemplate.EnableGrouping = false;
            this.RGV_List.MasterTemplate.ShowFilterCellOperatorText = false;
            this.RGV_List.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.RGV_List.Name = "RGV_List";
            this.RGV_List.ReadOnly = true;
            this.RGV_List.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RGV_List.Size = new System.Drawing.Size(408, 458);
            this.RGV_List.TabIndex = 9;
            this.RGV_List.ThemeName = "ControlDefault";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LedgerName_Txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.COA_Cmbx);
            this.groupBox1.Controls.Add(this.TaxElement_Txt_Special);
            this.groupBox1.Controls.Add(this.TaxType_Cmbx);
            this.groupBox1.Controls.Add(this.TaxCategory_Cmbx);
            this.groupBox1.Controls.Add(this.TaxElementNumber_Txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ElementDescription_Txt_Special);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(356, 458);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax Element";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ledger Name";
            // 
            // LedgerName_Txt
            // 
            this.LedgerName_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LedgerName_Txt.BackColor = System.Drawing.Color.White;
            this.LedgerName_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LedgerName_Txt.Enabled = false;
            this.LedgerName_Txt.Location = new System.Drawing.Point(112, 322);
            this.LedgerName_Txt.Margin = new System.Windows.Forms.Padding(5);
            this.LedgerName_Txt.MaxLength = 25;
            this.LedgerName_Txt.Name = "LedgerName_Txt";
            this.LedgerName_Txt.Size = new System.Drawing.Size(224, 21);
            this.LedgerName_Txt.TabIndex = 33;
            this.LedgerName_Txt.Tag = "TaxElement";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 272);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Assign COA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Element";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Type";
            // 
            // COA_Cmbx
            // 
            this.COA_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COA_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COA_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.COA_Cmbx.FormattingEnabled = true;
            this.COA_Cmbx.Location = new System.Drawing.Point(113, 270);
            this.COA_Cmbx.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.COA_Cmbx.Name = "COA_Cmbx";
            this.COA_Cmbx.Size = new System.Drawing.Size(224, 21);
            this.COA_Cmbx.TabIndex = 5;
            this.COA_Cmbx.Tag = "COA";
            // 
            // TaxElement_Txt_Special
            // 
            this.TaxElement_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxElement_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxElement_Txt_Special.Location = new System.Drawing.Point(112, 66);
            this.TaxElement_Txt_Special.Margin = new System.Windows.Forms.Padding(5);
            this.TaxElement_Txt_Special.MaxLength = 25;
            this.TaxElement_Txt_Special.Name = "TaxElement_Txt_Special";
            this.TaxElement_Txt_Special.Size = new System.Drawing.Size(224, 21);
            this.TaxElement_Txt_Special.TabIndex = 3;
            this.TaxElement_Txt_Special.Tag = "TaxElement";
            // 
            // TaxType_Cmbx
            // 
            this.TaxType_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxType_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaxType_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TaxType_Cmbx.FormattingEnabled = true;
            this.TaxType_Cmbx.Location = new System.Drawing.Point(113, 224);
            this.TaxType_Cmbx.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TaxType_Cmbx.Name = "TaxType_Cmbx";
            this.TaxType_Cmbx.Size = new System.Drawing.Size(224, 21);
            this.TaxType_Cmbx.TabIndex = 2;
            this.TaxType_Cmbx.Tag = "TaxType";
            // 
            // TaxCategory_Cmbx
            // 
            this.TaxCategory_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxCategory_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaxCategory_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TaxCategory_Cmbx.FormattingEnabled = true;
            this.TaxCategory_Cmbx.Location = new System.Drawing.Point(113, 185);
            this.TaxCategory_Cmbx.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TaxCategory_Cmbx.Name = "TaxCategory_Cmbx";
            this.TaxCategory_Cmbx.Size = new System.Drawing.Size(224, 21);
            this.TaxCategory_Cmbx.TabIndex = 1;
            this.TaxCategory_Cmbx.Tag = "TaxCategory";
            // 
            // TaxElementNumber_Txt
            // 
            this.TaxElementNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxElementNumber_Txt.Location = new System.Drawing.Point(112, 12);
            this.TaxElementNumber_Txt.Margin = new System.Windows.Forms.Padding(5);
            this.TaxElementNumber_Txt.Name = "TaxElementNumber_Txt";
            this.TaxElementNumber_Txt.Size = new System.Drawing.Size(188, 21);
            this.TaxElementNumber_Txt.TabIndex = 21;
            this.TaxElementNumber_Txt.TabStop = false;
            this.TaxElementNumber_Txt.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 14;
            // 
            // ElementDescription_Txt_Special
            // 
            this.ElementDescription_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElementDescription_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ElementDescription_Txt_Special.Location = new System.Drawing.Point(112, 105);
            this.ElementDescription_Txt_Special.Margin = new System.Windows.Forms.Padding(5);
            this.ElementDescription_Txt_Special.MaxLength = 50;
            this.ElementDescription_Txt_Special.Multiline = true;
            this.ElementDescription_Txt_Special.Name = "ElementDescription_Txt_Special";
            this.ElementDescription_Txt_Special.Size = new System.Drawing.Size(224, 61);
            this.ElementDescription_Txt_Special.TabIndex = 4;
            this.ElementDescription_Txt_Special.Tag = "ElementDescription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Description";
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.White;
            this.RightPanel.Controls.Add(this.RightHeadPanel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(845, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(175, 488);
            this.RightPanel.TabIndex = 0;
            // 
            // RightHeadPanel
            // 
            this.RightHeadPanel.BackColor = System.Drawing.Color.White;
            this.RightHeadPanel.Controls.Add(this.panel12);
            this.RightHeadPanel.Controls.Add(this.panel6);
            this.RightHeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightHeadPanel.Location = new System.Drawing.Point(0, 0);
            this.RightHeadPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RightHeadPanel.MaximumSize = new System.Drawing.Size(0, 199);
            this.RightHeadPanel.MinimumSize = new System.Drawing.Size(0, 199);
            this.RightHeadPanel.Name = "RightHeadPanel";
            this.RightHeadPanel.Padding = new System.Windows.Forms.Padding(15);
            this.RightHeadPanel.Size = new System.Drawing.Size(175, 199);
            this.RightHeadPanel.TabIndex = 198;
            // 
            // panel12
            // 
            this.panel12.AutoSize = true;
            this.panel12.Controls.Add(this.Btn_Clear);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(15, 52);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel12.Size = new System.Drawing.Size(145, 35);
            this.panel12.TabIndex = 195;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Clear.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Clear.Location = new System.Drawing.Point(0, 0);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(145, 25);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.Btn_Save);
            this.panel6.Controls.Add(this.Btn_Update);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(15, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel6.Size = new System.Drawing.Size(145, 37);
            this.panel6.TabIndex = 194;
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Save.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Save.Location = new System.Drawing.Point(0, 0);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(145, 25);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Update.Location = new System.Drawing.Point(0, 0);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(145, 25);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            // 
            // TaxElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 495);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TaxElement";
            this.Text = "Tax Element";
            this.Load += new System.EventHandler(this.TaxElement_Load);
            this.MainPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.CreatePanel.Panel1.ResumeLayout(false);
            this.CreatePanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CreatePanel)).EndInit();
            this.CreatePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGV_List.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGV_List)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightHeadPanel.ResumeLayout(false);
            this.RightHeadPanel.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.SplitContainer CreatePanel;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadGridView RGV_List;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LedgerName_Txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox COA_Cmbx;
        private System.Windows.Forms.TextBox TaxElement_Txt_Special;
        private System.Windows.Forms.ComboBox TaxType_Cmbx;
        private System.Windows.Forms.ComboBox TaxCategory_Cmbx;
        private System.Windows.Forms.TextBox TaxElementNumber_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ElementDescription_Txt_Special;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel RightHeadPanel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Update;
    }
}