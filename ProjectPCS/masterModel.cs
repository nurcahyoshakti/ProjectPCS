﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPCS
{
    public partial class masterModel : Form
    {
        public masterModel()
        {
            InitializeComponent();
        }

        private void m_modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void masterModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_model' table. You can move, or remove it, as needed.
            this.m_modelTableAdapter.Fill(this.uASDataSet.m_model);

        }
    }
}
