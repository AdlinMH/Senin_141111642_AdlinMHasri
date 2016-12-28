using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Menu
{
    public partial class Barang : MetroFramework.Forms.MetroForm
    {
        // Database Connection
        MySqlConnection con = new MySqlConnection("server=localhost;database=latihan_pos;Uid=root;Pwd=");
        MySqlDataAdapter DA;
        DataTable DT = new DataTable();
        MySqlCommand query;
        public Barang()
        {
            InitializeComponent();
            this.view_barang();
        }

        private void Barang_Load(object sender, EventArgs e)
        {
            this.barang_kode.Focus();
        }

        public void view_barang()
        {
            query = new MySqlCommand("SELECT * FROM barang", con);
            DA = new MySqlDataAdapter(query);
            DT = new DataTable();
            DA.Fill(DT);
            barang_views.DataSource = DT;
        }

        private void clear_barang()
        {
            this.barang_kode.Text = "";
            this.barang_nama.Text = "";
            this.barang_stock.Text = "";
            this.barang_hargabeli.Text = "";
            this.barang_hargajual.Text = "";

            this.Ekodebarang.Text = "";
            this.Enamabarang.Text = "";
            this.Estockbarang.Text = "";
            this.Ehargabeli.Text = "";
            this.Ehargajual.Text = "";

        }

        private void save_barang_button_Click(object sender, EventArgs e)
        {
            string kodebarang = this.barang_kode.Text;
            string namabarang = this.barang_nama.Text;
            string stockbarang = this.barang_stock.Text;
            string hbelibarang = this.barang_hargabeli.Text;
            string hjualbarang = this.barang_hargajual.Text;
            DateTime datenow = getdatetime();


            query = new MySqlCommand("INSERT INTO barang VALUES( " +
                                     "@id,"+
                                     "@kode, " + 
                                     "@nama," + 
                                     "@jumlah," +
                                     "@hargaBeli," +
                                     "@hargaJual," +
                                     "@created_at," +
                                     "@updated_at)", con);
            query.Parameters.AddWithValue("@id", null);
            query.Parameters.AddWithValue("@kode", kodebarang);
            query.Parameters.AddWithValue("@nama", namabarang);
            query.Parameters.AddWithValue("@jumlah", stockbarang);
            query.Parameters.AddWithValue("@hargaBeli", hbelibarang);
            query.Parameters.AddWithValue("@hargaJual", hjualbarang);
            query.Parameters.AddWithValue("@created_at", datenow);
            query.Parameters.AddWithValue("@updated_at", datenow);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Barang");
                con.Close();
                view_barang();
                clear_barang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        public static DateTime getdatetime()
        {
            DateTime getdatetime = DateTime.UtcNow;
            int year = getdatetime.Year;
            int month = getdatetime.Month;
            int day = getdatetime.Day;
            int hour = getdatetime.Hour;
            int min = getdatetime.Minute;
            int sec = getdatetime.Second;
            DateTime datetime = new DateTime(year, month, day, hour, min, sec);
            return datetime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string kode_param = this.Ekodebarang.Text;
            query = new MySqlCommand("SELECT * FROM barang WHERE kode=@kode", con);
            query.Parameters.AddWithValue("@kode", kode_param);
            MySqlDataReader Reader = query.ExecuteReader();

            if (!Reader.HasRows)
            {
                con.Close();
                MessageBox.Show("Data Tidak Ditemukan");
                return;
            }
            if (Reader.Read())
            {
                this.Enamabarang.Text = Reader["nama"].ToString();
                this.Estockbarang.Text = Reader["jumlah"].ToString();
                this.Ehargabeli.Text = Reader["harga_beli"].ToString();
                this.Ehargajual.Text = Reader["harga_jual"].ToString();
            }
            Reader.Close();
            con.Close();
            //MessageBox.Show(DA..ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kodebarang = this.Ekodebarang.Text;
            string namabarang = this.Enamabarang.Text;
            string stockbarang = this.Estockbarang.Text;
            string hbelibarang = this.Ehargabeli.Text;
            string hjualbarang = this.Ehargajual.Text;
            DateTime datenow = getdatetime();


            query = new MySqlCommand("UPDATE barang SET " +
                    "nama=@nama," +
                    "jumlah=@jumlah, " +
                    "harga_beli=@hargabeli, " +
                    "harga_jual=@hargajual, " +
                    "updated_at=@dateupdate " +
                "WHERE Kode=@kode", con);
            query.Parameters.AddWithValue("@kode", kodebarang);
            query.Parameters.AddWithValue("@nama", namabarang);
            query.Parameters.AddWithValue("@jumlah", stockbarang);
            query.Parameters.AddWithValue("@hargabeli", hbelibarang);
            query.Parameters.AddWithValue("@hargajual", hjualbarang);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Edit Barang");
                con.Close();
                view_barang();
                clear_barang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kodebarang = this.Ekodebarang.Text;

            query = new MySqlCommand("DELETE FROM barang WHERE kode=@kode", con);
            query.Parameters.AddWithValue("@kode", kodebarang);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil dihapus");
                con.Close();
                view_barang();
                clear_barang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
