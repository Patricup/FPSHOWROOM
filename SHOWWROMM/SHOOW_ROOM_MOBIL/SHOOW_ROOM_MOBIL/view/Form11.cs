using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOOW_ROOM_MOBIL.view
{
    public partial class laporandatapenjualan : Form
    {
        public laporandatapenjualan()
        {
            InitializeComponent();
            InisialisasiListView();

        }
        private void InisialisasiListView()
        {
            //mobil
            lvwlaporanpenjualan.View = View.Details;
            lvwlaporanpenjualan.FullRowSelect = true;
            lvwlaporanpenjualan.GridLines = true;
            lvwlaporanpenjualan.Columns.Add("ID MOBIL.", 70, HorizontalAlignment.Center);
            lvwlaporanpenjualan.Columns.Add("ID JENIS", 70, HorizontalAlignment.Center);
            lvwlaporanpenjualan.Columns.Add("WARNA", 70, HorizontalAlignment.Left);
            lvwlaporanpenjualan.Columns.Add("HARGA", 70, HorizontalAlignment.Center);
            lvwlaporanpenjualan.Columns.Add("SPESIFIKASI MESIN", 190, HorizontalAlignment.Left);
            lvwlaporanpenjualan.Columns.Add("MEREK", 70, HorizontalAlignment.Center);
            lvwlaporanpenjualan.Columns.Add("SERI", 70, HorizontalAlignment.Center);
            //transaksi
            lvwlaporanpenjualan.Columns.Add("ID TRANSAKSI", 100, HorizontalAlignment.Center);
            lvwlaporanpenjualan.Columns.Add("ID MOBIL", 100, HorizontalAlignment.Left);
            lvwlaporanpenjualan.Columns.Add("ID JENIS", 100, HorizontalAlignment.Center);
            lvwlaporanpenjualan.Columns.Add("ID PELANGGAN", 100, HorizontalAlignment.Center);
            lvwlaporanpenjualan.Columns.Add("ID PEGAWAI", 100, HorizontalAlignment.Left);
            // PELANGGAN
            lvwlaporanpenjualan.Columns.Add("NAMA", 100, HorizontalAlignment.Left);
            lvwlaporanpenjualan.Columns.Add("ALAMAT", 100, HorizontalAlignment.Center);
            lvwlaporanpenjualan.Columns.Add("NOMOR HP", 100, HorizontalAlignment.Center);
 


        }
        private void laporandatapenjualan_Load(object sender, EventArgs e)
        {

        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
