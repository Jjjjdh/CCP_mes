using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormList
{
    public partial class MaterialControl : Services.BaseChildForm
    {
        public MaterialControl()
        {
            InitializeComponent();
        }

        private void btnRgi2_Click(object sender, EventArgs e)
        {
            Material mt = new Material();
            mt.ShowDialog();
            
        }
    }
}
