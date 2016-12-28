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
        // Database Connection
        MySqlConnection con = new MySqlConnection("server=localhost;database=latihan_pos;Uid=root;Pwd=");
        MySqlDataAdapter DA;
        DataTable DT = new DataTable();
        MySqlCommand query;
        public string ID_costumer;

        public Customer()
        {
            InitializeComponent();
            this.view_customer();
        }

        private void Costumer_Load(object sender, EventArgs e)
        {

        
        }

        public void view_customer()
        {
            query = new MySqlCommand("select * from customer", con);
            DA = new MySqlDataAdapter(query);
            DT = new DataTable();
            DA.Fill(DT);
            barang_views.DataSource = DT;
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
            DateTime datenow = getdatetime();
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
            DateTime datenow = getdatetime();


            query = new MySqlCommand("INSERT INTO customer VALUES(" +
                "@id," +
                "@nama," +
                "@alamat, " +
                "@kota, " +
                "@kodepos, " +
                "@nohp, " +
                "@dateinsert, " +
                "@dateupdate)", con);
            query.Parameters.AddWithValue("@id", null);
            query.Parameters.AddWithValue("@nama", nama);
            query.Parameters.AddWithValue("@alamat", alamat);
            query.Parameters.AddWithValue("@kodepos", kodepos);
            query.Parameters.AddWithValue("@kota", kota);
            query.Parameters.AddWithValue("@nohp", nohp);
            query.Parameters.AddWithValue("@dateinsert", datenow);
            query.Parameters.AddWithValue("@dateupdate", datenow);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Input Customer");
                con.Close();
                view_customer();
                clear_customer();
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

        private void cek_costumer_Click(object sender, EventArgs e)
        {
            con.Open();
            string id_param = this.Eidkostumer.Text;
            query = new MySqlCommand("SELECT * FROM customer WHERE ID=@kode", con);
            query.Parameters.AddWithValue("@kode", id_param);
            MySqlDataReader Reader = query.ExecuteReader();

            if (!Reader.HasRows)
            {
                con.Close();
                MessageBox.Show("Data Tidak Ditemukan");
                return;
            }
            if (Reader.Read())
            {
                this.Enamakostumer.Text = Reader["Nama"].ToString();
                this.Ealamatkostumer.Text = Reader["Alamat"].ToString();
                this.Ekotacustomer.Text = Reader["Kota"].ToString();
                this.Ekodeposcustomer.Text = Reader["kode_pos"].ToString();
                this.Enokostumer.Text = Reader["NoHp"].ToString();
            }
            Reader.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = this.Enamakostumer.Text;
            this.ID_costumer = this.Eidkostumer.Text;
            string alamat = this.Ealamatkostumer.Text;
            string nohp = this.Enokostumer.Text;
            string kota = this.Ekotacustomer.Text;
            string kodepos = this.Ekodeposcustomer.Text;
            DateTime datenow = getdatetime();


            query = new MySqlCommand("UPDATE customer SET " +
                    "Nama=@nama, " +
                    "Alamat=@alamat, " +
                    "kota=@kota, " +
                    "kode_pos=@kodepos, " +
                    "NoHp=@nohp, " +
                    "updated_at=@dateupdate " +
                "WHERE ID=@id", con);
            query.Parameters.AddWithValue("@id", this.ID_costumer);
            query.Parameters.AddWithValue("@nama", nama);
            query.Parameters.AddWithValue("@alamat", alamat);
            query.Parameters.AddWithValue("@kota", kota);
            query.Parameters.AddWithValue("@kodepos", kodepos);
            query.Parameters.AddWithValue("@nohp", nohp);
            query.Parameters.AddWithValue("@dateupdate", datenow);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Customer");
                con.Close();
                view_customer();
                clear_customer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Delete_Customer_Click(object sender, EventArgs e)
        {
            string kodebarang = this.Ekodeposcustomer.Text;

            query = new MySqlCommand("DELETE FROM customer WHERE kode=@kode", con);
            query.Parameters.AddWithValue("@kode", kodebarang);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil dihapus");
                con.Close();
                view_customer();
                clear_customer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
