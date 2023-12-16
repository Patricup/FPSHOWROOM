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
    public partial class datapegawai : Form
    {
        public datapegawai()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            lvwdatapegawai.View = View.Details;
            lvwdatapegawai.FullRowSelect = true;
            lvwdatapegawai.GridLines = true;
            lvwdatapegawai.Columns.Add("ID PEGAWAI.", 100, HorizontalAlignment.Center);
            lvwdatapegawai.Columns.Add("NAMA", 100, HorizontalAlignment.Center);
            lvwdatapegawai.Columns.Add("NOMOR HP", 100, HorizontalAlignment.Left);

        }
        private void btntambah_Click(object sender, EventArgs e)
        {
            tambahdatapegawai TambahDataPegawai = new tambahdatapegawai();
            TambahDataPegawai.Show();
        }

        private void btnselesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datapegawai_Load(object sender, EventArgs e)
        {

        }
    }
}
