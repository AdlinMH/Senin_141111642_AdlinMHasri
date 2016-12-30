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
    public partial class Supplier :  MetroFramework.Forms.MetroForm
    {
        public ConnectionModel Ctx = new ConnectionModel();
        public string IdSupplier;

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

        public Supplier()
        {
            InitializeComponent();
            this.view_supplier();
        }

        private void update_supllier_Click(object sender, EventArgs e)
        {
            string kode = this.Ekodesupllier.Text;
            string nama = this.Enamasupllier.Text;
            string alamat = this.Ealamatsupllier.Text;
            string nohp = this.Enosupllier.Text;
            string kota = this.Ekotasupllier.Text;
            DateTime datenow = Getdatetime();


            Ctx.Query = new MySqlCommand("UPDATE supplier SET Nama=@nama, Alamat=@alamat, Kota=@kota, Contact=@nohp, Edit_at=@dateupdate WHERE ID=@id", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@id", this.IdSupplier);
            Ctx.Query.Parameters.AddWithValue("@kode", kode);
            Ctx.Query.Parameters.AddWithValue("@nama", nama);
            Ctx.Query.Parameters.AddWithValue("@alamat", alamat);
            Ctx.Query.Parameters.AddWithValue("@kota", kota);
            Ctx.Query.Parameters.AddWithValue("@nohp", nohp);
            Ctx.Query.Parameters.AddWithValue("@dateupdate", datenow);

            try
            {
                Ctx.Con.Open();
                Ctx.Query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Edit Supplier");
                Ctx.Con.Close();
                view_supplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Ctx.Con.Close();
            }
        }

        public void view_supplier()
        {
            Ctx.Query = new MySqlCommand("select * from supplier", Ctx.Con);
            Ctx.Da = new MySqlDataAdapter(Ctx.Query);
            Ctx.Dt = new DataTable();
            Ctx.Da.Fill(Ctx.Dt);
            supplier_views.DataSource = Ctx.Dt;
        }

        private void simpan_supplier_Click(object sender, EventArgs e)
        {
            string kode = this.kodesupllier.Text;
            string nama = this.namasupllier.Text;
            string alamat = this.alamatsupllier.Text;
            string nohp = this.nosupllier.Text;
            string kota = this.kotasupllier.Text;
            DateTime datenow = Getdatetime();


            Ctx.Query = new MySqlCommand("INSERT INTO supplier VALUES(@id,@kode, @nama,@alamat, @kota, @nohp,  @dateinsert, @datejoin, @dateupdate)", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@id", null);
            Ctx.Query.Parameters.AddWithValue("@kode", kode);
            Ctx.Query.Parameters.AddWithValue("@nama", nama);
            Ctx.Query.Parameters.AddWithValue("@alamat", alamat);
            Ctx.Query.Parameters.AddWithValue("@kota", kota);
            Ctx.Query.Parameters.AddWithValue("@nohp", nohp);
            Ctx.Query.Parameters.AddWithValue("@dateinsert", datenow);
            Ctx.Query.Parameters.AddWithValue("@datejoin", datenow);
            Ctx.Query.Parameters.AddWithValue("@dateupdate", null);

            try
            {
                Ctx.Con.Open();
                Ctx.Query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Input Supplier");
                Ctx.Con.Close();
                view_supplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Ctx.Con.Close();
            }
        }

        private void cek_supllier_Click(object sender, EventArgs e)
        {
            Ctx.Con.Open();
            string kodeParam = this.Ekodesupllier.Text;
            Ctx.Query = new MySqlCommand("SELECT " +
                                         "kode 'Kode'," +
                                         "nama 'Nama Supplier'," +
                                         "alamat 'Alamat'," +
                                         "kota 'Kota'," +
                                         "Contact 'No Telepon'" +
                                     "FROM supplier WHERE kode=@kode", Ctx.Con);
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
                this.IdSupplier = reader["id"].ToString();
                this.Enamasupllier.Text = reader["nama"].ToString();
                this.Ealamatsupllier.Text = reader["alamat"].ToString();
                this.Enosupllier.Text = reader["contact"].ToString();
                this.Ekotasupllier.Text = reader["kota"].ToString();
            }
            reader.Close();
            Ctx.Con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Ctx.Query = new MySqlCommand("DELETE FROM supplier WHERE ID=@id", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@id", this.IdSupplier);

            try
            {
                Ctx.Con.Open();
                Ctx.Query.ExecuteNonQuery();
                this.Enamasupllier.Text = null;
                this.Ekodesupllier.Text = null;
                this.Ealamatsupllier.Text = null;
                this.Enosupllier.Text = null;
                this.Ekotasupllier.Text = null;
                MessageBox.Show("Data Berhasil di Hapus");
                Ctx.Con.Close();
                view_supplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Ctx.Con.Close();
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            kodesupllier.Focus();
        }
    }
}
