namespace ERP.Purchase.Tax.Master
{
    partial class TaxSetup
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
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.GV_TaxSetupNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_TaxElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_ElementDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_TaxNature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Btn_AddNew = new System.Windows.Forms.Button();
            this.PanelList = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadonInventory_Ckbx = new System.Windows.Forms.CheckBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.TaxNature = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadonInventoryPercent_Txt_Decimal = new System.Windows.Forms.TextBox();
            this.ElementDescription_Txt = new System.Windows.Forms.TextBox();
            this.TaxNature_Cmbx = new System.Windows.Forms.ComboBox();
            this.Clus = new System.Windows.Forms.Label();
            this.TaxElement_Cmbx = new System.Windows.Forms.ComboBox();
            this.TaxSetupNumber_Txt = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GV_DetailsList = new System.Windows.Forms.DataGridView();
            this.TaxSetupDetailsNumber_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDate_Dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDate_Dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxNature_GvCmbx = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FixedPercent_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSN_Cmbx = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HSN_Percent_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAC_Cmbx = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SAC_Percent_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abatement_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).BeginInit();
            this.PanelList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DetailsList)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::ERP.Properties.Resources.delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Edit";
            this.dataGridViewImageColumn2.Image = global::ERP.Properties.Resources.edit;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // GV_List
            // 
            this.GV_List.AllowUserToAddRows = false;
            this.GV_List.BackgroundColor = System.Drawing.Color.White;
            this.GV_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GV_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
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
            this.GV_TaxSetupNumber,
            this.GV_TaxElement,
            this.GV_ElementDescription,
            this.GV_TaxNature,
            this.Delete,
            this.Edit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GV_List.DefaultCellStyle = dataGridViewCellStyle2;
            this.GV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_List.GridColor = System.Drawing.Color.LightGray;
            this.GV_List.Location = new System.Drawing.Point(15, 15);
            this.GV_List.Margin = new System.Windows.Forms.Padding(5);
            this.GV_List.Name = "GV_List";
            this.GV_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Silver;
            this.GV_List.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GV_List.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GV_List.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GV_List.RowTemplate.Height = 30;
            this.GV_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_List.Size = new System.Drawing.Size(1210, 106);
            this.GV_List.TabIndex = 9;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            // 
            // GV_TaxSetupNumber
            // 
            this.GV_TaxSetupNumber.DataPropertyName = "TaxSetupNumber";
            this.GV_TaxSetupNumber.HeaderText = "Tax Setup Number";
            this.GV_TaxSetupNumber.Name = "GV_TaxSetupNumber";
            this.GV_TaxSetupNumber.ReadOnly = true;
            this.GV_TaxSetupNumber.Visible = false;
            // 
            // GV_TaxElement
            // 
            this.GV_TaxElement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_TaxElement.DataPropertyName = "TaxElement";
            this.GV_TaxElement.HeaderText = "Tax Element";
            this.GV_TaxElement.Name = "GV_TaxElement";
            // 
            // GV_ElementDescription
            // 
            this.GV_ElementDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_ElementDescription.DataPropertyName = "ElementDescription";
            this.GV_ElementDescription.HeaderText = "Description";
            this.GV_ElementDescription.Name = "GV_ElementDescription";
            // 
            // GV_TaxNature
            // 
            this.GV_TaxNature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_TaxNature.DataPropertyName = "TaxNature";
            this.GV_TaxNature.HeaderText = "Tax Nature";
            this.GV_TaxNature.Name = "GV_TaxNature";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::ERP.Properties.Resources.delete;
            this.Delete.Name = "Delete";
            this.Delete.Width = 60;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::ERP.Properties.Resources.edit;
            this.Edit.Name = "Edit";
            this.Edit.Width = 60;
            // 
            // Btn_AddNew
            // 
            this.Btn_AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AddNew.Location = new System.Drawing.Point(1107, 13);
            this.Btn_AddNew.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AddNew.Name = "Btn_AddNew";
            this.Btn_AddNew.Size = new System.Drawing.Size(100, 28);
            this.Btn_AddNew.TabIndex = 27;
            this.Btn_AddNew.Text = "Add";
            this.Btn_AddNew.UseVisualStyleBackColor = true;
            this.Btn_AddNew.Click += new System.EventHandler(this.Btn_AddNew_Click);
            // 
            // PanelList
            // 
            this.PanelList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelList.Controls.Add(this.panel2);
            this.PanelList.Controls.Add(this.panel1);
            this.PanelList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelList.Location = new System.Drawing.Point(0, 0);
            this.PanelList.Name = "PanelList";
            this.PanelList.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.PanelList.Size = new System.Drawing.Size(1270, 198);
            this.PanelList.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.GV_List);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(15, 47);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(1240, 136);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Btn_AddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 47);
            this.panel1.TabIndex = 0;
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelAdd.Controls.Add(this.splitContainer1);
            this.PanelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAdd.Location = new System.Drawing.Point(0, 198);
            this.PanelAdd.Margin = new System.Windows.Forms.Padding(4);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.PanelAdd.Size = new System.Drawing.Size(1270, 544);
            this.PanelAdd.TabIndex = 0;
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
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 529);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoadonInventory_Ckbx);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.TaxNature);
            this.groupBox1.Controls.Add(this.Inventory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LoadonInventoryPercent_Txt_Decimal);
            this.groupBox1.Controls.Add(this.ElementDescription_Txt);
            this.groupBox1.Controls.Add(this.TaxNature_Cmbx);
            this.groupBox1.Controls.Add(this.Clus);
            this.groupBox1.Controls.Add(this.TaxElement_Cmbx);
            this.groupBox1.Controls.Add(this.TaxSetupNumber_Txt);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Division);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(320, 499);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax Setup";
            // 
            // LoadonInventory_Ckbx
            // 
            this.LoadonInventory_Ckbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadonInventory_Ckbx.AutoSize = true;
            this.LoadonInventory_Ckbx.Location = new System.Drawing.Point(111, 212);
            this.LoadonInventory_Ckbx.Margin = new System.Windows.Forms.Padding(4);
            this.LoadonInventory_Ckbx.Name = "LoadonInventory_Ckbx";
            this.LoadonInventory_Ckbx.Size = new System.Drawing.Size(15, 14);
            this.LoadonInventory_Ckbx.TabIndex = 3;
            this.LoadonInventory_Ckbx.Tag = "";
            this.LoadonInventory_Ckbx.UseVisualStyleBackColor = true;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Clear.FlatAppearance.BorderSize = 0;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Clear.Location = new System.Drawing.Point(203, 365);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Btn_Clear.Size = new System.Drawing.Size(69, 36);
            this.Btn_Clear.TabIndex = 9;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // TaxNature
            // 
            this.TaxNature.AutoSize = true;
            this.TaxNature.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxNature.Location = new System.Drawing.Point(23, 310);
            this.TaxNature.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TaxNature.Name = "TaxNature";
            this.TaxNature.Size = new System.Drawing.Size(78, 16);
            this.TaxNature.TabIndex = 30;
            this.TaxNature.Text = "Tax Nature";
            // 
            // Inventory
            // 
            this.Inventory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.Location = new System.Drawing.Point(17, 202);
            this.Inventory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(84, 33);
            this.Inventory.TabIndex = 29;
            this.Inventory.Text = "Load on Inventory";
            this.Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Description";
            // 
            // LoadonInventoryPercent_Txt_Decimal
            // 
            this.LoadonInventoryPercent_Txt_Decimal.AccessibleName = "";
            this.LoadonInventoryPercent_Txt_Decimal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadonInventoryPercent_Txt_Decimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadonInventoryPercent_Txt_Decimal.Location = new System.Drawing.Point(111, 254);
            this.LoadonInventoryPercent_Txt_Decimal.Margin = new System.Windows.Forms.Padding(5);
            this.LoadonInventoryPercent_Txt_Decimal.Name = "LoadonInventoryPercent_Txt_Decimal";
            this.LoadonInventoryPercent_Txt_Decimal.Size = new System.Drawing.Size(189, 23);
            this.LoadonInventoryPercent_Txt_Decimal.TabIndex = 4;
            this.LoadonInventoryPercent_Txt_Decimal.Tag = "LoadonInventoryPercent";
            // 
            // ElementDescription_Txt
            // 
            this.ElementDescription_Txt.AccessibleName = "";
            this.ElementDescription_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElementDescription_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ElementDescription_Txt.Location = new System.Drawing.Point(111, 127);
            this.ElementDescription_Txt.Margin = new System.Windows.Forms.Padding(5);
            this.ElementDescription_Txt.Multiline = true;
            this.ElementDescription_Txt.Name = "ElementDescription_Txt";
            this.ElementDescription_Txt.ReadOnly = true;
            this.ElementDescription_Txt.Size = new System.Drawing.Size(189, 52);
            this.ElementDescription_Txt.TabIndex = 2;
            this.ElementDescription_Txt.Tag = "ElementDescription";
            // 
            // TaxNature_Cmbx
            // 
            this.TaxNature_Cmbx.AccessibleName = "";
            this.TaxNature_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxNature_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaxNature_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TaxNature_Cmbx.FormattingEnabled = true;
            this.TaxNature_Cmbx.Location = new System.Drawing.Point(111, 310);
            this.TaxNature_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.TaxNature_Cmbx.Name = "TaxNature_Cmbx";
            this.TaxNature_Cmbx.Size = new System.Drawing.Size(189, 24);
            this.TaxNature_Cmbx.TabIndex = 5;
            this.TaxNature_Cmbx.Tag = "TaxNature";
            // 
            // Clus
            // 
            this.Clus.AutoSize = true;
            this.Clus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clus.Location = new System.Drawing.Point(15, 73);
            this.Clus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Clus.Name = "Clus";
            this.Clus.Size = new System.Drawing.Size(86, 16);
            this.Clus.TabIndex = 23;
            this.Clus.Text = "Tax Element";
            // 
            // TaxElement_Cmbx
            // 
            this.TaxElement_Cmbx.AccessibleName = "";
            this.TaxElement_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxElement_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaxElement_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TaxElement_Cmbx.FormattingEnabled = true;
            this.TaxElement_Cmbx.Location = new System.Drawing.Point(111, 72);
            this.TaxElement_Cmbx.Margin = new System.Windows.Forms.Padding(4);
            this.TaxElement_Cmbx.Name = "TaxElement_Cmbx";
            this.TaxElement_Cmbx.Size = new System.Drawing.Size(189, 24);
            this.TaxElement_Cmbx.TabIndex = 1;
            this.TaxElement_Cmbx.Tag = "TaxElement";
            this.TaxElement_Cmbx.SelectionChangeCommitted += new System.EventHandler(this.TaxElement_Cmbx_SelectionChangeCommitted);
            // 
            // TaxSetupNumber_Txt
            // 
            this.TaxSetupNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxSetupNumber_Txt.Location = new System.Drawing.Point(111, 22);
            this.TaxSetupNumber_Txt.Margin = new System.Windows.Forms.Padding(5);
            this.TaxSetupNumber_Txt.Name = "TaxSetupNumber_Txt";
            this.TaxSetupNumber_Txt.Size = new System.Drawing.Size(189, 23);
            this.TaxSetupNumber_Txt.TabIndex = 21;
            this.TaxSetupNumber_Txt.TabStop = false;
            this.TaxSetupNumber_Txt.Visible = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Update.Location = new System.Drawing.Point(111, 365);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Update.Size = new System.Drawing.Size(69, 36);
            this.Btn_Update.TabIndex = 8;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Save.FlatAppearance.BorderSize = 0;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Save.Location = new System.Drawing.Point(111, 365);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Btn_Save.Size = new System.Drawing.Size(69, 36);
            this.Btn_Save.TabIndex = 7;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Division
            // 
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Division.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Division.Location = new System.Drawing.Point(5, 254);
            this.Division.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Division.Name = "Division";
            this.Division.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Division.Size = new System.Drawing.Size(96, 32);
            this.Division.TabIndex = 15;
            this.Division.Text = "Load on Inventory %";
            this.Division.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Division.UseMnemonic = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.GV_DetailsList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(15, 60);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15);
            this.panel4.Size = new System.Drawing.Size(870, 469);
            this.panel4.TabIndex = 11;
            // 
            // GV_DetailsList
            // 
            this.GV_DetailsList.BackgroundColor = System.Drawing.Color.White;
            this.GV_DetailsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GV_DetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_DetailsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaxSetupDetailsNumber_Txt,
            this.FromDate_Dt,
            this.ToDate_Dt,
            this.TaxNature_GvCmbx,
            this.FixedPercent_Txt,
            this.HSN_Cmbx,
            this.HSN_Percent_Txt,
            this.SAC_Cmbx,
            this.SAC_Percent_Txt,
            this.Abatement_Txt,
            this.DeleteColumn});
            this.GV_DetailsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_DetailsList.Location = new System.Drawing.Point(15, 15);
            this.GV_DetailsList.Margin = new System.Windows.Forms.Padding(4);
            this.GV_DetailsList.Name = "GV_DetailsList";
            this.GV_DetailsList.Size = new System.Drawing.Size(840, 439);
            this.GV_DetailsList.TabIndex = 6;
            this.GV_DetailsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_DetailsList_CellClick);
            this.GV_DetailsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_DetailsList_CellContentClick);
            this.GV_DetailsList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GV_DetailsList_DataError);
            // 
            // TaxSetupDetailsNumber_Txt
            // 
            this.TaxSetupDetailsNumber_Txt.DataPropertyName = "TaxSetupDetailsNumber";
            this.TaxSetupDetailsNumber_Txt.HeaderText = "Tax Setup Details Number";
            this.TaxSetupDetailsNumber_Txt.Name = "TaxSetupDetailsNumber_Txt";
            this.TaxSetupDetailsNumber_Txt.Visible = false;
            // 
            // FromDate_Dt
            // 
            this.FromDate_Dt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FromDate_Dt.DataPropertyName = "FromDate";
            this.FromDate_Dt.FillWeight = 77.27016F;
            this.FromDate_Dt.HeaderText = "From Date";
            this.FromDate_Dt.Name = "FromDate_Dt";
            // 
            // ToDate_Dt
            // 
            this.ToDate_Dt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToDate_Dt.DataPropertyName = "ToDate";
            this.ToDate_Dt.FillWeight = 77.27016F;
            this.ToDate_Dt.HeaderText = "To Date";
            this.ToDate_Dt.Name = "ToDate_Dt";
            this.ToDate_Dt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TaxNature_GvCmbx
            // 
            this.TaxNature_GvCmbx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaxNature_GvCmbx.DataPropertyName = "GvTaxNature";
            this.TaxNature_GvCmbx.FillWeight = 77.27016F;
            this.TaxNature_GvCmbx.HeaderText = "Tax Nature";
            this.TaxNature_GvCmbx.Name = "TaxNature_GvCmbx";
            this.TaxNature_GvCmbx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TaxNature_GvCmbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FixedPercent_Txt
            // 
            this.FixedPercent_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FixedPercent_Txt.DataPropertyName = "FixedPercent";
            this.FixedPercent_Txt.FillWeight = 77.27016F;
            this.FixedPercent_Txt.HeaderText = "Fixed Percent";
            this.FixedPercent_Txt.Name = "FixedPercent_Txt";
            // 
            // HSN_Cmbx
            // 
            this.HSN_Cmbx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HSN_Cmbx.DataPropertyName = "HSN";
            this.HSN_Cmbx.FillWeight = 77.27016F;
            this.HSN_Cmbx.HeaderText = "HSN";
            this.HSN_Cmbx.Name = "HSN_Cmbx";
            this.HSN_Cmbx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HSN_Cmbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HSN_Percent_Txt
            // 
            this.HSN_Percent_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HSN_Percent_Txt.DataPropertyName = "HSN_Percent";
            this.HSN_Percent_Txt.FillWeight = 77.27016F;
            this.HSN_Percent_Txt.HeaderText = "HSN Percent";
            this.HSN_Percent_Txt.Name = "HSN_Percent_Txt";
            // 
            // SAC_Cmbx
            // 
            this.SAC_Cmbx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SAC_Cmbx.DataPropertyName = "SAC";
            this.SAC_Cmbx.FillWeight = 77.27016F;
            this.SAC_Cmbx.HeaderText = "SAC";
            this.SAC_Cmbx.Name = "SAC_Cmbx";
            this.SAC_Cmbx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SAC_Cmbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SAC_Percent_Txt
            // 
            this.SAC_Percent_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SAC_Percent_Txt.DataPropertyName = "SAC_Percent";
            this.SAC_Percent_Txt.FillWeight = 77.27016F;
            this.SAC_Percent_Txt.HeaderText = "SAC Percent";
            this.SAC_Percent_Txt.Name = "SAC_Percent_Txt";
            // 
            // Abatement_Txt
            // 
            this.Abatement_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Abatement_Txt.DataPropertyName = "Abatement";
            this.Abatement_Txt.FillWeight = 77.27016F;
            this.Abatement_Txt.HeaderText = "Abatement %";
            this.Abatement_Txt.Name = "Abatement_Txt";
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.FillWeight = 304.5685F;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Image = global::ERP.Properties.Resources.delete;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Width = 60;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.Btn_Back);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(15, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(15);
            this.panel5.Size = new System.Drawing.Size(870, 60);
            this.panel5.TabIndex = 10;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Location = new System.Drawing.Point(745, 18);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(110, 24);
            this.Btn_Back.TabIndex = 10;
            this.Btn_Back.TabStop = false;
            this.Btn_Back.Text = "Back To List";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // TaxSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 742);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.PanelList);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaxSetup";
            this.Text = "Tax Setup";
            this.Load += new System.EventHandler(this.TaxSetUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).EndInit();
            this.PanelList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelAdd.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_DetailsList)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.Button Btn_AddNew;
        private System.Windows.Forms.Panel PanelList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LoadonInventory_Ckbx;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label TaxNature;
        private System.Windows.Forms.Label Inventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoadonInventoryPercent_Txt_Decimal;
        private System.Windows.Forms.TextBox ElementDescription_Txt;
        private System.Windows.Forms.ComboBox TaxNature_Cmbx;
        private System.Windows.Forms.Label Clus;
        private System.Windows.Forms.ComboBox TaxElement_Cmbx;
        private System.Windows.Forms.TextBox TaxSetupNumber_Txt;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Division;
        private System.Windows.Forms.DataGridView GV_DetailsList;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_TaxSetupNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_TaxElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ElementDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_TaxNature;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxSetupDetailsNumber_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDate_Dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDate_Dt;
        private System.Windows.Forms.DataGridViewComboBoxColumn TaxNature_GvCmbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixedPercent_Txt;
        private System.Windows.Forms.DataGridViewComboBoxColumn HSN_Cmbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSN_Percent_Txt;
        private System.Windows.Forms.DataGridViewComboBoxColumn SAC_Cmbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAC_Percent_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abatement_Txt;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
    }
}