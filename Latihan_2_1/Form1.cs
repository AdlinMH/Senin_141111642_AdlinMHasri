using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public enum Bulan : byte
        {
            Januari = 1,
            Februari = 2,
            Maret = 3,
            April = 4,
            Mei = 5,
            Juni = 6,
            Juli = 7,
            Agustus = 8,
            September = 9,
            Oktober = 10,
            Nopember = 11,
            Desember = 12
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set maximum and minimum value for numTanggal
            numTanggal.Minimum = 1;
            numTanggal.Maximum = 31;
            numTanggal.Value = 1;

            //set collection of domainBulan
            domainBulan.Items.Add(Bulan.Januari);
            domainBulan.Items.Add(Bulan.Februari);
            domainBulan.Items.Add(Bulan.Maret);
            domainBulan.Items.Add(Bulan.April);
            domainBulan.Items.Add(Bulan.Mei);
            domainBulan.Items.Add(Bulan.Juni);
            domainBulan.Items.Add(Bulan.Juli);
            domainBulan.Items.Add(Bulan.Agustus);
            domainBulan.Items.Add(Bulan.September);
            domainBulan.Items.Add(Bulan.Oktober);
            domainBulan.Items.Add(Bulan.Nopember);
            domainBulan.Items.Add(Bulan.Desember);

            //every birth date, set bold date
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(1995, 9, 18));

            //every Saturday and Sunday in 2016, set bold date
            for (DateTime i = new DateTime(2016, 1, 1); i.Year < 2017; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar1.AddBoldedDate(i);
                }
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Bulan bulan;
            if (Enum.TryParse(domainBulan.Text, out bulan))
            {
                monthCalendar1.AddAnnuallyBoldedDate(new DateTime(DateTime.Now.Year, (int) bulan,
                    Convert.ToInt32(numTanggal.Value)));
                monthCalendar1.UpdateBoldedDates();
            }
            else
            {
                MessageBox.Show(@"Bulan terpilih tidak valid");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var selectedDate = monthCalendar1.SelectionStart;

                monthCalendar1.RemoveAnnuallyBoldedDate(selectedDate);
                monthCalendar1.UpdateBoldedDates();
            }
        }

    }


