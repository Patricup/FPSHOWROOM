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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void lIHATMOBILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datamobil DataMobil = new datamobil();
            DataMobil.Show();
        }

        private void lIHATDATAPEGAWAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datapegawai DataPegawai = new datapegawai();
            DataPegawai.Show();
        }

        private void lIHATDATATRANSAKSIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datatransaksi DataTransaksi = new datatransaksi();
            DataTransaksi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambahdatapelanggan TambahDataPelanggan = new tambahdatapelanggan();
            TambahDataPelanggan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lIHATDATAPEMBELIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datapelanggan DataPelanggan = new datapelanggan();
            DataPelanggan.Show();
        }

        private void lAPORANTRANSAKSIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            laporandatapenjualan LaporanDataPenjualan = new laporandatapenjualan();
            LaporanDataPenjualan.Show();
        }

        private void laporanDataPelangganToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            laporandatapelanggan LaporanDataPelanggan = new laporandatapelanggan();
            LaporanDataPelanggan.Show();
        }

        private void laporanDataMobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            laporandatamobil LaporanDataMobil = new laporandatamobil();
            LaporanDataMobil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tambahdatatransaksi TambahDataTransaksi = new tambahdatatransaksi();
            TambahDataTransaksi.Show();
        }
    }
}
