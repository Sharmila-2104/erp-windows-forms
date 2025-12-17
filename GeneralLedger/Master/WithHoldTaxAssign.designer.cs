namespace ERP.Purchase.Tax
{
    partial class WithHoldTaxAssign
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
            this.Btn_AddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpactColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_AddNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GV_List);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 13;
            // 
            // Btn_AddNew
            // 
            this.Btn_AddNew.Location = new System.Drawing.Point(566, 79);
            this.Btn_AddNew.Name = "Btn_AddNew";
            this.Btn_AddNew.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddNew.TabIndex = 15;
            this.Btn_AddNew.Text = "Add New";
            this.Btn_AddNew.UseVisualStyleBackColor = true;
            this.Btn_AddNew.Click += new System.EventHandler(this.Btn_AddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "With Hold Tax Assign";
            // 
            // GV_List
            // 
            this.GV_List.AllowUserToAddRows = false;
            this.GV_List.AllowUserToDeleteRows = false;
            this.GV_List.AllowUserToOrderColumns = true;
            this.GV_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_List.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberColumn,
            this.ImpactColumn,
            this.NotesColumn,
            this.DeleteColumn,
            this.EditColumn});
            this.GV_List.Location = new System.Drawing.Point(99, 139);
            this.GV_List.Name = "GV_List";
            this.GV_List.ReadOnly = true;
            this.GV_List.RowTemplate.Height = 25;
            this.GV_List.Size = new System.Drawing.Size(542, 233);
            this.GV_List.TabIndex = 13;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            // 
            // NumberColumn
            // 
            this.NumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberColumn.DataPropertyName = "Number";
            this.NumberColumn.HeaderText = "Number";
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.ReadOnly = true;
            this.NumberColumn.Visible = false;
            // 
            // ImpactColumn
            // 
            this.ImpactColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImpactColumn.DataPropertyName = "Code";
            this.ImpactColumn.HeaderText = "Tax Code";
            this.ImpactColumn.Name = "ImpactColumn";
            this.ImpactColumn.ReadOnly = true;
            // 
            // NotesColumn
            // 
            this.NotesColumn.DataPropertyName = "Description";
            this.NotesColumn.HeaderText = "Description";
            this.NotesColumn.Name = "NotesColumn";
            this.NotesColumn.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Image = global::ERP.Properties.Resources.delete;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "Edit";
            this.EditColumn.Image = global::ERP.Properties.Resources.edit;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // WithHoldTaxAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "WithHoldTaxAssign";
            this.Text = "WithHold Tax Assign";
            this.Load += new System.EventHandler(this.WithHoldTaxAssign_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_AddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpactColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotesColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
    }
}