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
    public partial class laporandatamobil : Form
    {
        public laporandatamobil()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            lvwlaporandatamobil.View = View.Details;
            lvwlaporandatamobil.FullRowSelect = true;
            lvwlaporandatamobil.GridLines = true;
            lvwlaporandatamobil.Columns.Add("ID MOBIL.", 70, HorizontalAlignment.Center);
            lvwlaporandatamobil.Columns.Add("ID JENIS", 70, HorizontalAlignment.Center);
            lvwlaporandatamobil.Columns.Add("WARNA", 70, HorizontalAlignment.Left);
            lvwlaporandatamobil.Columns.Add("HARGA", 70, HorizontalAlignment.Center);
            lvwlaporandatamobil.Columns.Add("SPESIFIKASI MESIN", 190, HorizontalAlignment.Left);
            lvwlaporandatamobil.Columns.Add("MEREK", 70, HorizontalAlignment.Center);
            lvwlaporandatamobil.Columns.Add("SERI", 70, HorizontalAlignment.Center);

        }
        private void btnkeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
