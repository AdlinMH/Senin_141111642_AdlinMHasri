using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBar1.Value >= hScrollBar2.Value)
            {
                hScrollBar2.Value = hScrollBar1.Value;
                lblMaxValue.Text = hScrollBar2.Value.ToString();
            }
            lblMinValue.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBar2.Value <= hScrollBar1.Value)
            {
                hScrollBar1.Value = hScrollBar2.Value;
                lblMinValue.Text = hScrollBar1.Value.ToString();
            }
            lblMaxValue.Text = hScrollBar2.Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int value  = dateTimePicker1.Value.Year;
            int result = DateTime.Now.Year - value;
            lblUmur.Text = "Umur   : " + result.ToString();
            
            if (result > hScrollBar1.Value && result < hScrollBar2.Value)
                lblKet.Text = "Umur kamu " + result + " berada dalam range " + hScrollBar1.Value + " dan " + hScrollBar2.Value;
            else if (value > DateTime.Now.Year)
                lblKet.Text = "Kamu belum lahir!";
            else
                lblKet.Text = "Pilihlah sesuai dengan dalam range!";
        }

        private void lblUmur_Click(object sender, EventArgs e)
        {

        }       
    }
}