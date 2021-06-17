
namespace ProjectPCS
{
    partial class viewMasterPelanggan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewMasterPelanggan));
            this.uASDataSet = new ProjectPCS.UASDataSet();
            this.m_pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_pelangganTableAdapter = new ProjectPCS.UASDataSetTableAdapters.m_pelangganTableAdapter();
            this.tableAdapterManager = new ProjectPCS.UASDataSetTableAdapters.TableAdapterManager();
            this.dgv_masterPelanggan = new System.Windows.Forms.DataGridView();
            this.btn_addData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_edited = new System.Windows.Forms.DataGridViewImageColumn();
            this.column_deleted = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_masterPelanggan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uASDataSet
            // 
            this.uASDataSet.DataSetName = "UASDataSet";
            this.uASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_pelangganBindingSource
            // 
            this.m_pelangganBindingSource.DataMember = "m_pelanggan";
            this.m_pelangganBindingSource.DataSource = this.uASDataSet;
            // 
            // m_pelangganTableAdapter
            // 
            this.m_pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = null;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = null;
            this.tableAdapterManager.m_merkTableAdapter = null;
            this.tableAdapterManager.m_modelTableAdapter = null;
            this.tableAdapterManager.m_pelangganTableAdapter = this.m_pelangganTableAdapter;
            this.tableAdapterManager.m_supplierTableAdapter = null;
            this.tableAdapterManager.m_usersTableAdapter = null;
            this.tableAdapterManager.rework_detailTableAdapter = null;
            this.tableAdapterManager.reworkTableAdapter = null;
            this.tableAdapterManager.stock_historyTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.t_invoice_detailTableAdapter = null;
            this.tableAdapterManager.t_invoice_headerTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_detailTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_headerTableAdapter = null;
            this.tableAdapterManager.t_label_hargaTableAdapter = null;
            this.tableAdapterManager.t_pembelian_detailTableAdapter = null;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectPCS.UASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgv_masterPelanggan
            // 
            this.dgv_masterPelanggan.AllowUserToAddRows = false;
            this.dgv_masterPelanggan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_masterPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_masterPelanggan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.column_edited,
            this.column_deleted});
            this.dgv_masterPelanggan.Location = new System.Drawing.Point(4, 62);
            this.dgv_masterPelanggan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_masterPelanggan.Name = "dgv_masterPelanggan";
            this.dgv_masterPelanggan.ReadOnly = true;
            this.dgv_masterPelanggan.RowHeadersVisible = false;
            this.dgv_masterPelanggan.RowHeadersWidth = 62;
            this.dgv_masterPelanggan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_masterPelanggan.Size = new System.Drawing.Size(1920, 637);
            this.dgv_masterPelanggan.TabIndex = 5;
            this.dgv_masterPelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_masterPelanggan_CellContentClick);
            // 
            // btn_addData
            // 
            this.btn_addData.Location = new System.Drawing.Point(4, 8);
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
            this.panel1.Size = new System.Drawing.Size(1924, 52);
            this.panel1.TabIndex = 4;
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
            this.Column1.HeaderText = "KODE";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "NAMA";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 91;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "ALAMAT";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "KOTA";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "TELEPON";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 118;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "NPWP";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "NAMA NPWP";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "ALAMAT NPWP";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "NAMA 2";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 104;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "ALAMAT 2";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "KOTA 2";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.HeaderText = "HP";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 67;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column13.HeaderText = "KETERANGAN";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 155;
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
            // viewMasterPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 839);
            this.Controls.Add(this.dgv_masterPelanggan);
            this.Controls.Add(this.panel1);
            this.Name = "viewMasterPelanggan";
            this.Text = "Tabel Pelanggan";
            this.Load += new System.EventHandler(this.viewMasterPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_masterPelanggan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UASDataSet uASDataSet;
        private System.Windows.Forms.BindingSource m_pelangganBindingSource;
        private UASDataSetTableAdapters.m_pelangganTableAdapter m_pelangganTableAdapter;
        private UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgv_masterPelanggan;
        private System.Windows.Forms.Button btn_addData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewImageColumn column_edited;
        private System.Windows.Forms.DataGridViewImageColumn column_deleted;
    }
}