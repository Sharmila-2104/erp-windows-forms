namespace ERP.GeneralLedger.Master
{
    partial class TaxDesignAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GV_DetailsList = new System.Windows.Forms.DataGridView();
            this.ClusterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxDesignDetailsNumber_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxElement_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElementDescription_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadonInventory_Ckbx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LoadonInventoryPercent_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxNature_Cmbx = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ChargeableBasis_Cmbx = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CalculationFactors_Txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Cluster = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.ClusterDescription_Txt = new System.Windows.Forms.TextBox();
            this.TaxCluster_Cmbx = new System.Windows.Forms.ComboBox();
            this.Txt_Number = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_DetailsList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GV_DetailsList);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 18);
            this.panel1.Size = new System.Drawing.Size(1067, 635);
            this.panel1.TabIndex = 0;
            // 
            // GV_DetailsList
            // 
            this.GV_DetailsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GV_DetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_DetailsList.BackgroundColor = System.Drawing.Color.White;
            this.GV_DetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_DetailsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClusterNumber,
            this.TaxDesignDetailsNumber_Txt,
            this.Index_Txt,
            this.TaxElement_Txt,
            this.ElementDescription_Txt,
            this.LoadonInventory_Ckbx,
            this.LoadonInventoryPercent_Txt,
            this.TaxNature_Cmbx,
            this.ChargeableBasis_Cmbx,
            this.CalculationFactors_Txt,
            this.DeleteColumn});
            this.GV_DetailsList.Location = new System.Drawing.Point(97, 347);
            this.GV_DetailsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GV_DetailsList.Name = "GV_DetailsList";
            this.GV_DetailsList.Size = new System.Drawing.Size(852, 252);
            this.GV_DetailsList.TabIndex = 3;
            // 
            // ClusterNumber
            // 
            this.ClusterNumber.DataPropertyName = "DNumber";
            this.ClusterNumber.HeaderText = "Tax Cluster Details Number";
            this.ClusterNumber.Name = "ClusterNumber";
            this.ClusterNumber.Visible = false;
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
            this.Index_Txt.DataPropertyName = "Index";
            this.Index_Txt.HeaderText = "Index";
            this.Index_Txt.Name = "Index_Txt";
            // 
            // TaxElement_Txt
            // 
            this.TaxElement_Txt.DataPropertyName = "TaxElement";
            this.TaxElement_Txt.HeaderText = "Tax Element";
            this.TaxElement_Txt.Name = "TaxElement_Txt";
            this.TaxElement_Txt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ElementDescription_Txt
            // 
            this.ElementDescription_Txt.DataPropertyName = "ElementDescription";
            this.ElementDescription_Txt.HeaderText = "Description";
            this.ElementDescription_Txt.Name = "ElementDescription_Txt";
            // 
            // LoadonInventory_Ckbx
            // 
            this.LoadonInventory_Ckbx.DataPropertyName = "LoadonInventory";
            this.LoadonInventory_Ckbx.HeaderText = "Load on Inventory";
            this.LoadonInventory_Ckbx.Name = "LoadonInventory_Ckbx";
            this.LoadonInventory_Ckbx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoadonInventory_Ckbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LoadonInventoryPercent_Txt
            // 
            this.LoadonInventoryPercent_Txt.DataPropertyName = "LoadonInventoryPercent";
            this.LoadonInventoryPercent_Txt.HeaderText = "Load on Inventory %";
            this.LoadonInventoryPercent_Txt.Name = "LoadonInventoryPercent_Txt";
            this.LoadonInventoryPercent_Txt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TaxNature_Cmbx
            // 
            this.TaxNature_Cmbx.DataPropertyName = "TaxNature";
            this.TaxNature_Cmbx.HeaderText = "Tax Nature";
            this.TaxNature_Cmbx.Name = "TaxNature_Cmbx";
            // 
            // ChargeableBasis_Cmbx
            // 
            this.ChargeableBasis_Cmbx.DataPropertyName = "ChargeableBasis";
            this.ChargeableBasis_Cmbx.HeaderText = "Chargeable Basis";
            this.ChargeableBasis_Cmbx.Name = "ChargeableBasis_Cmbx";
            // 
            // CalculationFactors_Txt
            // 
            this.CalculationFactors_Txt.DataPropertyName = "CalculationFactors";
            this.CalculationFactors_Txt.HeaderText = "Calculation Factors";
            this.CalculationFactors_Txt.Name = "CalculationFactors_Txt";
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Image = global::ERP.Properties.Resources.delete;
            this.DeleteColumn.Name = "DeleteColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.Cluster);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.ClusterDescription_Txt);
            this.groupBox1.Controls.Add(this.TaxCluster_Cmbx);
            this.groupBox1.Controls.Add(this.Txt_Number);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Location = new System.Drawing.Point(19, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.groupBox1.Size = new System.Drawing.Size(497, 320);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax Design";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Clear.FlatAppearance.BorderSize = 0;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Clear.Location = new System.Drawing.Point(281, 252);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Btn_Clear.Size = new System.Drawing.Size(103, 43);
            this.Btn_Clear.TabIndex = 7;
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
            this.Btn_Update.Location = new System.Drawing.Point(151, 252);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_Update.Size = new System.Drawing.Size(103, 43);
            this.Btn_Update.TabIndex = 6;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Cluster
            // 
            this.Cluster.AutoSize = true;
            this.Cluster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cluster.Location = new System.Drawing.Point(28, 86);
            this.Cluster.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Cluster.Name = "Cluster";
            this.Cluster.Size = new System.Drawing.Size(74, 16);
            this.Cluster.TabIndex = 32;
            this.Cluster.Text = "Tax Cluster";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(27, 139);
            this.Description.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(75, 16);
            this.Description.TabIndex = 31;
            this.Description.Text = "Description";
            // 
            // ClusterDescription_Txt
            // 
            this.ClusterDescription_Txt.AccessibleName = "";
            this.ClusterDescription_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClusterDescription_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClusterDescription_Txt.Location = new System.Drawing.Point(151, 139);
            this.ClusterDescription_Txt.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ClusterDescription_Txt.MaxLength = 50;
            this.ClusterDescription_Txt.Multiline = true;
            this.ClusterDescription_Txt.Name = "ClusterDescription_Txt";
            this.ClusterDescription_Txt.ReadOnly = true;
            this.ClusterDescription_Txt.Size = new System.Drawing.Size(318, 89);
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
            this.TaxCluster_Cmbx.Location = new System.Drawing.Point(151, 85);
            this.TaxCluster_Cmbx.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TaxCluster_Cmbx.Name = "TaxCluster_Cmbx";
            this.TaxCluster_Cmbx.Size = new System.Drawing.Size(316, 24);
            this.TaxCluster_Cmbx.TabIndex = 1;
            this.TaxCluster_Cmbx.Tag = "TaxCluster";
            this.TaxCluster_Cmbx.SelectionChangeCommitted += new System.EventHandler(this.DdL_Cluster_SelectionChangeCommitted);
            // 
            // Txt_Number
            // 
            this.Txt_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Number.Location = new System.Drawing.Point(153, 26);
            this.Txt_Number.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Txt_Number.Name = "Txt_Number";
            this.Txt_Number.Size = new System.Drawing.Size(314, 23);
            this.Txt_Number.TabIndex = 21;
            this.Txt_Number.Visible = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Save.FlatAppearance.BorderSize = 0;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Save.Location = new System.Drawing.Point(151, 252);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Btn_Save.Size = new System.Drawing.Size(103, 43);
            this.Btn_Save.TabIndex = 5;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // TaxDesignAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 635);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaxDesignAdd";
            this.Text = "TaxDesignAdd";
            this.Load += new System.EventHandler(this.TaxDesignAdd_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_DetailsList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label Cluster;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox ClusterDescription_Txt;
        private System.Windows.Forms.ComboBox TaxCluster_Cmbx;
        private System.Windows.Forms.TextBox Txt_Number;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.DataGridView GV_DetailsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClusterNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxDesignDetailsNumber_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxElement_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementDescription_Txt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LoadonInventory_Ckbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoadonInventoryPercent_Txt;
        private System.Windows.Forms.DataGridViewComboBoxColumn TaxNature_Cmbx;
        private System.Windows.Forms.DataGridViewComboBoxColumn ChargeableBasis_Cmbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalculationFactors_Txt;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
    }
}