
namespace ProjectPCS
{
    partial class viewMasterModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewMasterModel));
            this.dgv_masterModel = new System.Windows.Forms.DataGridView();
            this.btn_addData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_edited = new System.Windows.Forms.DataGridViewImageColumn();
            this.column_deleted = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_masterModel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_masterModel
            // 
            this.dgv_masterModel.AllowUserToAddRows = false;
            this.dgv_masterModel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_masterModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_masterModel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column1,
            this.Column2,
            this.column_edited,
            this.column_deleted});
            this.dgv_masterModel.Location = new System.Drawing.Point(4, 62);
            this.dgv_masterModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_masterModel.Name = "dgv_masterModel";
            this.dgv_masterModel.ReadOnly = true;
            this.dgv_masterModel.RowHeadersVisible = false;
            this.dgv_masterModel.RowHeadersWidth = 62;
            this.dgv_masterModel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_masterModel.Size = new System.Drawing.Size(421, 438);
            this.dgv_masterModel.TabIndex = 9;
            this.dgv_masterModel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_masterModel_CellContentClick);
            // 
            // btn_addData
            // 
            this.btn_addData.Location = new System.Drawing.Point(4, 5);
            this.btn_addData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addData.Name = "btn_addData";
            this.btn_addData.Size = new System.Drawing.Size(192, 35);
            this.btn_addData.TabIndex = 0;
            this.btn_addData.Text = "Add Data";
            this.btn_addData.UseVisualStyleBackColor = true;
            this.btn_addData.Click += new System.EventHandler(this.btn_addData_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_addData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 52);
            this.panel1.TabIndex = 8;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column14.HeaderText = "#";
            this.Column14.MinimumWidth = 8;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 54;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "MODEL ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 123;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "DESCRIPTION";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 154;
            // 
            // column_edited
            // 
            this.column_edited.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.column_edited.HeaderText = "";
            this.column_edited.Image = ((System.Drawing.Image)(resources.GetObject("column_edited.Image")));
            this.column_edited.MinimumWidth = 8;
            this.column_edited.Name = "column_edited";
            this.column_edited.ReadOnly = true;
            this.column_edited.Width = 8;
            // 
            // column_deleted
            // 
            this.column_deleted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.column_deleted.HeaderText = "";
            this.column_deleted.Image = ((System.Drawing.Image)(resources.GetObject("column_deleted.Image")));
            this.column_deleted.MinimumWidth = 8;
            this.column_deleted.Name = "column_deleted";
            this.column_deleted.ReadOnly = true;
            this.column_deleted.Width = 8;
            // 
            // viewMasterModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 507);
            this.Controls.Add(this.dgv_masterModel);
            this.Controls.Add(this.panel1);
            this.Name = "viewMasterModel";
            this.Text = "viewMasterModel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_masterModel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_masterModel;
        private System.Windows.Forms.Button btn_addData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn column_edited;
        private System.Windows.Forms.DataGridViewImageColumn column_deleted;
    }
}