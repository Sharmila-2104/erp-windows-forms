namespace ERP.GeneralLedger.Master
{
    partial class TaxSetupAdd
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
            this.LoadonInventory_Ckbx = new System.Windows.Forms.CheckBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.TaxNature = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.LoadonInventoryPercent_Txt_Digit = new System.Windows.Forms.TextBox();
            this.ElementDescription_Txt = new System.Windows.Forms.TextBox();
            this.TaxNature_Cmbx = new System.Windows.Forms.ComboBox();
            this.Clus = new System.Windows.Forms.Label();
            this.TaxElement_Cmbx = new System.Windows.Forms.ComboBox();
            this.TaxSetupNumber_Txt = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Label();
            this.TaxSetupDetails = new System.Windows.Forms.DataGridView();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaxSetupDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LoadonInventory_Ckbx);
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.TaxNature);
            this.groupBox1.Controls.Add(this.Inventory);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.LoadonInventoryPercent_Txt_Digit);
            this.groupBox1.Controls.Add(this.ElementDescription_Txt);
            this.groupBox1.Controls.Add(this.TaxNature_Cmbx);
            this.groupBox1.Controls.Add(this.Clus);
            this.groupBox1.Controls.Add(this.TaxElement_Cmbx);
            this.groupBox1.Controls.Add(this.TaxSetupNumber_Txt);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Division);
            this.groupBox1.Location = new System.Drawing.Point(39, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.groupBox1.Size = new System.Drawing.Size(437, 457);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax Setup";
            // 
            // LoadonInventory_Ckbx
            // 
            this.LoadonInventory_Ckbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadonInventory_Ckbx.AutoSize = true;
            this.LoadonInventory_Ckbx.Location = new System.Drawing.Point(183, 217);
            this.LoadonInventory_Ckbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadonInventory_Ckbx.Name = "LoadonInventory_Ckbx";
            this.LoadonInventory_Ckbx.Size = new System.Drawing.Size(15, 14);
            this.LoadonInventory_Ckbx.TabIndex = 2;
            this.LoadonInventory_Ckbx.Tag = "";
            this.LoadonInventory_Ckbx.UseVisualStyleBackColor = true;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Clear.FlatAppearance.BorderSize = 0;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Clear.Location = new System.Drawing.Point(311, 362);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Btn_Clear.Size = new System.Drawing.Size(113, 46);
            this.Btn_Clear.TabIndex = 8;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // TaxNature
            // 
            this.TaxNature.AutoSize = true;
            this.TaxNature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxNature.Location = new System.Drawing.Point(63, 319);
            this.TaxNature.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TaxNature.Name = "TaxNature";
            this.TaxNature.Size = new System.Drawing.Size(73, 16);
            this.TaxNature.TabIndex = 30;
            this.TaxNature.Text = "Tax Nature";
            // 
            // Inventory
            // 
            this.Inventory.AutoSize = true;
            this.Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.Location = new System.Drawing.Point(5, 215);
            this.Inventory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(113, 16);
            this.Inventory.TabIndex = 29;
            this.Inventory.Text = "Load on Inventory";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(56, 149);
            this.Description.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(75, 16);
            this.Description.TabIndex = 28;
            this.Description.Text = "Description";
            // 
            // LoadonInventoryPercent_Txt_Digit
            // 
            this.LoadonInventoryPercent_Txt_Digit.AccessibleName = "";
            this.LoadonInventoryPercent_Txt_Digit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadonInventoryPercent_Txt_Digit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadonInventoryPercent_Txt_Digit.Location = new System.Drawing.Point(183, 257);
            this.LoadonInventoryPercent_Txt_Digit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LoadonInventoryPercent_Txt_Digit.Name = "LoadonInventoryPercent_Txt_Digit";
            this.LoadonInventoryPercent_Txt_Digit.Size = new System.Drawing.Size(218, 23);
            this.LoadonInventoryPercent_Txt_Digit.TabIndex = 3;
            this.LoadonInventoryPercent_Txt_Digit.Tag = "LoadonInventoryPercent";
            // 
            // ElementDescription_Txt
            // 
            this.ElementDescription_Txt.AccessibleName = "";
            this.ElementDescription_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElementDescription_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ElementDescription_Txt.Location = new System.Drawing.Point(183, 130);
            this.ElementDescription_Txt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ElementDescription_Txt.Multiline = true;
            this.ElementDescription_Txt.Name = "ElementDescription_Txt";
            this.ElementDescription_Txt.ReadOnly = true;
            this.ElementDescription_Txt.Size = new System.Drawing.Size(218, 52);
            this.ElementDescription_Txt.TabIndex = 26;
            this.ElementDescription_Txt.Tag = "ElementDescription";
            // 
            // TaxNature_Cmbx
            // 
            this.TaxNature_Cmbx.AccessibleName = "";
            this.TaxNature_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxNature_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaxNature_Cmbx.FormattingEnabled = true;
            this.TaxNature_Cmbx.Location = new System.Drawing.Point(183, 313);
            this.TaxNature_Cmbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TaxNature_Cmbx.Name = "TaxNature_Cmbx";
            this.TaxNature_Cmbx.Size = new System.Drawing.Size(217, 24);
            this.TaxNature_Cmbx.TabIndex = 4;
            this.TaxNature_Cmbx.Tag = "TaxNature";
            // 
            // Clus
            // 
            this.Clus.AutoSize = true;
            this.Clus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clus.Location = new System.Drawing.Point(47, 76);
            this.Clus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Clus.Name = "Clus";
            this.Clus.Size = new System.Drawing.Size(82, 16);
            this.Clus.TabIndex = 23;
            this.Clus.Text = "Tax Element";
            // 
            // TaxElement_Cmbx
            // 
            this.TaxElement_Cmbx.AccessibleName = "";
            this.TaxElement_Cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxElement_Cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaxElement_Cmbx.FormattingEnabled = true;
            this.TaxElement_Cmbx.Location = new System.Drawing.Point(183, 75);
            this.TaxElement_Cmbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TaxElement_Cmbx.Name = "TaxElement_Cmbx";
            this.TaxElement_Cmbx.Size = new System.Drawing.Size(217, 24);
            this.TaxElement_Cmbx.TabIndex = 1;
            this.TaxElement_Cmbx.Tag = "TaxElement";
            this.TaxElement_Cmbx.SelectionChangeCommitted += new System.EventHandler(this.TaxElement_Cmbx_SelectionChangeCommitted);
            // 
            // TaxSetupNumber_Txt
            // 
            this.TaxSetupNumber_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxSetupNumber_Txt.Location = new System.Drawing.Point(183, 25);
            this.TaxSetupNumber_Txt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TaxSetupNumber_Txt.Name = "TaxSetupNumber_Txt";
            this.TaxSetupNumber_Txt.Size = new System.Drawing.Size(333, 23);
            this.TaxSetupNumber_Txt.TabIndex = 21;
            this.TaxSetupNumber_Txt.Visible = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Update.Location = new System.Drawing.Point(183, 362);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Update.Size = new System.Drawing.Size(113, 46);
            this.Btn_Update.TabIndex = 7;
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
            this.Btn_Save.Location = new System.Drawing.Point(183, 362);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Btn_Save.Size = new System.Drawing.Size(113, 46);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Division
            // 
            this.Division.AutoSize = true;
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(5, 262);
            this.Division.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(128, 16);
            this.Division.TabIndex = 15;
            this.Division.Text = "Load on Inventory %";
            // 
            // TaxSetupDetails
            // 
            this.TaxSetupDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxSetupDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaxSetupDetails.BackgroundColor = System.Drawing.Color.White;
            this.TaxSetupDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaxSetupDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberColumn,
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
            this.TaxSetupDetails.Location = new System.Drawing.Point(511, 118);
            this.TaxSetupDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TaxSetupDetails.Name = "TaxSetupDetails";
            this.TaxSetupDetails.Size = new System.Drawing.Size(577, 252);
            this.TaxSetupDetails.TabIndex = 5;
            this.TaxSetupDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaxSetupDetails_CellContentClick);
            this.TaxSetupDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TaxSetupDetails_DataError);
            // 
            // NumberColumn
            // 
            this.NumberColumn.DataPropertyName = "Number";
            this.NumberColumn.HeaderText = "Number";
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.Visible = false;
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
            this.FromDate_Dt.DataPropertyName = "FromDate";
            this.FromDate_Dt.HeaderText = "From Date";
            this.FromDate_Dt.Name = "FromDate_Dt";
            // 
            // ToDate_Dt
            // 
            this.ToDate_Dt.DataPropertyName = "ToDate";
            this.ToDate_Dt.HeaderText = "To Date";
            this.ToDate_Dt.Name = "ToDate_Dt";
            this.ToDate_Dt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TaxNature_GvCmbx
            // 
            this.TaxNature_GvCmbx.DataPropertyName = "GvTaxNature";
            this.TaxNature_GvCmbx.HeaderText = "Tax Nature";
            this.TaxNature_GvCmbx.Name = "TaxNature_GvCmbx";
            this.TaxNature_GvCmbx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TaxNature_GvCmbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FixedPercent_Txt
            // 
            this.FixedPercent_Txt.DataPropertyName = "FixedPercent";
            this.FixedPercent_Txt.HeaderText = "Percent";
            this.FixedPercent_Txt.Name = "FixedPercent_Txt";
            // 
            // HSN_Cmbx
            // 
            this.HSN_Cmbx.DataPropertyName = "HSN";
            this.HSN_Cmbx.HeaderText = "HSN";
            this.HSN_Cmbx.Name = "HSN_Cmbx";
            this.HSN_Cmbx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HSN_Cmbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // HSN_Percent_Txt
            // 
            this.HSN_Percent_Txt.DataPropertyName = "HSN_Percent";
            this.HSN_Percent_Txt.HeaderText = "Percent";
            this.HSN_Percent_Txt.Name = "HSN_Percent_Txt";
            // 
            // SAC_Cmbx
            // 
            this.SAC_Cmbx.DataPropertyName = "SAC";
            this.SAC_Cmbx.HeaderText = "SAC";
            this.SAC_Cmbx.Name = "SAC_Cmbx";
            this.SAC_Cmbx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SAC_Cmbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SAC_Percent_Txt
            // 
            this.SAC_Percent_Txt.DataPropertyName = "SAC_Percent";
            this.SAC_Percent_Txt.HeaderText = "Percent";
            this.SAC_Percent_Txt.Name = "SAC_Percent_Txt";
            // 
            // Abatement_Txt
            // 
            this.Abatement_Txt.DataPropertyName = "Abatement";
            this.Abatement_Txt.HeaderText = "Abatement %";
            this.Abatement_Txt.Name = "Abatement_Txt";
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Image = global::ERP.Properties.Resources.delete;
            this.DeleteColumn.Name = "DeleteColumn";
            // 
            // TaxSetupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 539);
            this.Controls.Add(this.TaxSetupDetails);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaxSetupAdd";
            this.Text = "Tax Setup Add";
            this.Load += new System.EventHandler(this.TaxSetupAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaxSetupDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label TaxNature;
        private System.Windows.Forms.Label Inventory;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox ElementDescription_Txt;
        private System.Windows.Forms.Label Clus;
        private System.Windows.Forms.ComboBox TaxElement_Cmbx;
        private System.Windows.Forms.TextBox TaxSetupNumber_Txt;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Division;
        private System.Windows.Forms.DataGridView TaxSetupDetails;
        private System.Windows.Forms.CheckBox LoadonInventory_Ckbx;
        private System.Windows.Forms.TextBox LoadonInventoryPercent_Txt_Digit;
        private System.Windows.Forms.ComboBox TaxNature_Cmbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
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