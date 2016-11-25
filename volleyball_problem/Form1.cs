using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        private const long maxNum = 1000000007;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                long scoreA = long.Parse(ScoreA.Text);
                long scoreB = long.Parse(ScoreB.Text);
                Result.Text = Kalkulasi(scoreA, scoreB).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Input tidak valid");
                ScoreA.Text = "";
                ScoreB.Text = "";
            }
        }

        public static long Kalkulasi(long scoreA, long scoreB)
        {
            if (scoreA < scoreB)
                return Kalkulasi(scoreB, scoreA);
            if (scoreA >= (scoreB + 2) && scoreA == 25)
                return Kombinasi((scoreA + scoreB) - 1, scoreB);
            else if (scoreA == (scoreB + 2) && scoreA >= 26)
                return Kombinasi(48, 24) * Pow(2, (scoreB - 24)) % maxNum;
            else
                return 0;
        }

        public static long Kombinasi(long n, long r)
        {
            long hasil = 1;
            for (long i = 0; i < (n - r); i++)
            {
                hasil = hasil * (n - i) / (i + 1);
            }
            return hasil % maxNum;
        }

        public static long Pow(long b, long n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return b;
            long halfn = Pow(b, n / 2);
            if (n % 2 == 0)
                return (halfn * halfn) % maxNum;
            else
                return ((halfn * halfn) % maxNum) * b;
        }
    }
}
