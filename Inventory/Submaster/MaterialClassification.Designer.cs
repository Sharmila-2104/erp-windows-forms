namespace ERP.Purchase.Item.SubMaster
{
    partial class MaterialClassification
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Txt_Number = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel1.Size = new System.Drawing.Size(816, 420);
            this.panel1.TabIndex = 12;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(786, 405);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.Txt_Number);
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Title);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Notes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(320, 375);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material Classification";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Location = new System.Drawing.Point(200, 202);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(80, 35);
            this.Btn_Clear.TabIndex = 5;
            this.Btn_Clear.Tag = "Clear";
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Txt_Number
            // 
            this.Txt_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Number.Location = new System.Drawing.Point(111, 17);
            this.Txt_Number.Margin = new System.Windows.Forms.Padding(5);
            this.Txt_Number.Name = "Txt_Number";
            this.Txt_Number.ShortcutsEnabled = false;
            this.Txt_Number.Size = new System.Drawing.Size(189, 23);
            this.Txt_Number.TabIndex = 21;
            this.Txt_Number.Visible = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Update.Location = new System.Drawing.Point(111, 202);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Padding = new System.Windows.Forms.Padding(5);
            this.Btn_Update.Size = new System.Drawing.Size(80, 35);
            this.Btn_Update.TabIndex = 4;
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
            this.Btn_Save.Location = new System.Drawing.Point(111, 202);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Btn_Save.Size = new System.Drawing.Size(80, 35);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Classification";
            // 
            // Txt_Title
            // 
            this.Txt_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Title.Location = new System.Drawing.Point(111, 45);
            this.Txt_Title.Margin = new System.Windows.Forms.Padding(5);
            this.Txt_Title.MaxLength = 50;
            this.Txt_Title.Name = "Txt_Title";
            this.Txt_Title.Size = new System.Drawing.Size(189, 23);
            this.Txt_Title.TabIndex = 1;
            this.Txt_Title.Tag = "Material Classification";
            this.Txt_Title.Leave += new System.EventHandler(this.Txt_Title_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Notes";
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Notes.Location = new System.Drawing.Point(111, 83);
            this.Txt_Notes.Margin = new System.Windows.Forms.Padding(5);
            this.Txt_Notes.MaxLength = 250;
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(189, 100);
            this.Txt_Notes.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.GV_List);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(15, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(414, 345);
            this.panel3.TabIndex = 11;
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberColumn,
            this.TitleColumn,
            this.NotesColumn,
            this.Delete,
            this.Edit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GV_List.DefaultCellStyle = dataGridViewCellStyle2;
            this.GV_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_List.GridColor = System.Drawing.Color.LightGray;
            this.GV_List.Location = new System.Drawing.Point(15, 15);
            this.GV_List.Margin = new System.Windows.Forms.Padding(5);
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
            this.GV_List.Size = new System.Drawing.Size(384, 315);
            this.GV_List.TabIndex = 7;
            this.GV_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_List_CellContentClick);
            // 
            // NumberColumn
            // 
            this.NumberColumn.DataPropertyName = "Number";
            this.NumberColumn.HeaderText = "Number";
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.ReadOnly = true;
            this.NumberColumn.Visible = false;
            // 
            // TitleColumn
            // 
            this.TitleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TitleColumn.DataPropertyName = "Classification";
            this.TitleColumn.HeaderText = "Classification";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            // 
            // NotesColumn
            // 
            this.NotesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NotesColumn.DataPropertyName = "Notes";
            this.NotesColumn.HeaderText = "Notes";
            this.NotesColumn.Name = "NotesColumn";
            this.NotesColumn.ReadOnly = true;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(15, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(414, 60);
            this.panel2.TabIndex = 10;
            // 
            // MaterialClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 420);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MaterialClassification";
            this.Text = "Material Classification";
            this.Load += new System.EventHandler(this.MaterialClassification_Load);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.TextBox Txt_Number;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Notes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView GV_List;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotesColumn;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}