
namespace ProjectPCS
{
    partial class masterBarang
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
            System.Windows.Forms.Label kODELabel;
            System.Windows.Forms.Label pART_NOLabel;
            System.Windows.Forms.Label pN1Label;
            System.Windows.Forms.Label uNIT_PRICELabel;
            System.Windows.Forms.Label uNITLabel;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.Windows.Forms.Label sTAMPINGLabel;
            System.Windows.Forms.Label dATA_FISIKLabel;
            System.Windows.Forms.Label pERSAMAANLabel;
            System.Windows.Forms.Label mERK1Label;
            System.Windows.Forms.Label mERK2Label;
            System.Windows.Forms.Label mERK3Label;
            System.Windows.Forms.Label kETERANGANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masterBarang));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Top = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Bottom = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.uASDataSet = new ProjectPCS.UASDataSet();
            this.m_barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_barangTableAdapter = new ProjectPCS.UASDataSetTableAdapters.m_barangTableAdapter();
            this.tableAdapterManager = new ProjectPCS.UASDataSetTableAdapters.TableAdapterManager();
            this.m_barangBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.m_barangBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kODETextBox = new System.Windows.Forms.TextBox();
            this.pART_NOTextBox = new System.Windows.Forms.TextBox();
            this.pN1TextBox = new System.Windows.Forms.TextBox();
            this.uNIT_PRICETextBox = new System.Windows.Forms.TextBox();
            this.uNITTextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.sTAMPINGTextBox = new System.Windows.Forms.TextBox();
            this.dATA_FISIKTextBox = new System.Windows.Forms.TextBox();
            this.pERSAMAANTextBox = new System.Windows.Forms.TextBox();
            this.mERK1TextBox = new System.Windows.Forms.TextBox();
            this.mERK2TextBox = new System.Windows.Forms.TextBox();
            this.mERK3TextBox = new System.Windows.Forms.TextBox();
            this.kETERANGANTextBox = new System.Windows.Forms.TextBox();
            kODELabel = new System.Windows.Forms.Label();
            pART_NOLabel = new System.Windows.Forms.Label();
            pN1Label = new System.Windows.Forms.Label();
            uNIT_PRICELabel = new System.Windows.Forms.Label();
            uNITLabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            sTAMPINGLabel = new System.Windows.Forms.Label();
            dATA_FISIKLabel = new System.Windows.Forms.Label();
            pERSAMAANLabel = new System.Windows.Forms.Label();
            mERK1Label = new System.Windows.Forms.Label();
            mERK2Label = new System.Windows.Forms.Label();
            mERK3Label = new System.Windows.Forms.Label();
            kETERANGANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingNavigator)).BeginInit();
            this.m_barangBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kODELabel
            // 
            kODELabel.AutoSize = true;
            kODELabel.Location = new System.Drawing.Point(45, 185);
            kODELabel.Name = "kODELabel";
            kODELabel.Size = new System.Drawing.Size(106, 20);
            kODELabel.TabIndex = 13;
            kODELabel.Text = "Kode Barang:";
            // 
            // pART_NOLabel
            // 
            pART_NOLabel.AutoSize = true;
            pART_NOLabel.Location = new System.Drawing.Point(428, 185);
            pART_NOLabel.Name = "pART_NOLabel";
            pART_NOLabel.Size = new System.Drawing.Size(102, 20);
            pART_NOLabel.TabIndex = 15;
            pART_NOLabel.Text = "Part Number:";
            // 
            // pN1Label
            // 
            pN1Label.AutoSize = true;
            pN1Label.Location = new System.Drawing.Point(794, 185);
            pN1Label.Name = "pN1Label";
            pN1Label.Size = new System.Drawing.Size(59, 20);
            pN1Label.TabIndex = 17;
            pN1Label.Text = "P / N 1:";
            // 
            // uNIT_PRICELabel
            // 
            uNIT_PRICELabel.AutoSize = true;
            uNIT_PRICELabel.Location = new System.Drawing.Point(1120, 185);
            uNIT_PRICELabel.Name = "uNIT_PRICELabel";
            uNIT_PRICELabel.Size = new System.Drawing.Size(113, 20);
            uNIT_PRICELabel.TabIndex = 19;
            uNIT_PRICELabel.Text = "Harga Satuan:";
            // 
            // uNITLabel
            // 
            uNITLabel.AutoSize = true;
            uNITLabel.Location = new System.Drawing.Point(720, 248);
            uNITLabel.Name = "uNITLabel";
            uNITLabel.Size = new System.Drawing.Size(42, 20);
            uNITLabel.TabIndex = 21;
            uNITLabel.Text = "Unit:";
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(40, 249);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(111, 20);
            dESCRIPTIONLabel.TabIndex = 23;
            dESCRIPTIONLabel.Text = "Nama Barang:";
            // 
            // sTAMPINGLabel
            // 
            sTAMPINGLabel.AutoSize = true;
            sTAMPINGLabel.Location = new System.Drawing.Point(72, 365);
            sTAMPINGLabel.Name = "sTAMPINGLabel";
            sTAMPINGLabel.Size = new System.Drawing.Size(81, 20);
            sTAMPINGLabel.TabIndex = 25;
            sTAMPINGLabel.Text = "Stamping:";
            // 
            // dATA_FISIKLabel
            // 
            dATA_FISIKLabel.AutoSize = true;
            dATA_FISIKLabel.Location = new System.Drawing.Point(490, 365);
            dATA_FISIKLabel.Name = "dATA_FISIKLabel";
            dATA_FISIKLabel.Size = new System.Drawing.Size(84, 20);
            dATA_FISIKLabel.TabIndex = 27;
            dATA_FISIKLabel.Text = "Data Fisik:";
            // 
            // pERSAMAANLabel
            // 
            pERSAMAANLabel.AutoSize = true;
            pERSAMAANLabel.Location = new System.Drawing.Point(928, 365);
            pERSAMAANLabel.Name = "pERSAMAANLabel";
            pERSAMAANLabel.Size = new System.Drawing.Size(94, 20);
            pERSAMAANLabel.TabIndex = 29;
            pERSAMAANLabel.Text = "Persamaan:";
            // 
            // mERK1Label
            // 
            mERK1Label.AutoSize = true;
            mERK1Label.Location = new System.Drawing.Point(86, 415);
            mERK1Label.Name = "mERK1Label";
            mERK1Label.Size = new System.Drawing.Size(61, 20);
            mERK1Label.TabIndex = 31;
            mERK1Label.Text = "Merk 1:";
            // 
            // mERK2Label
            // 
            mERK2Label.AutoSize = true;
            mERK2Label.Location = new System.Drawing.Point(508, 417);
            mERK2Label.Name = "mERK2Label";
            mERK2Label.Size = new System.Drawing.Size(61, 20);
            mERK2Label.TabIndex = 33;
            mERK2Label.Text = "Merk 2:";
            // 
            // mERK3Label
            // 
            mERK3Label.AutoSize = true;
            mERK3Label.Location = new System.Drawing.Point(956, 417);
            mERK3Label.Name = "mERK3Label";
            mERK3Label.Size = new System.Drawing.Size(61, 20);
            mERK3Label.TabIndex = 35;
            mERK3Label.Text = "Merk 3:";
            // 
            // kETERANGANLabel
            // 
            kETERANGANLabel.AutoSize = true;
            kETERANGANLabel.Location = new System.Drawing.Point(104, 532);
            kETERANGANLabel.Name = "kETERANGANLabel";
            kETERANGANLabel.Size = new System.Drawing.Size(47, 20);
            kETERANGANLabel.TabIndex = 37;
            kETERANGANLabel.Text = "Note:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Master Barang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(906, 74);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(112, 35);
            this.btn_Browse.TabIndex = 1;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Top
            // 
            this.btn_Top.Location = new System.Drawing.Point(138, 623);
            this.btn_Top.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Top.Name = "btn_Top";
            this.btn_Top.Size = new System.Drawing.Size(112, 35);
            this.btn_Top.TabIndex = 2;
            this.btn_Top.Text = "Top";
            this.btn_Top.UseVisualStyleBackColor = true;
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(260, 623);
            this.btn_Prev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(112, 35);
            this.btn_Prev.TabIndex = 3;
            this.btn_Prev.Text = "Prev";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(381, 623);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(112, 35);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Bottom
            // 
            this.btn_Bottom.Location = new System.Drawing.Point(502, 623);
            this.btn_Bottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Bottom.Name = "btn_Bottom";
            this.btn_Bottom.Size = new System.Drawing.Size(112, 35);
            this.btn_Bottom.TabIndex = 5;
            this.btn_Bottom.Text = "Bottom";
            this.btn_Bottom.UseVisualStyleBackColor = true;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(624, 623);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(112, 35);
            this.btn_Find.TabIndex = 6;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(746, 623);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(112, 35);
            this.btn_Print.TabIndex = 7;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(867, 623);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(112, 35);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(988, 623);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(112, 35);
            this.btn_Edit.TabIndex = 9;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(1110, 623);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 35);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1232, 623);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(112, 35);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // uASDataSet
            // 
            this.uASDataSet.DataSetName = "UASDataSet";
            this.uASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_barangBindingSource
            // 
            this.m_barangBindingSource.DataMember = "m_barang";
            this.m_barangBindingSource.DataSource = this.uASDataSet;
            // 
            // m_barangTableAdapter
            // 
            this.m_barangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = this.m_barangTableAdapter;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = null;
            this.tableAdapterManager.m_merkTableAdapter = null;
            this.tableAdapterManager.m_modelTableAdapter = null;
            this.tableAdapterManager.m_pelangganTableAdapter = null;
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
            // m_barangBindingNavigator
            // 
            this.m_barangBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_barangBindingNavigator.BindingSource = this.m_barangBindingSource;
            this.m_barangBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_barangBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_barangBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.m_barangBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_barangBindingNavigatorSaveItem});
            this.m_barangBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_barangBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_barangBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_barangBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_barangBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_barangBindingNavigator.Name = "m_barangBindingNavigator";
            this.m_barangBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.m_barangBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_barangBindingNavigator.Size = new System.Drawing.Size(1482, 38);
            this.m_barangBindingNavigator.TabIndex = 12;
            this.m_barangBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
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
            // m_barangBindingNavigatorSaveItem
            // 
            this.m_barangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_barangBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_barangBindingNavigatorSaveItem.Image")));
            this.m_barangBindingNavigatorSaveItem.Name = "m_barangBindingNavigatorSaveItem";
            this.m_barangBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.m_barangBindingNavigatorSaveItem.Text = "Save Data";
            this.m_barangBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_barangBindingNavigatorSaveItem_Click);
            // 
            // kODETextBox
            // 
            this.kODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "KODE", true));
            this.kODETextBox.Location = new System.Drawing.Point(159, 180);
            this.kODETextBox.Name = "kODETextBox";
            this.kODETextBox.Size = new System.Drawing.Size(192, 26);
            this.kODETextBox.TabIndex = 14;
            // 
            // pART_NOTextBox
            // 
            this.pART_NOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "PART_NO", true));
            this.pART_NOTextBox.Location = new System.Drawing.Point(537, 180);
            this.pART_NOTextBox.Name = "pART_NOTextBox";
            this.pART_NOTextBox.Size = new System.Drawing.Size(192, 26);
            this.pART_NOTextBox.TabIndex = 16;
            // 
            // pN1TextBox
            // 
            this.pN1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "PN1", true));
            this.pN1TextBox.Location = new System.Drawing.Point(867, 180);
            this.pN1TextBox.Name = "pN1TextBox";
            this.pN1TextBox.Size = new System.Drawing.Size(192, 26);
            this.pN1TextBox.TabIndex = 18;
            // 
            // uNIT_PRICETextBox
            // 
            this.uNIT_PRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "UNIT_PRICE", true));
            this.uNIT_PRICETextBox.Location = new System.Drawing.Point(1240, 180);
            this.uNIT_PRICETextBox.Name = "uNIT_PRICETextBox";
            this.uNIT_PRICETextBox.Size = new System.Drawing.Size(192, 26);
            this.uNIT_PRICETextBox.TabIndex = 20;
            // 
            // uNITTextBox
            // 
            this.uNITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "UNIT", true));
            this.uNITTextBox.Location = new System.Drawing.Point(770, 245);
            this.uNITTextBox.Name = "uNITTextBox";
            this.uNITTextBox.Size = new System.Drawing.Size(520, 26);
            this.uNITTextBox.TabIndex = 22;
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(159, 245);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(520, 26);
            this.dESCRIPTIONTextBox.TabIndex = 24;
            // 
            // sTAMPINGTextBox
            // 
            this.sTAMPINGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "STAMPING", true));
            this.sTAMPINGTextBox.Location = new System.Drawing.Point(159, 360);
            this.sTAMPINGTextBox.Name = "sTAMPINGTextBox";
            this.sTAMPINGTextBox.Size = new System.Drawing.Size(277, 26);
            this.sTAMPINGTextBox.TabIndex = 26;
            // 
            // dATA_FISIKTextBox
            // 
            this.dATA_FISIKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "DATA_FISIK", true));
            this.dATA_FISIKTextBox.Location = new System.Drawing.Point(582, 360);
            this.dATA_FISIKTextBox.Name = "dATA_FISIKTextBox";
            this.dATA_FISIKTextBox.Size = new System.Drawing.Size(277, 26);
            this.dATA_FISIKTextBox.TabIndex = 28;
            // 
            // pERSAMAANTextBox
            // 
            this.pERSAMAANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "PERSAMAAN", true));
            this.pERSAMAANTextBox.Location = new System.Drawing.Point(1029, 360);
            this.pERSAMAANTextBox.Name = "pERSAMAANTextBox";
            this.pERSAMAANTextBox.Size = new System.Drawing.Size(277, 26);
            this.pERSAMAANTextBox.TabIndex = 30;
            // 
            // mERK1TextBox
            // 
            this.mERK1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK1", true));
            this.mERK1TextBox.Location = new System.Drawing.Point(159, 412);
            this.mERK1TextBox.Name = "mERK1TextBox";
            this.mERK1TextBox.Size = new System.Drawing.Size(277, 26);
            this.mERK1TextBox.TabIndex = 32;
            // 
            // mERK2TextBox
            // 
            this.mERK2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK2", true));
            this.mERK2TextBox.Location = new System.Drawing.Point(582, 412);
            this.mERK2TextBox.Name = "mERK2TextBox";
            this.mERK2TextBox.Size = new System.Drawing.Size(277, 26);
            this.mERK2TextBox.TabIndex = 34;
            // 
            // mERK3TextBox
            // 
            this.mERK3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK3", true));
            this.mERK3TextBox.Location = new System.Drawing.Point(1029, 412);
            this.mERK3TextBox.Name = "mERK3TextBox";
            this.mERK3TextBox.Size = new System.Drawing.Size(277, 26);
            this.mERK3TextBox.TabIndex = 36;
            // 
            // kETERANGANTextBox
            // 
            this.kETERANGANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "KETERANGAN", true));
            this.kETERANGANTextBox.Location = new System.Drawing.Point(159, 528);
            this.kETERANGANTextBox.Name = "kETERANGANTextBox";
            this.kETERANGANTextBox.Size = new System.Drawing.Size(1147, 26);
            this.kETERANGANTextBox.TabIndex = 38;
            // 
            // masterBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1482, 692);
            this.Controls.Add(kETERANGANLabel);
            this.Controls.Add(this.kETERANGANTextBox);
            this.Controls.Add(mERK3Label);
            this.Controls.Add(this.mERK3TextBox);
            this.Controls.Add(mERK2Label);
            this.Controls.Add(this.mERK2TextBox);
            this.Controls.Add(mERK1Label);
            this.Controls.Add(this.mERK1TextBox);
            this.Controls.Add(pERSAMAANLabel);
            this.Controls.Add(this.pERSAMAANTextBox);
            this.Controls.Add(dATA_FISIKLabel);
            this.Controls.Add(this.dATA_FISIKTextBox);
            this.Controls.Add(sTAMPINGLabel);
            this.Controls.Add(this.sTAMPINGTextBox);
            this.Controls.Add(dESCRIPTIONLabel);
            this.Controls.Add(this.dESCRIPTIONTextBox);
            this.Controls.Add(uNITLabel);
            this.Controls.Add(this.uNITTextBox);
            this.Controls.Add(uNIT_PRICELabel);
            this.Controls.Add(this.uNIT_PRICETextBox);
            this.Controls.Add(pN1Label);
            this.Controls.Add(this.pN1TextBox);
            this.Controls.Add(pART_NOLabel);
            this.Controls.Add(this.pART_NOTextBox);
            this.Controls.Add(kODELabel);
            this.Controls.Add(this.kODETextBox);
            this.Controls.Add(this.m_barangBindingNavigator);
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
            this.Name = "masterBarang";
            this.Text = "Input Master Barang";
            this.Load += new System.EventHandler(this.masterBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingNavigator)).EndInit();
            this.m_barangBindingNavigator.ResumeLayout(false);
            this.m_barangBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Top;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Bottom;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private UASDataSet uASDataSet;
        private System.Windows.Forms.BindingSource m_barangBindingSource;
        private UASDataSetTableAdapters.m_barangTableAdapter m_barangTableAdapter;
        private UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_barangBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_barangBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kODETextBox;
        private System.Windows.Forms.TextBox pART_NOTextBox;
        private System.Windows.Forms.TextBox pN1TextBox;
        private System.Windows.Forms.TextBox uNIT_PRICETextBox;
        private System.Windows.Forms.TextBox uNITTextBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.TextBox sTAMPINGTextBox;
        private System.Windows.Forms.TextBox dATA_FISIKTextBox;
        private System.Windows.Forms.TextBox pERSAMAANTextBox;
        private System.Windows.Forms.TextBox mERK1TextBox;
        private System.Windows.Forms.TextBox mERK2TextBox;
        private System.Windows.Forms.TextBox mERK3TextBox;
        private System.Windows.Forms.TextBox kETERANGANTextBox;
    }
}