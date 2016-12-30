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
        private Barang _brgForm = null;
        private Customer _cusForm = null;
        private Supplier _supForm = null;
        private Transaksi _tranForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            if (_tranForm == null)
            {
                _tranForm = new Transaksi { MdiParent = this };
                _tranForm.Show();
                _tranForm = null;
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (_cusForm == null)
            {
                _brgForm = new Barang();
                _brgForm.MdiParent = this;
                _brgForm.Show();
                _brgForm = null;
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

            if (_cusForm == null)
            {
                _cusForm = new Customer();
                _cusForm.MdiParent = this;
                _cusForm.Show();
                _cusForm = null;
            }
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (_supForm == null)
            {
                _supForm = new Supplier { MdiParent = this };
                _supForm.Show();
                _supForm = null;
            }
        }
    }
}
