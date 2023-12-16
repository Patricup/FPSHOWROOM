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
    public partial class datatransaksi : Form
    {
        public datatransaksi()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            lvwdatatransaksi.View = View.Details;
            lvwdatatransaksi.FullRowSelect = true;
            lvwdatatransaksi.GridLines = true;
            lvwdatatransaksi.Columns.Add("ID TRANSAKSI", 90, HorizontalAlignment.Center);
            lvwdatatransaksi.Columns.Add("ID MOBIL", 70, HorizontalAlignment.Center);
            lvwdatatransaksi.Columns.Add("ID JENIS", 70, HorizontalAlignment.Left);
            lvwdatatransaksi.Columns.Add("ID PELANGGAN", 90, HorizontalAlignment.Center);
            lvwdatatransaksi.Columns.Add("ID PEGAWAI", 90, HorizontalAlignment.Left);
          
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            tambahdatatransaksi TambahDataTransaksi = new tambahdatatransaksi();
            TambahDataTransaksi.Show();
        }

        private void btnselesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
