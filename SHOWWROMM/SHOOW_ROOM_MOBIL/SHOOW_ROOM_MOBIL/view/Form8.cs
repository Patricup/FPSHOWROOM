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
    public partial class datapelanggan : Form
    {
        public datapelanggan()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            lvwdatapelanggan.View = View.Details;
            lvwdatapelanggan.FullRowSelect = true;
            lvwdatapelanggan.GridLines = true;
            lvwdatapelanggan.Columns.Add("ID PElANGGAN.", 100, HorizontalAlignment.Center);
            lvwdatapelanggan.Columns.Add("NAMA", 100, HorizontalAlignment.Center);
            lvwdatapelanggan.Columns.Add("ALAMAT", 100, HorizontalAlignment.Left);
            lvwdatapelanggan.Columns.Add("NOMOR HP", 100, HorizontalAlignment.Left);

        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            tambahdatapelanggan TambahDataPelanggan = new tambahdatapelanggan();
            TambahDataPelanggan.Show();
        }

        private void btnselesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
