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
    public partial class Customer : MetroFramework.Forms.MetroForm
    {
        public ConnectionModel Ctx = new ConnectionModel();
        public string IdCostumer;

        public Customer()
        {
            InitializeComponent();
            this.view_customer();
        }

        private void Costumer_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(0);
        
        }

        public void view_customer()
        {
            Ctx.Query = new MySqlCommand("select * from customer", Ctx.Con);
            Ctx.Da = new MySqlDataAdapter(Ctx.Query);
            Ctx.Dt = new DataTable();
            Ctx.Da.Fill(Ctx.Dt);
            barang_views.DataSource = Ctx.Dt;
        }

        public void clear_customer()
        {
            this.namakostumer.Text = "";
            this.alamatkostumer.Text = "";
            this.nokostumer.Text = "";
            this.kotacustomer.Text = "";
            this.kodeposcustomer.Text = "";

            this.Enamakostumer.Text = "";
            this.Eidkostumer.Text = "";
            this.Ealamatkostumer.Text = "";
            this.Enokostumer.Text = "";
            this.Ekotacustomer.Text = "";
            this.Ekodeposcustomer.Text = "";
            DateTime datenow = Getdatetime();
        }

        private void barang_views_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_customer_button_Click(object sender, EventArgs e)
        {
            string nama = this.namakostumer.Text;
            string alamat = this.alamatkostumer.Text;
            string nohp = this.nokostumer.Text;
            string kota = this.kotacustomer.Text;
            string kodepos = this.kodeposcustomer.Text;
            DateTime datenow = Getdatetime();


            Ctx.Query = new MySqlCommand("INSERT INTO customer VALUES(" +
                "@id," +
                "@nama," +
                "@alamat, " +
                "@kota, " +
                "@kodepos, " +
                "@nohp, " +
                "@dateinsert, " +
                "@dateupdate)", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@id", null);
            Ctx.Query.Parameters.AddWithValue("@nama", nama);
            Ctx.Query.Parameters.AddWithValue("@alamat", alamat);
            Ctx.Query.Parameters.AddWithValue("@kodepos", kodepos);
            Ctx.Query.Parameters.AddWithValue("@kota", kota);
            Ctx.Query.Parameters.AddWithValue("@nohp", nohp);
            Ctx.Query.Parameters.AddWithValue("@dateinsert", datenow);
            Ctx.Query.Parameters.AddWithValue("@dateupdate", datenow);

            try
            {
                Ctx.Con.Open();
                Ctx.Query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Input Customer");
                Ctx.Con.Close();
                view_customer();
                clear_customer();
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

        private void cek_costumer_Click(object sender, EventArgs e)
        {
            Ctx.Con.Open();
            string idParam = this.Eidkostumer.Text;
            Ctx.Query = new MySqlCommand("SELECT " +
                                         "ID 'Kode'," +
                                         "nama 'Nama Customer'," +
                                         "alamat 'Alamat'," +
                                         "kota 'Kota'," +
                                         "kode_pos 'Kode Pos'," +
                                         "noHp 'No Telepon'" +
                                      "FROM customer WHERE ID=@kode", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@kode", idParam);
            MySqlDataReader reader = Ctx.Query.ExecuteReader();

            if (!reader.HasRows)
            {
                Ctx.Con.Close();
                MessageBox.Show("Data Tidak Ditemukan");
                return;
            }
            if (reader.Read())
            {
                this.Enamakostumer.Text = reader["Nama"].ToString();
                this.Ealamatkostumer.Text = reader["Alamat"].ToString();
                this.Ekotacustomer.Text = reader["Kota"].ToString();
                this.Ekodeposcustomer.Text = reader["kode_pos"].ToString();
                this.Enokostumer.Text = reader["NoHp"].ToString();
            }
            reader.Close();
            Ctx.Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = this.Enamakostumer.Text;
            this.IdCostumer = this.Eidkostumer.Text;
            string alamat = this.Ealamatkostumer.Text;
            string nohp = this.Enokostumer.Text;
            string kota = this.Ekotacustomer.Text;
            string kodepos = this.Ekodeposcustomer.Text;
            DateTime datenow = Getdatetime();


            Ctx.Query = new MySqlCommand("UPDATE customer SET " +
                    "Nama=@nama, " +
                    "Alamat=@alamat, " +
                    "kota=@kota, " +
                    "kode_pos=@kodepos, " +
                    "NoHp=@nohp, " +
                    "updated_at=@dateupdate " +
                "WHERE ID=@id", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@id", this.IdCostumer);
            Ctx.Query.Parameters.AddWithValue("@nama", nama);
            Ctx.Query.Parameters.AddWithValue("@alamat", alamat);
            Ctx.Query.Parameters.AddWithValue("@kota", kota);
            Ctx.Query.Parameters.AddWithValue("@kodepos", kodepos);
            Ctx.Query.Parameters.AddWithValue("@nohp", nohp);
            Ctx.Query.Parameters.AddWithValue("@dateupdate", datenow);

            try
            {
                Ctx.Con.Open();
                Ctx.Query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Customer");
                Ctx.Con.Close();
                view_customer();
                clear_customer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Ctx.Con.Close();
            }
        }

        private void Delete_Customer_Click(object sender, EventArgs e)
        {
            string kodebarang = this.Ekodeposcustomer.Text;

            Ctx.Query = new MySqlCommand("DELETE FROM customer WHERE kode=@kode", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@kode", kodebarang);

            try
            {
                Ctx.Con.Open();
                Ctx.Query.ExecuteNonQuery();
                MessageBox.Show("Berhasil dihapus");
                Ctx.Con.Close();
                view_customer();
                clear_customer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Ctx.Con.Close();
            }
        }
    }
}
