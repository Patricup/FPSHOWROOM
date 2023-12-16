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
    public partial class laporandatapelanggan : Form
    {
        public laporandatapelanggan()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            lvwlaporandatapelanggan.View = View.Details;
            lvwlaporandatapelanggan.FullRowSelect = true;
            lvwlaporandatapelanggan.GridLines = true;
            lvwlaporandatapelanggan.Columns.Add("ID PELANGGAN.", 100, HorizontalAlignment.Center);
            lvwlaporandatapelanggan.Columns.Add("NAMA", 70, HorizontalAlignment.Center);
            lvwlaporandatapelanggan.Columns.Add("ALAMAT", 70, HorizontalAlignment.Left);
            lvwlaporandatapelanggan.Columns.Add("NOMOR HP", 70, HorizontalAlignment.Center);
           

        }
        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
