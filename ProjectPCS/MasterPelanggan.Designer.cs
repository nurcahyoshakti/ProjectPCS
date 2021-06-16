
namespace ProjectPCS
{
    partial class masterPelanggan
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
            System.Windows.Forms.Label p_CODELabel;
            System.Windows.Forms.Label nAMALabel;
            System.Windows.Forms.Label aLAMATLabel;
            System.Windows.Forms.Label tELPLabel;
            System.Windows.Forms.Label kOTALabel;
            System.Windows.Forms.Label nAMA1Label;
            System.Windows.Forms.Label aLAMAT1Label;
            System.Windows.Forms.Label hPLabel;
            System.Windows.Forms.Label kOTA1Label;
            System.Windows.Forms.Label nAMA_NPWPLabel;
            System.Windows.Forms.Label aLAMAT_NPWPLabel;
            System.Windows.Forms.Label nPWPLabel;
            System.Windows.Forms.Label kETERANGANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masterPelanggan));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Bottom = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Top = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uASDataSet = new ProjectPCS.UASDataSet();
            this.m_pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_pelangganTableAdapter = new ProjectPCS.UASDataSetTableAdapters.m_pelangganTableAdapter();
            this.tableAdapterManager = new ProjectPCS.UASDataSetTableAdapters.TableAdapterManager();
            this.m_pelangganBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_pelangganBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_kode = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_almt = new System.Windows.Forms.TextBox();
            this.tb_nama2 = new System.Windows.Forms.TextBox();
            this.tb_almt2 = new System.Windows.Forms.TextBox();
            this.tb_nmnpwp = new System.Windows.Forms.TextBox();
            this.tb_npwp = new System.Windows.Forms.TextBox();
            this.tb_telpn = new System.Windows.Forms.TextBox();
            this.tb_kota = new System.Windows.Forms.TextBox();
            this.tb_hp = new System.Windows.Forms.TextBox();
            this.tb_kota2 = new System.Windows.Forms.TextBox();
            this.tb_almtnpwp = new System.Windows.Forms.TextBox();
            this.tb_note = new System.Windows.Forms.TextBox();
            p_CODELabel = new System.Windows.Forms.Label();
            nAMALabel = new System.Windows.Forms.Label();
            aLAMATLabel = new System.Windows.Forms.Label();
            tELPLabel = new System.Windows.Forms.Label();
            kOTALabel = new System.Windows.Forms.Label();
            nAMA1Label = new System.Windows.Forms.Label();
            aLAMAT1Label = new System.Windows.Forms.Label();
            hPLabel = new System.Windows.Forms.Label();
            kOTA1Label = new System.Windows.Forms.Label();
            nAMA_NPWPLabel = new System.Windows.Forms.Label();
            aLAMAT_NPWPLabel = new System.Windows.Forms.Label();
            nPWPLabel = new System.Windows.Forms.Label();
            kETERANGANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingNavigator)).BeginInit();
            this.m_pelangganBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_CODELabel
            // 
            p_CODELabel.AutoSize = true;
            p_CODELabel.Location = new System.Drawing.Point(76, 158);
            p_CODELabel.Name = "p_CODELabel";
            p_CODELabel.Size = new System.Drawing.Size(113, 20);
            p_CODELabel.TabIndex = 24;
            p_CODELabel.Text = "PELANGGAN:";
            // 
            // nAMALabel
            // 
            nAMALabel.AutoSize = true;
            nAMALabel.Location = new System.Drawing.Point(129, 195);
            nAMALabel.Name = "nAMALabel";
            nAMALabel.Size = new System.Drawing.Size(59, 20);
            nAMALabel.TabIndex = 25;
            nAMALabel.Text = "NAMA:";
            // 
            // aLAMATLabel
            // 
            aLAMATLabel.AutoSize = true;
            aLAMATLabel.Location = new System.Drawing.Point(111, 232);
            aLAMATLabel.Name = "aLAMATLabel";
            aLAMATLabel.Size = new System.Drawing.Size(77, 20);
            aLAMATLabel.TabIndex = 26;
            aLAMATLabel.Text = "ALAMAT:";
            // 
            // tELPLabel
            // 
            tELPLabel.AutoSize = true;
            tELPLabel.Location = new System.Drawing.Point(758, 194);
            tELPLabel.Name = "tELPLabel";
            tELPLabel.Size = new System.Drawing.Size(86, 20);
            tELPLabel.TabIndex = 27;
            tELPLabel.Text = "TELP / HP:";
            // 
            // kOTALabel
            // 
            kOTALabel.AutoSize = true;
            kOTALabel.Location = new System.Drawing.Point(794, 232);
            kOTALabel.Name = "kOTALabel";
            kOTALabel.Size = new System.Drawing.Size(55, 20);
            kOTALabel.TabIndex = 28;
            kOTALabel.Text = "KOTA:";
            // 
            // nAMA1Label
            // 
            nAMA1Label.AutoSize = true;
            nAMA1Label.Location = new System.Drawing.Point(120, 305);
            nAMA1Label.Name = "nAMA1Label";
            nAMA1Label.Size = new System.Drawing.Size(68, 20);
            nAMA1Label.TabIndex = 29;
            nAMA1Label.Text = "Nama 2:";
            // 
            // aLAMAT1Label
            // 
            aLAMAT1Label.AutoSize = true;
            aLAMAT1Label.Location = new System.Drawing.Point(114, 342);
            aLAMAT1Label.Name = "aLAMAT1Label";
            aLAMAT1Label.Size = new System.Drawing.Size(76, 20);
            aLAMAT1Label.TabIndex = 30;
            aLAMAT1Label.Text = "Alamat 2:";
            // 
            // hPLabel
            // 
            hPLabel.AutoSize = true;
            hPLabel.Location = new System.Drawing.Point(766, 298);
            hPLabel.Name = "hPLabel";
            hPLabel.Size = new System.Drawing.Size(77, 20);
            hPLabel.TabIndex = 31;
            hPLabel.Text = "Telp / HP:";
            // 
            // kOTA1Label
            // 
            kOTA1Label.AutoSize = true;
            kOTA1Label.Location = new System.Drawing.Point(790, 340);
            kOTA1Label.Name = "kOTA1Label";
            kOTA1Label.Size = new System.Drawing.Size(59, 20);
            kOTA1Label.TabIndex = 32;
            kOTA1Label.Text = "Kota 2:";
            // 
            // nAMA_NPWPLabel
            // 
            nAMA_NPWPLabel.AutoSize = true;
            nAMA_NPWPLabel.Location = new System.Drawing.Point(75, 406);
            nAMA_NPWPLabel.Name = "nAMA_NPWPLabel";
            nAMA_NPWPLabel.Size = new System.Drawing.Size(109, 20);
            nAMA_NPWPLabel.TabIndex = 33;
            nAMA_NPWPLabel.Text = "NAMA NPWP:";
            // 
            // aLAMAT_NPWPLabel
            // 
            aLAMAT_NPWPLabel.AutoSize = true;
            aLAMAT_NPWPLabel.Location = new System.Drawing.Point(57, 443);
            aLAMAT_NPWPLabel.Name = "aLAMAT_NPWPLabel";
            aLAMAT_NPWPLabel.Size = new System.Drawing.Size(127, 20);
            aLAMAT_NPWPLabel.TabIndex = 34;
            aLAMAT_NPWPLabel.Text = "ALAMAT NPWP:";
            // 
            // nPWPLabel
            // 
            nPWPLabel.AutoSize = true;
            nPWPLabel.Location = new System.Drawing.Point(600, 405);
            nPWPLabel.Name = "nPWPLabel";
            nPWPLabel.Size = new System.Drawing.Size(59, 20);
            nPWPLabel.TabIndex = 35;
            nPWPLabel.Text = "NPWP:";
            // 
            // kETERANGANLabel
            // 
            kETERANGANLabel.AutoSize = true;
            kETERANGANLabel.Location = new System.Drawing.Point(130, 508);
            kETERANGANLabel.Name = "kETERANGANLabel";
            kETERANGANLabel.Size = new System.Drawing.Size(56, 20);
            kETERANGANLabel.TabIndex = 37;
            kETERANGANLabel.Text = "NOTE:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1140, 622);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(112, 35);
            this.btn_Exit.TabIndex = 23;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(1018, 622);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 35);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(898, 622);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(112, 35);
            this.btn_Edit.TabIndex = 21;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(776, 622);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(112, 35);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(654, 622);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(112, 35);
            this.btn_Print.TabIndex = 19;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(532, 622);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(112, 35);
            this.btn_Find.TabIndex = 18;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            // 
            // btn_Bottom
            // 
            this.btn_Bottom.Location = new System.Drawing.Point(412, 622);
            this.btn_Bottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Bottom.Name = "btn_Bottom";
            this.btn_Bottom.Size = new System.Drawing.Size(112, 35);
            this.btn_Bottom.TabIndex = 17;
            this.btn_Bottom.Text = "Bottom";
            this.btn_Bottom.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(290, 622);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(112, 35);
            this.btn_Next.TabIndex = 16;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(168, 622);
            this.btn_Prev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(112, 35);
            this.btn_Prev.TabIndex = 15;
            this.btn_Prev.Text = "Prev";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Top
            // 
            this.btn_Top.Location = new System.Drawing.Point(46, 622);
            this.btn_Top.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Top.Name = "btn_Top";
            this.btn_Top.Size = new System.Drawing.Size(112, 35);
            this.btn_Top.TabIndex = 14;
            this.btn_Top.Text = "Top";
            this.btn_Top.UseVisualStyleBackColor = true;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(900, 75);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(112, 35);
            this.btn_Browse.TabIndex = 13;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "Input Master Pelanggan";
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
            // m_pelangganBindingNavigator
            // 
            this.m_pelangganBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_pelangganBindingNavigator.BindingSource = this.m_pelangganBindingSource;
            this.m_pelangganBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_pelangganBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_pelangganBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.m_pelangganBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.m_pelangganBindingNavigatorSaveItem});
            this.m_pelangganBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_pelangganBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_pelangganBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_pelangganBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_pelangganBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_pelangganBindingNavigator.Name = "m_pelangganBindingNavigator";
            this.m_pelangganBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.m_pelangganBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_pelangganBindingNavigator.Size = new System.Drawing.Size(1314, 33);
            this.m_pelangganBindingNavigator.TabIndex = 24;
            this.m_pelangganBindingNavigator.Text = "bindingNavigator1";
            this.m_pelangganBindingNavigator.RefreshItems += new System.EventHandler(this.m_pelangganBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // m_pelangganBindingNavigatorSaveItem
            // 
            this.m_pelangganBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_pelangganBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_pelangganBindingNavigatorSaveItem.Image")));
            this.m_pelangganBindingNavigatorSaveItem.Name = "m_pelangganBindingNavigatorSaveItem";
            this.m_pelangganBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.m_pelangganBindingNavigatorSaveItem.Text = "Save Data";
            this.m_pelangganBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_pelangganBindingNavigatorSaveItem_Click);
            // 
            // tb_kode
            // 
            this.tb_kode.Location = new System.Drawing.Point(195, 152);
            this.tb_kode.Name = "tb_kode";
            this.tb_kode.Size = new System.Drawing.Size(170, 26);
            this.tb_kode.TabIndex = 39;
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(195, 191);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(340, 26);
            this.tb_nama.TabIndex = 40;
            this.tb_nama.TextChanged += new System.EventHandler(this.tb_nama_TextChanged);
            // 
            // tb_almt
            // 
            this.tb_almt.Location = new System.Drawing.Point(196, 228);
            this.tb_almt.Name = "tb_almt";
            this.tb_almt.Size = new System.Drawing.Size(434, 26);
            this.tb_almt.TabIndex = 41;
            // 
            // tb_nama2
            // 
            this.tb_nama2.Location = new System.Drawing.Point(196, 299);
            this.tb_nama2.Name = "tb_nama2";
            this.tb_nama2.Size = new System.Drawing.Size(340, 26);
            this.tb_nama2.TabIndex = 42;
            this.tb_nama2.TextChanged += new System.EventHandler(this.tb_nama2_TextChanged);
            // 
            // tb_almt2
            // 
            this.tb_almt2.Location = new System.Drawing.Point(196, 335);
            this.tb_almt2.Name = "tb_almt2";
            this.tb_almt2.Size = new System.Drawing.Size(434, 26);
            this.tb_almt2.TabIndex = 43;
            // 
            // tb_nmnpwp
            // 
            this.tb_nmnpwp.Location = new System.Drawing.Point(196, 402);
            this.tb_nmnpwp.Name = "tb_nmnpwp";
            this.tb_nmnpwp.Size = new System.Drawing.Size(340, 26);
            this.tb_nmnpwp.TabIndex = 44;
            // 
            // tb_npwp
            // 
            this.tb_npwp.Location = new System.Drawing.Point(665, 400);
            this.tb_npwp.Name = "tb_npwp";
            this.tb_npwp.Size = new System.Drawing.Size(340, 26);
            this.tb_npwp.TabIndex = 45;
            // 
            // tb_telpn
            // 
            this.tb_telpn.Location = new System.Drawing.Point(862, 188);
            this.tb_telpn.Name = "tb_telpn";
            this.tb_telpn.Size = new System.Drawing.Size(340, 26);
            this.tb_telpn.TabIndex = 46;
            // 
            // tb_kota
            // 
            this.tb_kota.Location = new System.Drawing.Point(862, 228);
            this.tb_kota.Name = "tb_kota";
            this.tb_kota.Size = new System.Drawing.Size(340, 26);
            this.tb_kota.TabIndex = 47;
            // 
            // tb_hp
            // 
            this.tb_hp.Location = new System.Drawing.Point(862, 292);
            this.tb_hp.Name = "tb_hp";
            this.tb_hp.Size = new System.Drawing.Size(340, 26);
            this.tb_hp.TabIndex = 48;
            // 
            // tb_kota2
            // 
            this.tb_kota2.Location = new System.Drawing.Point(862, 335);
            this.tb_kota2.Name = "tb_kota2";
            this.tb_kota2.Size = new System.Drawing.Size(340, 26);
            this.tb_kota2.TabIndex = 49;
            // 
            // tb_almtnpwp
            // 
            this.tb_almtnpwp.Location = new System.Drawing.Point(196, 437);
            this.tb_almtnpwp.Name = "tb_almtnpwp";
            this.tb_almtnpwp.Size = new System.Drawing.Size(434, 26);
            this.tb_almtnpwp.TabIndex = 50;
            // 
            // tb_note
            // 
            this.tb_note.Location = new System.Drawing.Point(196, 502);
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(809, 26);
            this.tb_note.TabIndex = 51;
            // 
            // masterPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1314, 692);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(this.tb_almtnpwp);
            this.Controls.Add(this.tb_kota2);
            this.Controls.Add(this.tb_hp);
            this.Controls.Add(this.tb_kota);
            this.Controls.Add(this.tb_telpn);
            this.Controls.Add(this.tb_npwp);
            this.Controls.Add(this.tb_nmnpwp);
            this.Controls.Add(this.tb_almt2);
            this.Controls.Add(this.tb_nama2);
            this.Controls.Add(this.tb_almt);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.tb_kode);
            this.Controls.Add(kETERANGANLabel);
            this.Controls.Add(nPWPLabel);
            this.Controls.Add(aLAMAT_NPWPLabel);
            this.Controls.Add(nAMA_NPWPLabel);
            this.Controls.Add(kOTA1Label);
            this.Controls.Add(hPLabel);
            this.Controls.Add(aLAMAT1Label);
            this.Controls.Add(nAMA1Label);
            this.Controls.Add(kOTALabel);
            this.Controls.Add(tELPLabel);
            this.Controls.Add(aLAMATLabel);
            this.Controls.Add(nAMALabel);
            this.Controls.Add(p_CODELabel);
            this.Controls.Add(this.m_pelangganBindingNavigator);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_Bottom);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_Top);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "masterPelanggan";
            this.Text = "Input Master Pelanggan";
            this.Load += new System.EventHandler(this.masterPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingNavigator)).EndInit();
            this.m_pelangganBindingNavigator.ResumeLayout(false);
            this.m_pelangganBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Label label1;
        private UASDataSet uASDataSet;
        private System.Windows.Forms.BindingSource m_pelangganBindingSource;
        private UASDataSetTableAdapters.m_pelangganTableAdapter m_pelangganTableAdapter;
        private UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_pelangganBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton m_pelangganBindingNavigatorSaveItem;
        public System.Windows.Forms.TextBox tb_kode;
        public System.Windows.Forms.TextBox tb_nama;
        public System.Windows.Forms.TextBox tb_almt;
        public System.Windows.Forms.TextBox tb_nama2;
        public System.Windows.Forms.TextBox tb_almt2;
        public System.Windows.Forms.TextBox tb_nmnpwp;
        public System.Windows.Forms.TextBox tb_npwp;
        public System.Windows.Forms.TextBox tb_telpn;
        public System.Windows.Forms.TextBox tb_kota;
        public System.Windows.Forms.TextBox tb_hp;
        public System.Windows.Forms.TextBox tb_kota2;
        public System.Windows.Forms.TextBox tb_almtnpwp;
        public System.Windows.Forms.TextBox tb_note;
        public System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.Button btn_Delete;
        public System.Windows.Forms.Button btn_Edit;
        public System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.Button btn_Print;
        public System.Windows.Forms.Button btn_Find;
        public System.Windows.Forms.Button btn_Bottom;
        public System.Windows.Forms.Button btn_Next;
        public System.Windows.Forms.Button btn_Prev;
        public System.Windows.Forms.Button btn_Top;
    }
}