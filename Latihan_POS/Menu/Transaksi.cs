using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS.Menu
{
    public partial class Transaksi : MetroFramework.Forms.MetroForm
    {
        public ConnectionModel Ctx = new ConnectionModel();

        //Pembelian
        public string KdPembelian;
        public string IdBarangPembelian;
        public string IdSupplierPembelian;
        public int Kuantiti;
        public double Hasil;

        //Pejualan
        public string KdPenjualan;
        public string IdBarangPejualan;
        public string IdCustomerPenjualan;
        public int KuantitiJual;
        public double HasilPenjualan;

        public Transaksi()
        {
            InitializeComponent();
            this.views_method();
            this.views_method_penjualan();
        }

        public void views_method()
        {
            Ctx.Query = new MySqlCommand("SELECT " +
                                             "pd.id, " +
                                             "p.kode," +
                                             " s.nama as Nama_Supplier, " +
                                             "b.nama as Nama_Barang, " +
                                             "pd.harga_barang, " +
                                             "pd.kuantitas " +
                                         "FROM pembelian as p, " +
                                             "pembelian_detail as pd, " +
                                             "supplier as s, " +
                                             "barang as b " +
                                         "WHERE p.kode=pd.kode_pembelian " +
                                             "AND pd.id_barang=b.id " +
                                             "AND p.id_supplier=s.id", Ctx.Con);
            Ctx.Da = new MySqlDataAdapter(Ctx.Query);
            Ctx.Dt = new DataTable();
            Ctx.Da.Fill(Ctx.Dt);
            views_data.DataSource = Ctx.Dt;
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ctx.Con.Open();
            string kodeParam = this.kodebarang_pembelian.Text;
            Ctx.Query = new MySqlCommand("select * from barang where kode=@kode", Ctx.Con);
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
                this.IdBarangPembelian = reader["id"].ToString();
                this.string_barang.Text = reader["nama"].ToString();
                this.hargabeli_pembelian.Text = Convert.ToInt32(reader["harga_beli"]).ToString("D");
                this.kodesupplier_pembelian.ReadOnly = false;
            }
            reader.Close();
            Ctx.Con.Close();
        }

        private void cek_supplier_Click(object sender, EventArgs e)
        {
            Ctx.Con.Open();
            string kodeParam = this.kodesupplier_pembelian.Text;
            Ctx.Query = new MySqlCommand("select * from supplier where Kode=@kode", Ctx.Con);
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
                this.IdSupplierPembelian = reader["id"].ToString();
                this.string_supplier.Text = reader["nama"].ToString();
                this.kuantiti_pembelian.ReadOnly = false;
            }
            reader.Close();
            Ctx.Con.Close();
        }

        private void kuantiti_pembelian_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.kuantiti_pembelian.Text == "")
                return;
            try
            {
                Kuantiti = Convert.ToInt32(kuantiti_pembelian.Text);
                Hasil = (double)this.Kuantiti * Convert.ToInt32(hargabeli_pembelian.Text);
                hargatotal_pembelian.Text = this.Hasil.ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                this.kuantiti_pembelian.Text = null;
            }
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            Ctx.Con.Open();
            string kodeParam = this.kode_pembelian.Text;
            this.KdPembelian = kodeParam;
            if (kodeParam == null) return;
            Ctx.Query = new MySqlCommand("select * from pembelian where Kode=@kode", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@kode", kodeParam);
            MySqlDataReader reader = Ctx.Query.ExecuteReader();
            DateTime datenow = Getdatetime();

            if (!reader.HasRows)
            {
                Ctx.Con.Close();
                Ctx.Query = new MySqlCommand("INSERT INTO pembelian SET kode=@kode, id_supplier=@idsupplier, created_at=@dateinsert, updated_at=@dateupdate", Ctx.Con);
                Ctx.Query.Parameters.AddWithValue("@kode", kodeParam);
                Ctx.Query.Parameters.AddWithValue("@idsupplier", this.IdSupplierPembelian);
                Ctx.Query.Parameters.AddWithValue("@dateinsert", datenow);
                Ctx.Query.Parameters.AddWithValue("@dateupdate", datenow);

                try
                {
                    Ctx.Con.Open();
                    Ctx.Query.ExecuteNonQuery();
                    Ctx.Con.Close();

                    Ctx.Query = new MySqlCommand("INSERT INTO pembelian_detail SET kode_pembelian=@kd_beli, id_barang=@idbarang, harga_barang=@hargabarang, kuantitas=@kuantiti, created_at=@dateinsert, updated_at=@dateupdate", Ctx.Con);
                    Ctx.Query.Parameters.AddWithValue("@kd_beli", this.KdPembelian);
                    Ctx.Query.Parameters.AddWithValue("@idbarang", this.IdBarangPembelian);
                    Ctx.Query.Parameters.AddWithValue("@kuantiti", this.kuantiti_pembelian.Text);
                    Ctx.Query.Parameters.AddWithValue("@hargabarang", this.hargabeli_pembelian.Text);
                    Ctx.Query.Parameters.AddWithValue("@dateinsert", datenow);
                    Ctx.Query.Parameters.AddWithValue("@dateupdate", datenow);

                    try
                    {
                        Ctx.Con.Open();
                        Ctx.Query.ExecuteNonQuery();
                        MessageBox.Show("Berhasil Input Data Pembelian");
                        this.views_method();
                        Ctx.Con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Ctx.Con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Ctx.Con.Close();
                }
                //MessageBox.Show("Data Tidak Ditemukan");
                //return;
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

        private void cekbarang_jual_Click(object sender, EventArgs e)
        {
            Ctx.Con.Open();
            string kodeParam = this.kode_barang_penjualan.Text;
            Ctx.Query = new MySqlCommand("select * from barang where kode=@kode", Ctx.Con);
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
                this.IdBarangPejualan = reader["id"].ToString();
                this.string_barang_jual.Text = reader["nama"].ToString();
                this.hargajual_penjualan.Text = Convert.ToInt32(reader["harga_jual"]).ToString("D");
                this.idcostumer_penjualan.ReadOnly = false;
            }
            reader.Close();
            Ctx.Con.Close();
        }

        public void views_method_penjualan()
        {
            Ctx.Query = new MySqlCommand("SELECT pd.id, p.kode, c.nama as Nama_Customer, b.nama as Nama_Barang, pd.harga_barang, pd.kuantitas FROM penjualan as p, penjualan_detail as pd, customer as c, barang as b WHERE p.kode=pd.kode_penjualan AND pd.id_barang=b.id AND p.id_customer=c.id", Ctx.Con);
            Ctx.Da = new MySqlDataAdapter(Ctx.Query);
            Ctx.Dt = new DataTable();
            Ctx.Da.Fill(Ctx.Dt);
            views_penjualan.DataSource = Ctx.Dt;
        }

        private void cekcustomer_jual_Click(object sender, EventArgs e)
        {
            Ctx.Con.Open();
            string kodeParam = this.idcostumer_penjualan.Text;
            Ctx.Query = new MySqlCommand("select * from customer where id=@id", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@id", kodeParam);
            MySqlDataReader reader = Ctx.Query.ExecuteReader();

            if (!reader.HasRows)
            {
                Ctx.Con.Close();
                MessageBox.Show("Data Tidak Ditemukan");
                return;
            }
            if (reader.Read())
            {
                this.IdCustomerPenjualan = reader["id"].ToString();
                this.string_customer_jual.Text = reader["nama"].ToString();
                this.kuantiti_penjualan.ReadOnly = false;
            }
            reader.Close();
            Ctx.Con.Close();
        }

        private void kuantiti_penjualan_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.kuantiti_penjualan.Text == "")
                return;
            try
            {
                this.KuantitiJual = Convert.ToInt32(this.kuantiti_penjualan.Text);
                this.HasilPenjualan = (double)this.KuantitiJual * Convert.ToInt32(this.hargajual_penjualan.Text);
                this.hargatotal_penjualan.Text = this.HasilPenjualan.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                this.kuantiti_penjualan.Text = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ctx.Con.Open();
            string kodeParam = this.kode_penjualan.Text;
            this.KdPenjualan = kodeParam;
            if (kodeParam == null) return;
            Ctx.Query = new MySqlCommand("select * from penjualan where Kode=@kode", Ctx.Con);
            Ctx.Query.Parameters.AddWithValue("@kode", kodeParam);
            MySqlDataReader reader = Ctx.Query.ExecuteReader();
            DateTime datenow = Getdatetime();

            if (!reader.HasRows)
            {
                Ctx.Con.Close();
                Ctx.Query = new MySqlCommand("INSERT INTO penjualan SET kode=@kode, id_customer=@idcustomer, created_at=@dateinsert, updated_at=@dateupdate", Ctx.Con);
                Ctx.Query.Parameters.AddWithValue("@kode", kodeParam);
                Ctx.Query.Parameters.AddWithValue("@idcustomer", this.IdCustomerPenjualan);
                Ctx.Query.Parameters.AddWithValue("@dateinsert", datenow);
                Ctx.Query.Parameters.AddWithValue("@dateupdate", datenow);

                try
                {
                    Ctx.Con.Open();
                    Ctx.Query.ExecuteNonQuery();
                    Ctx.Con.Close();

                    Ctx.Query = new MySqlCommand("INSERT INTO penjualan_detail SET kode_penjualan=@kd_jual, id_barang=@idbarang, harga_barang=@hargabarang, kuantitas=@kuantiti, created_at=@dateinsert, updated_at=@dateupdate", Ctx.Con);
                    Ctx.Query.Parameters.AddWithValue("@kd_jual", this.KdPenjualan);
                    Ctx.Query.Parameters.AddWithValue("@idbarang", this.IdBarangPejualan);
                    Ctx.Query.Parameters.AddWithValue("@kuantiti", this.kuantiti_penjualan.Text);
                    Ctx.Query.Parameters.AddWithValue("@hargabarang", this.hargajual_penjualan.Text);
                    Ctx.Query.Parameters.AddWithValue("@dateinsert", datenow);
                    Ctx.Query.Parameters.AddWithValue("@dateupdate", datenow);

                    try
                    {
                        Ctx.Con.Open();
                        Ctx.Query.ExecuteNonQuery();
                        MessageBox.Show("Berhasil Input Data Penjualan");
                        this.views_method_penjualan();
                        Ctx.Con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Ctx.Con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Ctx.Con.Close();
                }
                //MessageBox.Show("Data Tidak Ditemukan");
                //return;
            }
        }
    }
}
