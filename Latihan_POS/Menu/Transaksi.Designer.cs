namespace Latihan_POS.Menu
{
    partial class Transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cek_supplier = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.simpan = new System.Windows.Forms.Button();
            this.hargatotal_pembelian = new System.Windows.Forms.TextBox();
            this.hargabeli_pembelian = new System.Windows.Forms.TextBox();
            this.kuantiti_pembelian = new System.Windows.Forms.TextBox();
            this.kodesupplier_pembelian = new System.Windows.Forms.TextBox();
            this.kodebarang_pembelian = new System.Windows.Forms.TextBox();
            this.cekcustomer_jual = new System.Windows.Forms.Button();
            this.cekbarang_jual = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.hargatotal_penjualan = new System.Windows.Forms.TextBox();
            this.hargajual_penjualan = new System.Windows.Forms.TextBox();
            this.kuantiti_penjualan = new System.Windows.Forms.TextBox();
            this.idcostumer_penjualan = new System.Windows.Forms.TextBox();
            this.kode_penjualan = new System.Windows.Forms.TextBox();
            this.kode_barang_penjualan = new System.Windows.Forms.TextBox();
            this.kode_pembelian = new System.Windows.Forms.TextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.string_supplier = new System.Windows.Forms.TextBox();
            this.string_barang = new System.Windows.Forms.TextBox();
            this.views_data = new System.Windows.Forms.DataGridView();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.string_customer_jual = new System.Windows.Forms.TextBox();
            this.string_barang_jual = new System.Windows.Forms.TextBox();
            this.views_penjualan = new System.Windows.Forms.DataGridView();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.views_data)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.views_penjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // cek_supplier
            // 
            this.cek_supplier.Location = new System.Drawing.Point(381, 78);
            this.cek_supplier.Name = "cek_supplier";
            this.cek_supplier.Size = new System.Drawing.Size(41, 23);
            this.cek_supplier.TabIndex = 4;
            this.cek_supplier.Text = "Cek";
            this.cek_supplier.UseVisualStyleBackColor = true;
            this.cek_supplier.Click += new System.EventHandler(this.cek_supplier_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(381, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Cek";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(329, 138);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(93, 41);
            this.simpan.TabIndex = 8;
            this.simpan.Text = "Tambah";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // hargatotal_pembelian
            // 
            this.hargatotal_pembelian.Location = new System.Drawing.Point(160, 159);
            this.hargatotal_pembelian.Name = "hargatotal_pembelian";
            this.hargatotal_pembelian.ReadOnly = true;
            this.hargatotal_pembelian.Size = new System.Drawing.Size(137, 20);
            this.hargatotal_pembelian.TabIndex = 7;
            this.hargatotal_pembelian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hargabeli_pembelian
            // 
            this.hargabeli_pembelian.Location = new System.Drawing.Point(160, 134);
            this.hargabeli_pembelian.Name = "hargabeli_pembelian";
            this.hargabeli_pembelian.ReadOnly = true;
            this.hargabeli_pembelian.Size = new System.Drawing.Size(137, 20);
            this.hargabeli_pembelian.TabIndex = 6;
            this.hargabeli_pembelian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // kuantiti_pembelian
            // 
            this.kuantiti_pembelian.Location = new System.Drawing.Point(160, 107);
            this.kuantiti_pembelian.Name = "kuantiti_pembelian";
            this.kuantiti_pembelian.ReadOnly = true;
            this.kuantiti_pembelian.Size = new System.Drawing.Size(56, 20);
            this.kuantiti_pembelian.TabIndex = 5;
            this.kuantiti_pembelian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.kuantiti_pembelian.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kuantiti_pembelian_KeyUp);
            // 
            // kodesupplier_pembelian
            // 
            this.kodesupplier_pembelian.Location = new System.Drawing.Point(160, 79);
            this.kodesupplier_pembelian.Name = "kodesupplier_pembelian";
            this.kodesupplier_pembelian.ReadOnly = true;
            this.kodesupplier_pembelian.Size = new System.Drawing.Size(56, 20);
            this.kodesupplier_pembelian.TabIndex = 3;
            // 
            // kodebarang_pembelian
            // 
            this.kodebarang_pembelian.Location = new System.Drawing.Point(160, 51);
            this.kodebarang_pembelian.Name = "kodebarang_pembelian";
            this.kodebarang_pembelian.Size = new System.Drawing.Size(56, 20);
            this.kodebarang_pembelian.TabIndex = 1;
            // 
            // cekcustomer_jual
            // 
            this.cekcustomer_jual.Location = new System.Drawing.Point(376, 76);
            this.cekcustomer_jual.Name = "cekcustomer_jual";
            this.cekcustomer_jual.Size = new System.Drawing.Size(41, 23);
            this.cekcustomer_jual.TabIndex = 14;
            this.cekcustomer_jual.Text = "Cek";
            this.cekcustomer_jual.UseVisualStyleBackColor = true;
            this.cekcustomer_jual.Click += new System.EventHandler(this.cekcustomer_jual_Click);
            // 
            // cekbarang_jual
            // 
            this.cekbarang_jual.Location = new System.Drawing.Point(376, 48);
            this.cekbarang_jual.Name = "cekbarang_jual";
            this.cekbarang_jual.Size = new System.Drawing.Size(41, 23);
            this.cekbarang_jual.TabIndex = 12;
            this.cekbarang_jual.Text = "Cek";
            this.cekbarang_jual.UseVisualStyleBackColor = true;
            this.cekbarang_jual.Click += new System.EventHandler(this.cekbarang_jual_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(324, 138);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 41);
            this.button6.TabIndex = 18;
            this.button6.Text = "Tambah";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // hargatotal_penjualan
            // 
            this.hargatotal_penjualan.Location = new System.Drawing.Point(160, 159);
            this.hargatotal_penjualan.Name = "hargatotal_penjualan";
            this.hargatotal_penjualan.ReadOnly = true;
            this.hargatotal_penjualan.Size = new System.Drawing.Size(135, 20);
            this.hargatotal_penjualan.TabIndex = 17;
            this.hargatotal_penjualan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hargajual_penjualan
            // 
            this.hargajual_penjualan.Location = new System.Drawing.Point(160, 134);
            this.hargajual_penjualan.Name = "hargajual_penjualan";
            this.hargajual_penjualan.ReadOnly = true;
            this.hargajual_penjualan.Size = new System.Drawing.Size(135, 20);
            this.hargajual_penjualan.TabIndex = 16;
            this.hargajual_penjualan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // kuantiti_penjualan
            // 
            this.kuantiti_penjualan.Location = new System.Drawing.Point(160, 107);
            this.kuantiti_penjualan.Name = "kuantiti_penjualan";
            this.kuantiti_penjualan.ReadOnly = true;
            this.kuantiti_penjualan.Size = new System.Drawing.Size(54, 20);
            this.kuantiti_penjualan.TabIndex = 15;
            this.kuantiti_penjualan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.kuantiti_penjualan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kuantiti_penjualan_KeyUp);
            // 
            // idcostumer_penjualan
            // 
            this.idcostumer_penjualan.Location = new System.Drawing.Point(160, 79);
            this.idcostumer_penjualan.Name = "idcostumer_penjualan";
            this.idcostumer_penjualan.ReadOnly = true;
            this.idcostumer_penjualan.Size = new System.Drawing.Size(54, 20);
            this.idcostumer_penjualan.TabIndex = 13;
            // 
            // kode_penjualan
            // 
            this.kode_penjualan.Location = new System.Drawing.Point(160, 23);
            this.kode_penjualan.Name = "kode_penjualan";
            this.kode_penjualan.Size = new System.Drawing.Size(54, 20);
            this.kode_penjualan.TabIndex = 9;
            // 
            // kode_barang_penjualan
            // 
            this.kode_barang_penjualan.Location = new System.Drawing.Point(160, 51);
            this.kode_barang_penjualan.Name = "kode_barang_penjualan";
            this.kode_barang_penjualan.Size = new System.Drawing.Size(54, 20);
            this.kode_barang_penjualan.TabIndex = 10;
            // 
            // kode_pembelian
            // 
            this.kode_pembelian.Location = new System.Drawing.Point(160, 23);
            this.kode_pembelian.Name = "kode_pembelian";
            this.kode_pembelian.Size = new System.Drawing.Size(56, 20);
            this.kode_pembelian.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(2, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(521, 430);
            this.metroTabControl1.TabIndex = 4;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.string_supplier);
            this.metroTabPage1.Controls.Add(this.string_barang);
            this.metroTabPage1.Controls.Add(this.views_data);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.cek_supplier);
            this.metroTabPage1.Controls.Add(this.kodebarang_pembelian);
            this.metroTabPage1.Controls.Add(this.button5);
            this.metroTabPage1.Controls.Add(this.simpan);
            this.metroTabPage1.Controls.Add(this.hargatotal_pembelian);
            this.metroTabPage1.Controls.Add(this.hargabeli_pembelian);
            this.metroTabPage1.Controls.Add(this.kuantiti_pembelian);
            this.metroTabPage1.Controls.Add(this.kodesupplier_pembelian);
            this.metroTabPage1.Controls.Add(this.kode_pembelian);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(513, 391);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Pembelian";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // string_supplier
            // 
            this.string_supplier.Location = new System.Drawing.Point(226, 79);
            this.string_supplier.Name = "string_supplier";
            this.string_supplier.ReadOnly = true;
            this.string_supplier.Size = new System.Drawing.Size(149, 20);
            this.string_supplier.TabIndex = 36;
            // 
            // string_barang
            // 
            this.string_barang.Location = new System.Drawing.Point(226, 51);
            this.string_barang.Name = "string_barang";
            this.string_barang.ReadOnly = true;
            this.string_barang.Size = new System.Drawing.Size(149, 20);
            this.string_barang.TabIndex = 36;
            // 
            // views_data
            // 
            this.views_data.AllowUserToAddRows = false;
            this.views_data.AllowUserToDeleteRows = false;
            this.views_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.views_data.Location = new System.Drawing.Point(3, 195);
            this.views_data.Name = "views_data";
            this.views_data.Size = new System.Drawing.Size(507, 173);
            this.views_data.TabIndex = 35;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 160);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Sub Total";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 135);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Harga Beli";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(21, 108);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 35;
            this.metroLabel4.Text = "Kuantitas";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 79);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "Kode Supplier";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 48);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Kode Barang";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Kode Pembelian";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.string_customer_jual);
            this.metroTabPage2.Controls.Add(this.string_barang_jual);
            this.metroTabPage2.Controls.Add(this.views_penjualan);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.metroLabel11);
            this.metroTabPage2.Controls.Add(this.metroLabel12);
            this.metroTabPage2.Controls.Add(this.metroLabel13);
            this.metroTabPage2.Controls.Add(this.metroLabel14);
            this.metroTabPage2.Controls.Add(this.cekcustomer_jual);
            this.metroTabPage2.Controls.Add(this.cekbarang_jual);
            this.metroTabPage2.Controls.Add(this.button6);
            this.metroTabPage2.Controls.Add(this.hargatotal_penjualan);
            this.metroTabPage2.Controls.Add(this.hargajual_penjualan);
            this.metroTabPage2.Controls.Add(this.kuantiti_penjualan);
            this.metroTabPage2.Controls.Add(this.kode_barang_penjualan);
            this.metroTabPage2.Controls.Add(this.idcostumer_penjualan);
            this.metroTabPage2.Controls.Add(this.kode_penjualan);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(513, 391);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Penjualan";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // string_customer_jual
            // 
            this.string_customer_jual.Location = new System.Drawing.Point(221, 79);
            this.string_customer_jual.Name = "string_customer_jual";
            this.string_customer_jual.ReadOnly = true;
            this.string_customer_jual.Size = new System.Drawing.Size(149, 20);
            this.string_customer_jual.TabIndex = 61;
            // 
            // string_barang_jual
            // 
            this.string_barang_jual.Location = new System.Drawing.Point(221, 51);
            this.string_barang_jual.Name = "string_barang_jual";
            this.string_barang_jual.ReadOnly = true;
            this.string_barang_jual.Size = new System.Drawing.Size(149, 20);
            this.string_barang_jual.TabIndex = 62;
            // 
            // views_penjualan
            // 
            this.views_penjualan.AllowUserToAddRows = false;
            this.views_penjualan.AllowUserToDeleteRows = false;
            this.views_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.views_penjualan.Location = new System.Drawing.Point(3, 196);
            this.views_penjualan.Name = "views_penjualan";
            this.views_penjualan.Size = new System.Drawing.Size(507, 173);
            this.views_penjualan.TabIndex = 55;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(19, 160);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(62, 19);
            this.metroLabel9.TabIndex = 55;
            this.metroLabel9.Text = "Sub Total";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(19, 135);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(71, 19);
            this.metroLabel10.TabIndex = 56;
            this.metroLabel10.Text = "Harga Jual";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(19, 108);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(60, 19);
            this.metroLabel11.TabIndex = 57;
            this.metroLabel11.Text = "Kuantitas";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(19, 79);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(82, 19);
            this.metroLabel12.TabIndex = 58;
            this.metroLabel12.Text = "ID Customer";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(19, 48);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(85, 19);
            this.metroLabel13.TabIndex = 59;
            this.metroLabel13.Text = "Kode Barang";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(19, 23);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(98, 19);
            this.metroLabel14.TabIndex = 60;
            this.metroLabel14.Text = "Kode Penjualan";
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 500);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.views_data)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.views_penjualan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cek_supplier;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.TextBox hargatotal_pembelian;
        private System.Windows.Forms.TextBox hargabeli_pembelian;
        private System.Windows.Forms.TextBox kuantiti_pembelian;
        private System.Windows.Forms.TextBox kodesupplier_pembelian;
        private System.Windows.Forms.TextBox kodebarang_pembelian;
        private System.Windows.Forms.TextBox kode_pembelian;
        private System.Windows.Forms.Button cekcustomer_jual;
        private System.Windows.Forms.Button cekbarang_jual;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox hargatotal_penjualan;
        private System.Windows.Forms.TextBox hargajual_penjualan;
        private System.Windows.Forms.TextBox kuantiti_penjualan;
        private System.Windows.Forms.TextBox idcostumer_penjualan;
        private System.Windows.Forms.TextBox kode_penjualan;
        private System.Windows.Forms.TextBox kode_barang_penjualan;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView views_data;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView views_penjualan;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.TextBox string_supplier;
        private System.Windows.Forms.TextBox string_barang;
        private System.Windows.Forms.TextBox string_customer_jual;
        private System.Windows.Forms.TextBox string_barang_jual;

    }
}