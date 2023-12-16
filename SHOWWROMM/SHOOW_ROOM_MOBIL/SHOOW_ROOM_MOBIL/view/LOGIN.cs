using SHOOW_ROOM_MOBIL.view;

namespace SHOOW_ROOM_MOBIL
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            txtpass.UseSystemPasswordChar = true;
        }
       
        private void btnkeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;
            if (username == "admin" && password == "admin")
            {

                MessageBox.Show("Login Berhasil");
                menu Menu = new menu();
                Menu.Show();
            }
            else if ((txtuser.Text == "") && (txtpass.Text == ""))
            {
                MessageBox.Show("Username dan password tidak boleh kosong");
            }
            else
            {
                MessageBox.Show("Username dan Password Yang Anda Masukan Salah");
            }
        }

        private void ceklis_CheckedChanged_1(object sender, EventArgs e)
        {
               {
            if (ceklis.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }
        }
    }
}