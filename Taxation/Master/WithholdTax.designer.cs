namespace ERP.Purchase.Tax.Master
{
    partial class WithholdTax
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn31 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn32 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn33 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn34 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn35 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn36 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn11 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithholdTax));
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn12 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.CreatePanel = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RGV_List = new Telerik.WinControls.UI.RadGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Impact = new System.Windows.Forms.Label();
            this.TaxCode = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.WH_TaxDescription_Txt_Special = new System.Windows.Forms.TextBox();
            this.WH_TaxCode_Txt_Special = new System.Windows.Forms.TextBox();
            this.WH_TaxImpact_Cmbx = new System.Windows.Forms.ComboBox();
            this.WH_TaxType_Cmbx = new System.Windows.Forms.ComboBox();
            this.WH_TaxCategory_Cmbx = new System.Windows.Forms.ComboBox();
            this.WithholdtaxNumber_Txt = new System.Windows.Forms.TextBox();
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
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Edit";
            this.dataGridViewImageColumn2.Image = global::ERP.Properties.Resources.edit;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::ERP.Properties.Resources.delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.LeftPanel);
            this.MainPanel.Controls.Add(this.RightPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.MainPanel.Size = new System.Drawing.Size(1149, 468);
            this.MainPanel.TabIndex = 204;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.CreatePanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(8, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.LeftPanel.Size = new System.Drawing.Size(958, 460);
            this.LeftPanel.TabIndex = 1;
            // 
            // CreatePanel
            // 
            this.CreatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatePanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.CreatePanel.IsSplitterFixed = true;
            this.CreatePanel.Location = new System.Drawing.Point(0, 0);
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
            this.CreatePanel.Size = new System.Drawing.Size(950, 460);
            this.CreatePanel.SplitterDistance = 563;
            this.CreatePanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.RGV_List);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(563, 460);
            this.panel3.TabIndex = 12;
            // 
            // RGV_List
            // 
            this.RGV_List.BackColor = System.Drawing.Color.White;
            this.RGV_List.Cursor = System.Windows.Forms.Cursors.Default;
            this.RGV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RGV_List.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RGV_List.ForeColor = System.Drawing.Color.Black;
            this.RGV_List.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RGV_List.Location = new System.Drawing.Point(15, 15);
            // 
            // 
            // 
            this.RGV_List.MasterTemplate.AllowAddNewRow = false;
            this.RGV_List.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn31.EnableExpressionEditor = false;
            gridViewTextBoxColumn31.FieldName = "WithholdtaxNumber";
            gridViewTextBoxColumn31.HeaderText = "Withholdtax Number";
            gridViewTextBoxColumn31.IsVisible = false;
            gridViewTextBoxColumn31.Name = "GV_WithholdtaxNumber";
            gridViewTextBoxColumn31.Width = 130;
            gridViewTextBoxColumn32.EnableExpressionEditor = false;
            gridViewTextBoxColumn32.FieldName = "WH_TaxCode";
            gridViewTextBoxColumn32.HeaderText = "Tax Code";
            gridViewTextBoxColumn32.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn32.Name = "GV_WH_TaxCode";
            gridViewTextBoxColumn32.ReadOnly = true;
            gridViewTextBoxColumn32.Width = 88;
            gridViewTextBoxColumn33.EnableExpressionEditor = false;
            gridViewTextBoxColumn33.FieldName = "WH_TaxDescription";
            gridViewTextBoxColumn33.HeaderText = "Description";
            gridViewTextBoxColumn33.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn33.Name = "GV_WH_TaxDescription";
            gridViewTextBoxColumn33.ReadOnly = true;
            gridViewTextBoxColumn33.Width = 125;
            gridViewTextBoxColumn34.EnableExpressionEditor = false;
            gridViewTextBoxColumn34.FieldName = "TaxCategory";
            gridViewTextBoxColumn34.HeaderText = "Category";
            gridViewTextBoxColumn34.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn34.Name = "GV_TaxCategory";
            gridViewTextBoxColumn34.ReadOnly = true;
            gridViewTextBoxColumn34.Width = 87;
            gridViewTextBoxColumn35.EnableExpressionEditor = false;
            gridViewTextBoxColumn35.FieldName = "TaxType";
            gridViewTextBoxColumn35.HeaderText = "Type";
            gridViewTextBoxColumn35.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn35.Name = "GV_TaxType";
            gridViewTextBoxColumn35.ReadOnly = true;
            gridViewTextBoxColumn35.Width = 41;
            gridViewTextBoxColumn36.EnableExpressionEditor = false;
            gridViewTextBoxColumn36.FieldName = "WH_TaxImpact";
            gridViewTextBoxColumn36.HeaderText = "Impact";
            gridViewTextBoxColumn36.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn36.Name = "GV_WH_TaxImpact";
            gridViewTextBoxColumn36.ReadOnly = true;
            gridViewTextBoxColumn36.Width = 107;
            gridViewCommandColumn11.EnableExpressionEditor = false;
            gridViewCommandColumn11.HeaderText = "Edit";
            gridViewCommandColumn11.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn11.Image")));
            gridViewCommandColumn11.MaxWidth = 50;
            gridViewCommandColumn11.Name = "Edit_Cmd";
            gridViewCommandColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn11.Width = 35;
            gridViewCommandColumn12.EnableExpressionEditor = false;
            gridViewCommandColumn12.HeaderText = "Delete";
            gridViewCommandColumn12.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn12.Image")));
            gridViewCommandColumn12.MaxWidth = 50;
            gridViewCommandColumn12.Name = "Delete_Cmd";
            gridViewCommandColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn12.Width = 35;
            this.RGV_List.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn31,
            gridViewTextBoxColumn32,
            gridViewTextBoxColumn33,
            gridViewTextBoxColumn34,
            gridViewTextBoxColumn35,
            gridViewTextBoxColumn36,
            gridViewCommandColumn11,
            gridViewCommandColumn12});
            this.RGV_List.MasterTemplate.EnableFiltering = true;
            this.RGV_List.MasterTemplate.ShowFilterCellOperatorText = false;
            this.RGV_List.MasterTemplate.ViewDefinition = tableViewDefinition6;
            this.RGV_List.Name = "RGV_List";
            this.RGV_List.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RGV_List.ShowGroupPanel = false;
            this.RGV_List.Size = new System.Drawing.Size(533, 430);
            this.RGV_List.TabIndex = 9;
            this.RGV_List.ThemeName = "ControlDefault";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Impact);
            this.groupBox1.Controls.Add(this.TaxCode);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.WH_TaxDescription_Txt_Special);
            this.groupBox1.Controls.Add(this.WH_TaxCode_Txt_Special);
            this.groupBox1.Controls.Add(this.WH_TaxImpact_Cmbx);
            this.groupBox1.Controls.Add(this.WH_TaxType_Cmbx);
            this.groupBox1.Controls.Add(this.WH_TaxCategory_Cmbx);
            this.groupBox1.Controls.Add(this.WithholdtaxNumber_Txt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(353, 430);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Withhold Tax";
            // 
            // Impact
            // 
            this.Impact.AutoSize = true;
            this.Impact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Impact.Location = new System.Drawing.Point(48, 248);
            this.Impact.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Impact.Name = "Impact";
            this.Impact.Size = new System.Drawing.Size(47, 16);
            this.Impact.TabIndex = 35;
            this.Impact.Text = "Impact";
            // 
            // TaxCode
            // 
            this.TaxCode.AutoSize = true;
            this.TaxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxCode.Location = new System.Drawing.Point(29, 60);
            this.TaxCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TaxCode.Name = "TaxCode";
            this.TaxCode.Size = new System.Drawing.Size(66, 16);
            this.TaxCode.TabIndex = 34;
            this.TaxCode.Text = "Tax Code";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(56, 209);
            this.Type.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(39, 16);
            this.Type.TabIndex = 33;
            this.Type.Text = "Type";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(33, 172);
            this.Category.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(62, 16);
            this.Category.TabIndex = 32;
            this.Category.Text = "Category";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(20, 95);
            this.Description.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(75, 16);
            this.Description.TabIndex = 31;
            this.Description.Text = "Description";
            // 
            // WH_TaxDescription_Txt_Special
            // 
            this.WH_TaxDescription_Txt_Special.AccessibleName = "";
            this.WH_TaxDescription_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WH_TaxDescription_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WH_TaxDescription_Txt_Special.Location = new System.Drawing.Point(105, 95);
            this.WH_TaxDescription_Txt_Special.Margin = new System.Windows.Forms.Padding(5);
            this.WH_TaxDescription_Txt_Special.MaxLength = 50;
            this.WH_TaxDescription_Txt_Special.Multiline = true;
            this.WH_TaxDescription_Txt_Special.Name = "WH_TaxDescription_Txt_Special";
            this.WH_TaxDescription_Txt_Special.Size = new System.Drawing.Size(222, 61);
            this.WH_TaxDescription_Txt_Special.TabIndex = 4;
            this.WH_TaxDescription_Txt_Special.Tag = "WH_TaxDescription";
            // 
            // WH_TaxCode_Txt_Special
            // 
            this.WH_TaxCode_Txt_Special.AccessibleName = "";
            this.WH_TaxCode_Txt_Special.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WH_TaxCode_Txt_Special.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WH_TaxCode_Txt_Special.Location = new System.Drawing.Point(105, 58);
            this.WH_TaxCode_Txt_Special.Margin = new System.Windows.Forms.Padding(5);
            this.WH_TaxCode_Txt_Special.MaxLength = 25;
            this.WH_TaxCode_Txt_Special.Name = "WH_TaxCode_Txt_Special";
            this.WH_TaxCode_Txt_Special.Size = new System.Drawing.Size(222, 21);
            this.WH_TaxCode_Txt_Special.TabIndex = 3;
            this.WH_TaxCode_Txt_Special.Tag = "WH_TaxCode";
            // 
            // WH_TaxImpact_Cmbx
            // 
            this.WH_TaxImpact_Cmbx.AccessibleName = "";
            this.WH_TaxImpact_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WH_TaxImpact_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WH_TaxImpact_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WH_TaxImpact_Cmbx.FormattingEnabled = true;
            this.WH_TaxImpact_Cmbx.Location = new System.Drawing.Point(105, 245);
            this.WH_TaxImpact_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.WH_TaxImpact_Cmbx.Name = "WH_TaxImpact_Cmbx";
            this.WH_TaxImpact_Cmbx.Size = new System.Drawing.Size(222, 21);
            this.WH_TaxImpact_Cmbx.TabIndex = 5;
            this.WH_TaxImpact_Cmbx.Tag = "WH_TaxImpact";
            // 
            // WH_TaxType_Cmbx
            // 
            this.WH_TaxType_Cmbx.AccessibleName = "";
            this.WH_TaxType_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WH_TaxType_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WH_TaxType_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WH_TaxType_Cmbx.FormattingEnabled = true;
            this.WH_TaxType_Cmbx.Location = new System.Drawing.Point(105, 206);
            this.WH_TaxType_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.WH_TaxType_Cmbx.Name = "WH_TaxType_Cmbx";
            this.WH_TaxType_Cmbx.Size = new System.Drawing.Size(222, 21);
            this.WH_TaxType_Cmbx.TabIndex = 2;
            this.WH_TaxType_Cmbx.Tag = "WH_TaxType";
            // 
            // WH_TaxCategory_Cmbx
            // 
            this.WH_TaxCategory_Cmbx.AccessibleName = "";
            this.WH_TaxCategory_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WH_TaxCategory_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WH_TaxCategory_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WH_TaxCategory_Cmbx.FormattingEnabled = true;
            this.WH_TaxCategory_Cmbx.Location = new System.Drawing.Point(105, 169);
            this.WH_TaxCategory_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.WH_TaxCategory_Cmbx.Name = "WH_TaxCategory_Cmbx";
            this.WH_TaxCategory_Cmbx.Size = new System.Drawing.Size(222, 21);
            this.WH_TaxCategory_Cmbx.TabIndex = 1;
            this.WH_TaxCategory_Cmbx.Tag = "WH_TaxCategory";
            // 
            // WithholdtaxNumber_Txt
            // 
            this.WithholdtaxNumber_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WithholdtaxNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WithholdtaxNumber_Txt.Location = new System.Drawing.Point(124, 20);
            this.WithholdtaxNumber_Txt.Margin = new System.Windows.Forms.Padding(5);
            this.WithholdtaxNumber_Txt.Name = "WithholdtaxNumber_Txt";
            this.WithholdtaxNumber_Txt.Size = new System.Drawing.Size(203, 21);
            this.WithholdtaxNumber_Txt.TabIndex = 21;
            this.WithholdtaxNumber_Txt.TabStop = false;
            this.WithholdtaxNumber_Txt.Visible = false;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.White;
            this.RightPanel.Controls.Add(this.RightHeadPanel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(966, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(175, 460);
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
            this.RightHeadPanel.MaximumSize = new System.Drawing.Size(0, 200);
            this.RightHeadPanel.MinimumSize = new System.Drawing.Size(0, 200);
            this.RightHeadPanel.Name = "RightHeadPanel";
            this.RightHeadPanel.Padding = new System.Windows.Forms.Padding(15);
            this.RightHeadPanel.Size = new System.Drawing.Size(175, 200);
            this.RightHeadPanel.TabIndex = 197;
            // 
            // panel12
            // 
            this.panel12.AutoSize = true;
            this.panel12.Controls.Add(this.Btn_Clear);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(15, 52);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel12.Size = new System.Drawing.Size(145, 34);
            this.panel12.TabIndex = 195;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Clear.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Clear.Location = new System.Drawing.Point(0, 0);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(145, 24);
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
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(145, 24);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Update.Location = new System.Drawing.Point(0, 0);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(145, 24);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            // 
            // WithholdTax
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1149, 468);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WithholdTax";
            this.Text = "Withhold Tax";
            this.Load += new System.EventHandler(this.WithHoldTax_Load);
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

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.SplitContainer CreatePanel;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadGridView RGV_List;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Impact;
        private System.Windows.Forms.Label TaxCode;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox WH_TaxDescription_Txt_Special;
        private System.Windows.Forms.TextBox WH_TaxCode_Txt_Special;
        private System.Windows.Forms.ComboBox WH_TaxImpact_Cmbx;
        private System.Windows.Forms.ComboBox WH_TaxType_Cmbx;
        private System.Windows.Forms.ComboBox WH_TaxCategory_Cmbx;
        private System.Windows.Forms.TextBox WithholdtaxNumber_Txt;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel RightHeadPanel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Update;
    }
}