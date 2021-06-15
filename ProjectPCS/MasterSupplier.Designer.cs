
namespace ProjectPCS
{
    partial class masterSupplier
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
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label bANKLabel;
            System.Windows.Forms.Label tELP_HPLabel;
            System.Windows.Forms.Label nAMALabel;
            System.Windows.Forms.Label aLAMATLabel;
            System.Windows.Forms.Label kOTALabel;
            System.Windows.Forms.Label nAMA_NPWPLabel;
            System.Windows.Forms.Label aLAMAT_NPWLabel;
            System.Windows.Forms.Label nPWPLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label nOTELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masterSupplier));
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
            this.m_supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_supplierTableAdapter = new ProjectPCS.UASDataSetTableAdapters.m_supplierTableAdapter();
            this.tableAdapterManager = new ProjectPCS.UASDataSetTableAdapters.TableAdapterManager();
            this.m_supplierBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.m_supplierBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.p_IDTextBox = new System.Windows.Forms.TextBox();
            this.bANKTextBox = new System.Windows.Forms.TextBox();
            this.tELP_HPTextBox = new System.Windows.Forms.TextBox();
            this.nAMATextBox = new System.Windows.Forms.TextBox();
            this.aLAMATTextBox = new System.Windows.Forms.TextBox();
            this.kOTATextBox = new System.Windows.Forms.TextBox();
            this.nAMA_NPWPTextBox = new System.Windows.Forms.TextBox();
            this.aLAMAT_NPWTextBox = new System.Windows.Forms.TextBox();
            this.nPWPTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.nOTETextBox = new System.Windows.Forms.TextBox();
            p_IDLabel = new System.Windows.Forms.Label();
            bANKLabel = new System.Windows.Forms.Label();
            tELP_HPLabel = new System.Windows.Forms.Label();
            nAMALabel = new System.Windows.Forms.Label();
            aLAMATLabel = new System.Windows.Forms.Label();
            kOTALabel = new System.Windows.Forms.Label();
            nAMA_NPWPLabel = new System.Windows.Forms.Label();
            aLAMAT_NPWLabel = new System.Windows.Forms.Label();
            nPWPLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            nOTELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingNavigator)).BeginInit();
            this.m_supplierBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.Location = new System.Drawing.Point(35, 138);
            p_IDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(63, 13);
            p_IDLabel.TabIndex = 24;
            p_IDLabel.Text = "SUPPLIER:";
            // 
            // bANKLabel
            // 
            bANKLabel.AutoSize = true;
            bANKLabel.Location = new System.Drawing.Point(424, 120);
            bANKLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            bANKLabel.Name = "bANKLabel";
            bANKLabel.Size = new System.Drawing.Size(39, 13);
            bANKLabel.TabIndex = 25;
            bANKLabel.Text = "BANK:";
            // 
            // tELP_HPLabel
            // 
            tELP_HPLabel.AutoSize = true;
            tELP_HPLabel.Location = new System.Drawing.Point(712, 138);
            tELP_HPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tELP_HPLabel.Name = "tELP_HPLabel";
            tELP_HPLabel.Size = new System.Drawing.Size(25, 13);
            tELP_HPLabel.TabIndex = 26;
            tELP_HPLabel.Text = "HP:";
            // 
            // nAMALabel
            // 
            nAMALabel.AutoSize = true;
            nAMALabel.Location = new System.Drawing.Point(57, 162);
            nAMALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nAMALabel.Name = "nAMALabel";
            nAMALabel.Size = new System.Drawing.Size(41, 13);
            nAMALabel.TabIndex = 27;
            nAMALabel.Text = "NAMA:";
            nAMALabel.Click += new System.EventHandler(this.nAMALabel_Click);
            // 
            // aLAMATLabel
            // 
            aLAMATLabel.AutoSize = true;
            aLAMATLabel.Location = new System.Drawing.Point(266, 162);
            aLAMATLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            aLAMATLabel.Name = "aLAMATLabel";
            aLAMATLabel.Size = new System.Drawing.Size(53, 13);
            aLAMATLabel.TabIndex = 28;
            aLAMATLabel.Text = "ALAMAT:";
            // 
            // kOTALabel
            // 
            kOTALabel.AutoSize = true;
            kOTALabel.Location = new System.Drawing.Point(698, 162);
            kOTALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            kOTALabel.Name = "kOTALabel";
            kOTALabel.Size = new System.Drawing.Size(39, 13);
            kOTALabel.TabIndex = 29;
            kOTALabel.Text = "KOTA:";
            // 
            // nAMA_NPWPLabel
            // 
            nAMA_NPWPLabel.AutoSize = true;
            nAMA_NPWPLabel.Location = new System.Drawing.Point(24, 227);
            nAMA_NPWPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nAMA_NPWPLabel.Name = "nAMA_NPWPLabel";
            nAMA_NPWPLabel.Size = new System.Drawing.Size(74, 13);
            nAMA_NPWPLabel.TabIndex = 30;
            nAMA_NPWPLabel.Text = "Nama NPWP:";
            // 
            // aLAMAT_NPWLabel
            // 
            aLAMAT_NPWLabel.AutoSize = true;
            aLAMAT_NPWLabel.Location = new System.Drawing.Point(20, 251);
            aLAMAT_NPWLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            aLAMAT_NPWLabel.Name = "aLAMAT_NPWLabel";
            aLAMAT_NPWLabel.Size = new System.Drawing.Size(78, 13);
            aLAMAT_NPWLabel.TabIndex = 31;
            aLAMAT_NPWLabel.Text = "Alamat NPWP:";
            // 
            // nPWPLabel
            // 
            nPWPLabel.AutoSize = true;
            nPWPLabel.Location = new System.Drawing.Point(424, 227);
            nPWPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nPWPLabel.Name = "nPWPLabel";
            nPWPLabel.Size = new System.Drawing.Size(62, 13);
            nPWPLabel.TabIndex = 32;
            nPWPLabel.Text = "NO NPWP:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(56, 275);
            eMAILLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(42, 13);
            eMAILLabel.TabIndex = 33;
            eMAILLabel.Text = "EMAIL:";
            // 
            // nOTELabel
            // 
            nOTELabel.AutoSize = true;
            nOTELabel.Location = new System.Drawing.Point(58, 321);
            nOTELabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nOTELabel.Name = "nOTELabel";
            nOTELabel.Size = new System.Drawing.Size(40, 13);
            nOTELabel.TabIndex = 34;
            nOTELabel.Text = "NOTE:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(776, 399);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 23;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(695, 399);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(614, 399);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 21;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(533, 399);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(452, 399);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 19;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(371, 399);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 23);
            this.btn_Find.TabIndex = 18;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            // 
            // btn_Bottom
            // 
            this.btn_Bottom.Location = new System.Drawing.Point(290, 399);
            this.btn_Bottom.Name = "btn_Bottom";
            this.btn_Bottom.Size = new System.Drawing.Size(75, 23);
            this.btn_Bottom.TabIndex = 17;
            this.btn_Bottom.Text = "Bottom";
            this.btn_Bottom.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(209, 399);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 16;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(128, 399);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(75, 23);
            this.btn_Prev.TabIndex = 15;
            this.btn_Prev.Text = "Prev";
            this.btn_Prev.UseVisualStyleBackColor = true;
            // 
            // btn_Top
            // 
            this.btn_Top.Location = new System.Drawing.Point(47, 399);
            this.btn_Top.Name = "btn_Top";
            this.btn_Top.Size = new System.Drawing.Size(75, 23);
            this.btn_Top.TabIndex = 14;
            this.btn_Top.Text = "Top";
            this.btn_Top.UseVisualStyleBackColor = true;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(544, 50);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 13;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Master Supplier";
            // 
            // uASDataSet
            // 
            this.uASDataSet.DataSetName = "UASDataSet";
            this.uASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_supplierBindingSource
            // 
            this.m_supplierBindingSource.DataMember = "m_supplier";
            this.m_supplierBindingSource.DataSource = this.uASDataSet;
            // 
            // m_supplierTableAdapter
            // 
            this.m_supplierTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.m_pelangganTableAdapter = null;
            this.tableAdapterManager.m_supplierTableAdapter = this.m_supplierTableAdapter;
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
            // m_supplierBindingNavigator
            // 
            this.m_supplierBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_supplierBindingNavigator.BindingSource = this.m_supplierBindingSource;
            this.m_supplierBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_supplierBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_supplierBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.m_supplierBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_supplierBindingNavigatorSaveItem});
            this.m_supplierBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_supplierBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_supplierBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_supplierBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_supplierBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_supplierBindingNavigator.Name = "m_supplierBindingNavigator";
            this.m_supplierBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_supplierBindingNavigator.Size = new System.Drawing.Size(907, 31);
            this.m_supplierBindingNavigator.TabIndex = 24;
            this.m_supplierBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(35, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // m_supplierBindingNavigatorSaveItem
            // 
            this.m_supplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_supplierBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_supplierBindingNavigatorSaveItem.Image")));
            this.m_supplierBindingNavigatorSaveItem.Name = "m_supplierBindingNavigatorSaveItem";
            this.m_supplierBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.m_supplierBindingNavigatorSaveItem.Text = "Save Data";
            this.m_supplierBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_supplierBindingNavigatorSaveItem_Click);
            // 
            // p_IDTextBox
            // 
            this.p_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "P_ID", true));
            this.p_IDTextBox.Location = new System.Drawing.Point(102, 135);
            this.p_IDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.Size = new System.Drawing.Size(110, 20);
            this.p_IDTextBox.TabIndex = 25;
            // 
            // bANKTextBox
            // 
            this.bANKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "BANK", true));
            this.bANKTextBox.Location = new System.Drawing.Point(229, 135);
            this.bANKTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bANKTextBox.Name = "bANKTextBox";
            this.bANKTextBox.Size = new System.Drawing.Size(460, 20);
            this.bANKTextBox.TabIndex = 26;
            // 
            // tELP_HPTextBox
            // 
            this.tELP_HPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "TELP_HP", true));
            this.tELP_HPTextBox.Location = new System.Drawing.Point(741, 135);
            this.tELP_HPTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tELP_HPTextBox.Name = "tELP_HPTextBox";
            this.tELP_HPTextBox.Size = new System.Drawing.Size(136, 20);
            this.tELP_HPTextBox.TabIndex = 27;
            // 
            // nAMATextBox
            // 
            this.nAMATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NAMA", true));
            this.nAMATextBox.Location = new System.Drawing.Point(102, 159);
            this.nAMATextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nAMATextBox.Name = "nAMATextBox";
            this.nAMATextBox.Size = new System.Drawing.Size(155, 20);
            this.nAMATextBox.TabIndex = 28;
            // 
            // aLAMATTextBox
            // 
            this.aLAMATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "ALAMAT", true));
            this.aLAMATTextBox.Location = new System.Drawing.Point(323, 159);
            this.aLAMATTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aLAMATTextBox.Name = "aLAMATTextBox";
            this.aLAMATTextBox.Size = new System.Drawing.Size(366, 20);
            this.aLAMATTextBox.TabIndex = 29;
            // 
            // kOTATextBox
            // 
            this.kOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "KOTA", true));
            this.kOTATextBox.Location = new System.Drawing.Point(741, 159);
            this.kOTATextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kOTATextBox.Name = "kOTATextBox";
            this.kOTATextBox.Size = new System.Drawing.Size(136, 20);
            this.kOTATextBox.TabIndex = 30;
            // 
            // nAMA_NPWPTextBox
            // 
            this.nAMA_NPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NAMA_NPWP", true));
            this.nAMA_NPWPTextBox.Location = new System.Drawing.Point(102, 224);
            this.nAMA_NPWPTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nAMA_NPWPTextBox.Name = "nAMA_NPWPTextBox";
            this.nAMA_NPWPTextBox.Size = new System.Drawing.Size(286, 20);
            this.nAMA_NPWPTextBox.TabIndex = 31;
            // 
            // aLAMAT_NPWTextBox
            // 
            this.aLAMAT_NPWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "ALAMAT_NPW", true));
            this.aLAMAT_NPWTextBox.Location = new System.Drawing.Point(102, 248);
            this.aLAMAT_NPWTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aLAMAT_NPWTextBox.Name = "aLAMAT_NPWTextBox";
            this.aLAMAT_NPWTextBox.Size = new System.Drawing.Size(775, 20);
            this.aLAMAT_NPWTextBox.TabIndex = 32;
            // 
            // nPWPTextBox
            // 
            this.nPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NPWP", true));
            this.nPWPTextBox.Location = new System.Drawing.Point(490, 224);
            this.nPWPTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nPWPTextBox.Name = "nPWPTextBox";
            this.nPWPTextBox.Size = new System.Drawing.Size(199, 20);
            this.nPWPTextBox.TabIndex = 33;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(102, 272);
            this.eMAILTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(775, 20);
            this.eMAILTextBox.TabIndex = 34;
            // 
            // nOTETextBox
            // 
            this.nOTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_supplierBindingSource, "NOTE", true));
            this.nOTETextBox.Location = new System.Drawing.Point(102, 318);
            this.nOTETextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nOTETextBox.Name = "nOTETextBox";
            this.nOTETextBox.Size = new System.Drawing.Size(775, 20);
            this.nOTETextBox.TabIndex = 35;
            // 
            // masterSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(nOTELabel);
            this.Controls.Add(this.nOTETextBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(nPWPLabel);
            this.Controls.Add(this.nPWPTextBox);
            this.Controls.Add(aLAMAT_NPWLabel);
            this.Controls.Add(this.aLAMAT_NPWTextBox);
            this.Controls.Add(nAMA_NPWPLabel);
            this.Controls.Add(this.nAMA_NPWPTextBox);
            this.Controls.Add(kOTALabel);
            this.Controls.Add(this.kOTATextBox);
            this.Controls.Add(aLAMATLabel);
            this.Controls.Add(this.aLAMATTextBox);
            this.Controls.Add(nAMALabel);
            this.Controls.Add(this.nAMATextBox);
            this.Controls.Add(tELP_HPLabel);
            this.Controls.Add(this.tELP_HPTextBox);
            this.Controls.Add(bANKLabel);
            this.Controls.Add(this.bANKTextBox);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(this.p_IDTextBox);
            this.Controls.Add(this.m_supplierBindingNavigator);
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
            this.Name = "masterSupplier";
            this.Text = "Master Supplier";
            this.Load += new System.EventHandler(this.masterSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingNavigator)).EndInit();
            this.m_supplierBindingNavigator.ResumeLayout(false);
            this.m_supplierBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_Bottom;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Top;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Label label1;
        private UASDataSet uASDataSet;
        private System.Windows.Forms.BindingSource m_supplierBindingSource;
        private UASDataSetTableAdapters.m_supplierTableAdapter m_supplierTableAdapter;
        private UASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_supplierBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_supplierBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox p_IDTextBox;
        private System.Windows.Forms.TextBox bANKTextBox;
        private System.Windows.Forms.TextBox tELP_HPTextBox;
        private System.Windows.Forms.TextBox nAMATextBox;
        private System.Windows.Forms.TextBox aLAMATTextBox;
        private System.Windows.Forms.TextBox kOTATextBox;
        private System.Windows.Forms.TextBox nAMA_NPWPTextBox;
        private System.Windows.Forms.TextBox aLAMAT_NPWTextBox;
        private System.Windows.Forms.TextBox nPWPTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox nOTETextBox;
    }
}