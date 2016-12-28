using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Latihan_POS.Menu;

namespace Latihan_POS
{
    public partial class Form1 : Form
    {
        private ListForm lsForm = null;
        private Barang brgForm = null;
        private Customer cusForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cusForm == null)
            {
                cusForm = new Customer();
                cusForm.MdiParent = this;
            }
            cusForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cusForm == null)
            {
                brgForm = new Barang();
                brgForm.MdiParent = this;
            }
            brgForm.Show();
        }
    }
}
