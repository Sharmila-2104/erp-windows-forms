namespace ERP.GeneralLedger.Master
{
    partial class TaxDesign
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
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.GV_TaxDesignNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_TaxCluster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_ClusterDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.PanelList = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GV_DetailsListEdit = new System.Windows.Forms.DataGridView();
            this.GVE_TaxClusterDetailsNumber_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVE_TaxDesignDetailsNumber_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVE_Index_Txt_Digit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVE_TaxElement_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVE_ElementDescription_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVE_LoadonInventory_Ckbx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GVE_LoadonInventoryPercent_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVE_TaxNature_Cmbx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVE_ChargeableBasis_Cmbx = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GVE_CalculationFactors_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_DetailsListAdd = new System.Windows.Forms.DataGridView();
            this.TaxClusterDetailsNumber_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxDesignDetailsNumber_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxElement_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElementDescription_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadonInventory_Ckbx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LoadonInventoryPercent_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxNature_Cmbx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChargeableBasis_Cmbx = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CalculationFactors_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Cluster = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.ClusterDescription_Txt = new System.Windows.Forms.TextBox();
            this.TaxCluster_Cmbx = new System.Windows.Forms.ComboBox();
            this.TaxDesignNumber_Txt = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.PanelAdd = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).BeginInit();
            this.PanelList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DetailsListEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DetailsListAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // GV_List
            // 
            this.GV_List.AllowUserToAddRows = false;
            this.GV_List.AllowUserToDeleteRows = false;
            this.GV_List.AllowUserToOrderColumns = true;
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
            this.GV_TaxDesignNumber,
            this.GV_TaxCluster,
            this.GV_ClusterDescription,
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
            this.GV_List.Location = new System.Drawing.Point(20, 18);
            this.GV_List.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.GV_List.Name = "GV_List";
            this.GV_List.ReadOnly = true;
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
            this.GV_List.Size = new System.Drawing.Size(1320, 159);
            this.GV_List.TabIndex = 9;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            // 
            // GV_TaxDesignNumber
            // 
            this.GV_TaxDesignNumber.DataPropertyName = "TaxDesignNumber";
            this.GV_TaxDesignNumber.HeaderText = "Tax Design Number";
            this.GV_TaxDesignNumber.Name = "GV_TaxDesignNumber";
            this.GV_TaxDesignNumber.ReadOnly = true;
            this.GV_TaxDesignNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GV_TaxDesignNumber.Visible = false;
            // 
            // GV_TaxCluster
            // 
            this.GV_TaxCluster.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_TaxCluster.DataPropertyName = "TaxCluster";
            this.GV_TaxCluster.HeaderText = "Cluster";
            this.GV_TaxCluster.Name = "GV_TaxCluster";
            this.GV_TaxCluster.ReadOnly = true;
            this.GV_TaxCluster.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GV_ClusterDescription
            // 
            this.GV_ClusterDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV_ClusterDescription.DataPropertyName = "ClusterDescription";
            this.GV_ClusterDescription.HeaderText = "Description";
            this.GV_ClusterDescription.Name = "GV_ClusterDescription";
            this.GV_ClusterDescription.ReadOnly = true;
            this.GV_ClusterDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::ERP.Properties.Resources.delete;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 60;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::ERP.Properties.Resources.edit;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 60;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::ERP.Properties.Resources.delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Edit";
            this.dataGridViewImageColumn2.Image = global::ERP.Properties.Resources.edit;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // Btn_Add
            // 
            this.Btn_Add.AllowDrop = true;
            this.Btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Add.Location = new System.Drawing.Point(1235, 13);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(110, 28);
            this.Btn_Add.TabIndex = 67;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // PanelList
            // 
            this.PanelList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelList.Controls.Add(this.panel2);
            this.PanelList.Controls.Add(this.panel1);
            this.PanelList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelList.Location = new System.Drawing.Point(0, 0);
            this.PanelList.Margin = new System.Windows.Forms.Padding(4);
            this.PanelList.Name = "PanelList";
            this.PanelList.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.PanelList.Size = new System.Drawing.Size(1390, 266);
            this.PanelList.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.GV_List);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(15, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panel2.Size = new System.Drawing.Size(1360, 195);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Btn_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 56);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Btn_Back);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(1003, 54);
            this.panel3.TabIndex = 10;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Location = new System.Drawing.Point(878, 17);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(110, 24);
            this.Btn_Back.TabIndex = 12;
            this.Btn_Back.Text = "Back To List";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Edit";
            this.dataGridViewImageColumn3.Image = global::ERP.Properties.Resources.edit;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.GV_DetailsListEdit);
            this.panel4.Controls.Add(this.GV_DetailsListAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 54);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15);
            this.panel4.Size = new System.Drawing.Size(1003, 323);
            this.panel4.TabIndex = 11;
            // 
            // GV_DetailsListEdit
            // 
            this.GV_DetailsListEdit.AllowUserToAddRows = false;
            this.GV_DetailsListEdit.BackgroundColor = System.Drawing.Color.White;
            this.GV_DetailsListEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GV_DetailsListEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_DetailsListEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GVE_TaxClusterDetailsNumber_Txt,
            this.GVE_TaxDesignDetailsNumber_Txt,
            this.GVE_Index_Txt_Digit,
            this.GVE_TaxElement_Txt,
            this.GVE_ElementDescription_Txt,
            this.GVE_LoadonInventory_Ckbx,
            this.GVE_LoadonInventoryPercent_Txt,
            this.GVE_TaxNature_Cmbx,
            this.GVE_ChargeableBasis_Cmbx,
            this.GVE_CalculationFactors_Txt});
            this.GV_DetailsListEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.GV_DetailsListEdit.Location = new System.Drawing.Point(15, 165);
            this.GV_DetailsListEdit.Margin = new System.Windows.Forms.Padding(4);
            this.GV_DetailsListEdit.Name = "GV_DetailsListEdit";
            this.GV_DetailsListEdit.Size = new System.Drawing.Size(973, 150);
            this.GV_DetailsListEdit.TabIndex = 4;
            // 
            // GVE_TaxClusterDetailsNumber_Txt
            // 
            this.GVE_TaxClusterDetailsNumber_Txt.DataPropertyName = "TaxClusterDetailsNumber";
            this.GVE_TaxClusterDetailsNumber_Txt.HeaderText = "Tax Cluster Details Number";
            this.GVE_TaxClusterDetailsNumber_Txt.Name = "GVE_TaxClusterDetailsNumber_Txt";
            this.GVE_TaxClusterDetailsNumber_Txt.Visible = false;
            // 
            // GVE_TaxDesignDetailsNumber_Txt
            // 
            this.GVE_TaxDesignDetailsNumber_Txt.DataPropertyName = "TaxDesignDetailsNumber";
            this.GVE_TaxDesignDetailsNumber_Txt.HeaderText = "Tax Design Details Number";
            this.GVE_TaxDesignDetailsNumber_Txt.Name = "GVE_TaxDesignDetailsNumber_Txt";
            this.GVE_TaxDesignDetailsNumber_Txt.Visible = false;
            // 
            // GVE_Index_Txt_Digit
            // 
            this.GVE_Index_Txt_Digit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GVE_Index_Txt_Digit.DataPropertyName = "Index";
            this.GVE_Index_Txt_Digit.FillWeight = 78.23604F;
            this.GVE_Index_Txt_Digit.HeaderText = "Index";
            this.GVE_Index_Txt_Digit.Name = "GVE_Index_Txt_Digit";
            // 
            // GVE_TaxElement_Txt
            // 
            this.GVE_TaxElement_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GVE_TaxElement_Txt.DataPropertyName = "TaxElement";
            this.GVE_TaxElement_Txt.FillWeight = 78.23604F;
            this.GVE_TaxElement_Txt.HeaderText = "Tax Element";
            this.GVE_TaxElement_Txt.Name = "GVE_TaxElement_Txt";
            this.GVE_TaxElement_Txt.ReadOnly = true;
            this.GVE_TaxElement_Txt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GVE_ElementDescription_Txt
            // 
            this.GVE_ElementDescription_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GVE_ElementDescription_Txt.DataPropertyName = "ElementDescription";
            this.GVE_ElementDescription_Txt.FillWeight = 78.23604F;
            this.GVE_ElementDescription_Txt.HeaderText = "Description";
            this.GVE_ElementDescription_Txt.Name = "GVE_ElementDescription_Txt";
            this.GVE_ElementDescription_Txt.ReadOnly = true;
            // 
            // GVE_LoadonInventory_Ckbx
            // 
            this.GVE_LoadonInventory_Ckbx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GVE_LoadonInventory_Ckbx.DataPropertyName = "LoadonInventory";
            this.GVE_LoadonInventory_Ckbx.FillWeight = 78.23604F;
            this.GVE_LoadonInventory_Ckbx.HeaderText = "Load on Inventory";
            this.GVE_LoadonInventory_Ckbx.Name = "GVE_LoadonInventory_Ckbx";
            this.GVE_LoadonInventory_Ckbx.ReadOnly = true;
            this.GVE_LoadonInventory_Ckbx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GVE_LoadonInventory_Ckbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GVE_LoadonInventoryPercent_Txt
            // 
            this.GVE_LoadonInventoryPercent_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GVE_LoadonInventoryPercent_Txt.DataPropertyName = "LoadonInventoryPercent";
            this.GVE_LoadonInventoryPercent_Txt.FillWeight = 78.23604F;
            this.GVE_LoadonInventoryPercent_Txt.HeaderText = "Load on Inventory %";
            this.GVE_LoadonInventoryPercent_Txt.Name = "GVE_LoadonInventoryPercent_Txt";
            this.GVE_LoadonInventoryPercent_Txt.ReadOnly = true;
            this.GVE_LoadonInventoryPercent_Txt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GVE_TaxNature_Cmbx
            // 
            this.GVE_TaxNature_Cmbx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GVE_TaxNature_Cmbx.DataPropertyName = "TaxNature";
            this.GVE_TaxNature_Cmbx.FillWeight = 78.23604F;
            this.GVE_TaxNature_Cmbx.HeaderText = "Tax Nature";
            this.GVE_TaxNature_Cmbx.Name = "GVE_TaxNature_Cmbx";
            this.GVE_TaxNature_Cmbx.ReadOnly = true;
            this.GVE_TaxNature_Cmbx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GVE_TaxNature_Cmbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GVE_ChargeableBasis_Cmbx
            // 
            this.GVE_ChargeableBasis_Cmbx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GVE_ChargeableBasis_Cmbx.DataPropertyName = "ChargeableBasis";
            this.GVE_ChargeableBasis_Cmbx.FillWeight = 78.23604F;
            this.GVE_ChargeableBasis_Cmbx.HeaderText = "Chargeable Basis";
            this.GVE_ChargeableBasis_Cmbx.Name = "GVE_ChargeableBasis_Cmbx";
            // 
            // GVE_CalculationFactors_Txt
            // 
            this.GVE_CalculationFactors_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GVE_CalculationFactors_Txt.DataPropertyName = "CalculationFactors";
            this.GVE_CalculationFactors_Txt.FillWeight = 78.23604F;
            this.GVE_CalculationFactors_Txt.HeaderText = "Calculation Factors";
            this.GVE_CalculationFactors_Txt.Name = "GVE_CalculationFactors_Txt";
            // 
            // GV_DetailsListAdd
            // 
            this.GV_DetailsListAdd.AllowUserToAddRows = false;
            this.GV_DetailsListAdd.BackgroundColor = System.Drawing.Color.White;
            this.GV_DetailsListAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GV_DetailsListAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_DetailsListAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaxClusterDetailsNumber_Txt,
            this.TaxDesignDetailsNumber_Txt,
            this.Index_Txt,
            this.TaxElement_Txt,
            this.ElementDescription_Txt,
            this.LoadonInventory_Ckbx,
            this.LoadonInventoryPercent_Txt,
            this.TaxNature_Cmbx,
            this.ChargeableBasis_Cmbx,
            this.CalculationFactors_Txt});
            this.GV_DetailsListAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.GV_DetailsListAdd.Location = new System.Drawing.Point(15, 15);
            this.GV_DetailsListAdd.Margin = new System.Windows.Forms.Padding(4);
            this.GV_DetailsListAdd.Name = "GV_DetailsListAdd";
            this.GV_DetailsListAdd.Size = new System.Drawing.Size(973, 150);
            this.GV_DetailsListAdd.TabIndex = 3;
            this.GV_DetailsListAdd.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GV_DetailsList_DataError);
            // 
            // TaxClusterDetailsNumber_Txt
            // 
            this.TaxClusterDetailsNumber_Txt.DataPropertyName = "TaxClusterDetailsNumber";
            this.TaxClusterDetailsNumber_Txt.HeaderText = "Tax Cluster Details Number";
            this.TaxClusterDetailsNumber_Txt.Name = "TaxClusterDetailsNumber_Txt";
            this.TaxClusterDetailsNumber_Txt.Visible = false;
            // 
            // TaxDesignDetailsNumber_Txt
            // 
            this.TaxDesignDetailsNumber_Txt.DataPropertyName = "TaxDesignDetailsNumber";
            this.TaxDesignDetailsNumber_Txt.HeaderText = "Tax Design Details Number";
            this.TaxDesignDetailsNumber_Txt.Name = "TaxDesignDetailsNumber_Txt";
            this.TaxDesignDetailsNumber_Txt.Visible = false;
            // 
            // Index_Txt
            // 
            this.Index_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Index_Txt.DataPropertyName = "Indexs";
            this.Index_Txt.FillWeight = 78.23604F;
            this.Index_Txt.HeaderText = "Index";
            this.Index_Txt.Name = "Index_Txt";
            // 
            // TaxElement_Txt
            // 
            this.TaxElement_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaxElement_Txt.DataPropertyName = "TaxElement";
            this.TaxElement_Txt.FillWeight = 78.23604F;
            this.TaxElement_Txt.HeaderText = "Tax Element";
            this.TaxElement_Txt.Name = "TaxElement_Txt";
            this.TaxElement_Txt.ReadOnly = true;
            this.TaxElement_Txt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ElementDescription_Txt
            // 
            this.ElementDescription_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ElementDescription_Txt.DataPropertyName = "ElementDescription";
            this.ElementDescription_Txt.FillWeight = 78.23604F;
            this.ElementDescription_Txt.HeaderText = "Description";
            this.ElementDescription_Txt.Name = "ElementDescription_Txt";
            this.ElementDescription_Txt.ReadOnly = true;
            // 
            // LoadonInventory_Ckbx
            // 
            this.LoadonInventory_Ckbx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoadonInventory_Ckbx.DataPropertyName = "LoadonInventory";
            this.LoadonInventory_Ckbx.FillWeight = 78.23604F;
            this.LoadonInventory_Ckbx.HeaderText = "Load on Inventory";
            this.LoadonInventory_Ckbx.Name = "LoadonInventory_Ckbx";
            this.LoadonInventory_Ckbx.ReadOnly = true;
            this.LoadonInventory_Ckbx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoadonInventory_Ckbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LoadonInventoryPercent_Txt
            // 
            this.LoadonInventoryPercent_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoadonInventoryPercent_Txt.DataPropertyName = "LoadonInventoryPercent";
            this.LoadonInventoryPercent_Txt.FillWeight = 78.23604F;
            this.LoadonInventoryPercent_Txt.HeaderText = "Load on Inventory %";
            this.LoadonInventoryPercent_Txt.Name = "LoadonInventoryPercent_Txt";
            this.LoadonInventoryPercent_Txt.ReadOnly = true;
            this.LoadonInventoryPercent_Txt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TaxNature_Cmbx
            // 
            this.TaxNature_Cmbx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaxNature_Cmbx.DataPropertyName = "TaxNature";
            this.TaxNature_Cmbx.FillWeight = 78.23604F;
            this.TaxNature_Cmbx.HeaderText = "Tax Nature";
            this.TaxNature_Cmbx.Name = "TaxNature_Cmbx";
            this.TaxNature_Cmbx.ReadOnly = true;
            this.TaxNature_Cmbx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TaxNature_Cmbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ChargeableBasis_Cmbx
            // 
            this.ChargeableBasis_Cmbx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChargeableBasis_Cmbx.DataPropertyName = "ChargeableBasis";
            this.ChargeableBasis_Cmbx.FillWeight = 78.23604F;
            this.ChargeableBasis_Cmbx.HeaderText = "Chargeable Basis";
            this.ChargeableBasis_Cmbx.Name = "ChargeableBasis_Cmbx";
            // 
            // CalculationFactors_Txt
            // 
            this.CalculationFactors_Txt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CalculationFactors_Txt.DataPropertyName = "CalculationFactors";
            this.CalculationFactors_Txt.FillWeight = 78.23604F;
            this.CalculationFactors_Txt.HeaderText = "Calculation Factors";
            this.CalculationFactors_Txt.Name = "CalculationFactors_Txt";
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Delete";
            this.dataGridViewImageColumn4.Image = global::ERP.Properties.Resources.delete;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(15, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
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
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(1360, 377);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.Cluster);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.ClusterDescription_Txt);
            this.groupBox1.Controls.Add(this.TaxCluster_Cmbx);
            this.groupBox1.Controls.Add(this.TaxDesignNumber_Txt);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(320, 347);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax Design";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Clear.FlatAppearance.BorderSize = 0;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Clear.Location = new System.Drawing.Point(186, 243);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Btn_Clear.Size = new System.Drawing.Size(63, 36);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Update.Location = new System.Drawing.Point(109, 243);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_Update.Size = new System.Drawing.Size(63, 36);
            this.Btn_Update.TabIndex = 5;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Cluster
            // 
            this.Cluster.AutoSize = true;
            this.Cluster.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cluster.Location = new System.Drawing.Point(17, 83);
            this.Cluster.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Cluster.Name = "Cluster";
            this.Cluster.Size = new System.Drawing.Size(80, 16);
            this.Cluster.TabIndex = 32;
            this.Cluster.Text = "Tax Cluster";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(17, 136);
            this.Description.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(80, 16);
            this.Description.TabIndex = 31;
            this.Description.Text = "Description";
            // 
            // ClusterDescription_Txt
            // 
            this.ClusterDescription_Txt.AccessibleName = "";
            this.ClusterDescription_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClusterDescription_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClusterDescription_Txt.Location = new System.Drawing.Point(109, 136);
            this.ClusterDescription_Txt.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ClusterDescription_Txt.MaxLength = 50;
            this.ClusterDescription_Txt.Multiline = true;
            this.ClusterDescription_Txt.Name = "ClusterDescription_Txt";
            this.ClusterDescription_Txt.ReadOnly = true;
            this.ClusterDescription_Txt.Size = new System.Drawing.Size(193, 89);
            this.ClusterDescription_Txt.TabIndex = 2;
            this.ClusterDescription_Txt.Tag = "ClusterDescription";
            // 
            // TaxCluster_Cmbx
            // 
            this.TaxCluster_Cmbx.AccessibleName = "";
            this.TaxCluster_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxCluster_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaxCluster_Cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TaxCluster_Cmbx.FormattingEnabled = true;
            this.TaxCluster_Cmbx.Location = new System.Drawing.Point(109, 82);
            this.TaxCluster_Cmbx.Margin = new System.Windows.Forms.Padding(5);
            this.TaxCluster_Cmbx.Name = "TaxCluster_Cmbx";
            this.TaxCluster_Cmbx.Size = new System.Drawing.Size(194, 24);
            this.TaxCluster_Cmbx.TabIndex = 1;
            this.TaxCluster_Cmbx.Tag = "TaxCluster";
            this.TaxCluster_Cmbx.SelectionChangeCommitted += new System.EventHandler(this.TaxCluster_Cmbx_SelectionChangeCommitted);
            // 
            // TaxDesignNumber_Txt
            // 
            this.TaxDesignNumber_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxDesignNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxDesignNumber_Txt.Location = new System.Drawing.Point(116, 27);
            this.TaxDesignNumber_Txt.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TaxDesignNumber_Txt.Name = "TaxDesignNumber_Txt";
            this.TaxDesignNumber_Txt.Size = new System.Drawing.Size(186, 23);
            this.TaxDesignNumber_Txt.TabIndex = 21;
            this.TaxDesignNumber_Txt.Visible = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Save.FlatAppearance.BorderSize = 0;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Save.Location = new System.Drawing.Point(109, 243);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Btn_Save.Size = new System.Drawing.Size(63, 36);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelAdd.Controls.Add(this.splitContainer1);
            this.PanelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAdd.Location = new System.Drawing.Point(0, 266);
            this.PanelAdd.Margin = new System.Windows.Forms.Padding(5);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.PanelAdd.Size = new System.Drawing.Size(1390, 392);
            this.PanelAdd.TabIndex = 69;
            // 
            // TaxDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 658);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.PanelList);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaxDesign";
            this.Text = "Tax Design";
            this.Load += new System.EventHandler(this.TaxDesign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).EndInit();
            this.PanelList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_DetailsListEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DetailsListAdd)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Panel PanelList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Label Cluster;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox ClusterDescription_Txt;
        private System.Windows.Forms.ComboBox TaxCluster_Cmbx;
        private System.Windows.Forms.TextBox TaxDesignNumber_Txt;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.DataGridView GV_DetailsListAdd;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_TaxDesignNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_TaxCluster;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_ClusterDescription;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridView GV_DetailsListEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVE_TaxClusterDetailsNumber_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVE_TaxDesignDetailsNumber_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVE_Index_Txt_Digit;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVE_TaxElement_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVE_ElementDescription_Txt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GVE_LoadonInventory_Ckbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVE_LoadonInventoryPercent_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVE_TaxNature_Cmbx;
        private System.Windows.Forms.DataGridViewComboBoxColumn GVE_ChargeableBasis_Cmbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVE_CalculationFactors_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxClusterDetailsNumber_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxDesignDetailsNumber_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxElement_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementDescription_Txt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LoadonInventory_Ckbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoadonInventoryPercent_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxNature_Cmbx;
        private System.Windows.Forms.DataGridViewComboBoxColumn ChargeableBasis_Cmbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculationFactors_Txt;
    }
}