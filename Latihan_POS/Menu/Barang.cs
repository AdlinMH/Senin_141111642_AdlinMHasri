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
        public ConnectionModel Ctx = new ConnectionModel();

        public Barang()
        {
            InitializeComponent();
            this.view_barang();
        }

        private void Barang_Load(object sender, EventArgs e)
        {
            this.barang_kode.Focus();
            metroTabControl1.SelectTab(0);
        }

        public void view_barang()
        {
            Ctx.Query = new MySqlCommand("SELECT " +
                                         "kode 'Kode'," +
                                         "nama 'Nama Barang'," +
                                         "jumlah 'Kuantitas'," +
                                         "harga_beli 'Harga Beli'," +
                                         "harga_jual 'Harga Jual'" +
                                     "FROM barang", Ctx.Con);
            Ctx.Da = new MySqlDataAdapter(Ctx.Query);
            Ctx.Dt = new DataTable();
            Ctx.Da.Fill(Ctx.Dt);
            barang_views.DataSource = Ctx.Dt;
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
            DateTime datenow = Getdatetime();


            Ctx.Query = new MySqlCommand("INSERT INTO barang VALUES( " +
                                     "@id,"+
                                     "@kode, " + 
                                     "@nama," + 
                                     "@jumlah," +
                                     "@hargaBeli," +
                                     "@hargaJual," +
                                     "@created_at," +
                                     "@updated_at)", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@id", null);
            Ctx.Query.Parameters.AddWithValue("@kode", kodebarang);
            Ctx.Query.Parameters.AddWithValue("@nama", namabarang);
            Ctx.Query.Parameters.AddWithValue("@jumlah", stockbarang);
            Ctx.Query.Parameters.AddWithValue("@hargaBeli", hbelibarang);
            Ctx.Query.Parameters.AddWithValue("@hargaJual", hjualbarang);
            Ctx.Query.Parameters.AddWithValue("@created_at", datenow);
            Ctx.Query.Parameters.AddWithValue("@updated_at", datenow);

            try
            {
                Ctx.Con.Open();
                Ctx.Query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Barang");
                Ctx.Con.Close();
                view_barang();
                clear_barang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Ctx.Con.Close();
            }

        }

        public static DateTime Getdatetime()
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
            Ctx.Con.Open();
            string kodeParam = this.Ekodebarang.Text;
            Ctx.Query = new MySqlCommand("SELECT * FROM barang WHERE kode=@kode", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@kode", kodeParam);
            MySqlDataReader reader = Ctx.Query.ExecuteReader();

            if (!reader.HasRows)
            {
                Ctx.Con.Close();
                MessageBox.Show("Data Tidak Ditemukan");
                return;
            }
            if (reader.Read())
            {
                this.Enamabarang.Text = reader["nama"].ToString();
                this.Estockbarang.Text = reader["jumlah"].ToString();
                this.Ehargabeli.Text = reader["harga_beli"].ToString();
                this.Ehargajual.Text = reader["harga_jual"].ToString();
            }
            reader.Close();
            Ctx.Con.Close();
            //MessageBox.Show(DA..ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kodebarang = this.Ekodebarang.Text;
            string namabarang = this.Enamabarang.Text;
            string stockbarang = this.Estockbarang.Text;
            string hbelibarang = this.Ehargabeli.Text;
            string hjualbarang = this.Ehargajual.Text;
            DateTime datenow = Getdatetime();


            Ctx.Query = new MySqlCommand("UPDATE barang SET " +
                    "nama=@nama," +
                    "jumlah=@jumlah, " +
                    "harga_beli=@hargabeli, " +
                    "harga_jual=@hargajual, " +
                    "updated_at=@dateupdate " +
                "WHERE Kode=@kode", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@kode", kodebarang);
            Ctx.Query.Parameters.AddWithValue("@nama", namabarang);
            Ctx.Query.Parameters.AddWithValue("@jumlah", stockbarang);
            Ctx.Query.Parameters.AddWithValue("@hargabeli", hbelibarang);
            Ctx.Query.Parameters.AddWithValue("@hargajual", hjualbarang);

            try
            {
                Ctx.Con.Open();
                Ctx.Query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Edit Barang");
                Ctx.Con.Close();
                view_barang();
                clear_barang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Ctx.Con.Close();
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

            Ctx.Query = new MySqlCommand("DELETE FROM barang WHERE kode=@kode", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@kode", kodebarang);

            try
            {
                Ctx.Con.Open();
                Ctx.Query.ExecuteNonQuery();
                MessageBox.Show("Berhasil dihapus");
                Ctx.Con.Close();
                view_barang();
                clear_barang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Ctx.Con.Close();
            }
        }
    }
}
