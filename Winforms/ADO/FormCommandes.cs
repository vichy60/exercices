﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class FormCommandes : Form
    {
        public FormCommandes()
        {
            InitializeComponent();
            btVoirCom.Click += BtVoirCom_Click;
        }

        private void BtVoirCom_Click(object sender, EventArgs e)
        {
            dgvCom.DataSource = DAL.GetCom( tbComId.Text);
        }
    }
}
