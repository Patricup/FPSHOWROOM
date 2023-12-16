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
    public partial class datamobil : Form
    {
        public datamobil()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            lvwdatamobil.View = View.Details;
            lvwdatamobil.FullRowSelect = true;
            lvwdatamobil.GridLines = true;
            lvwdatamobil.Columns.Add("ID MOBIL.", 70, HorizontalAlignment.Center);
            lvwdatamobil.Columns.Add("ID JENIS", 70, HorizontalAlignment.Center);
            lvwdatamobil.Columns.Add("WARNA", 70, HorizontalAlignment.Left);
            lvwdatamobil.Columns.Add("HARGA", 70, HorizontalAlignment.Center);
            lvwdatamobil.Columns.Add("SPESIFIKASI MESIN", 190, HorizontalAlignment.Left);
            lvwdatamobil.Columns.Add("MEREK", 70, HorizontalAlignment.Center);
            lvwdatamobil.Columns.Add("SERI", 70, HorizontalAlignment.Center);
        }
        // method untuk menampilkan semua data mobil
        /*private void LoadDataMobil()
        {
            // kosongkan listview
            lvwdatamobil.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfMahasiswa = controller.ReadAll();

            // ekstrak objek mhs dari collection
            foreach (var mhs in listOfMahasiswa)
            {
                var noUrut = lvwdatamobil.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Npm);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Angkatan);

                // tampilkan data mhs ke listview
                lvwdatamobil.Items.Add(item);
            }
        }*/

        private void btntambah_Click(object sender, EventArgs e)
        {
            tambahdatamobil TambahDataMobil = new tambahdatamobil();
            TambahDataMobil.Show();
        }

        private void btnselesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
