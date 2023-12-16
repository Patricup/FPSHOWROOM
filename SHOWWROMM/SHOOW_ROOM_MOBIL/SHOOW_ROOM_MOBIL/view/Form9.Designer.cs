namespace SHOOW_ROOM_MOBIL.view
{
    partial class tambahdatatransaksi
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
            btnkeluar = new Button();
            btnsimpan = new Button();
            txtpegawai = new TextBox();
            txtpelanggan = new TextBox();
            txtidjenis = new TextBox();
            txtidmobil = new TextBox();
            txtidtransaksi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnkeluar
            // 
            btnkeluar.Location = new Point(420, 200);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(75, 23);
            btnkeluar.TabIndex = 32;
            btnkeluar.Text = "Keluar";
            btnkeluar.UseVisualStyleBackColor = true;
            btnkeluar.Click += btnkeluar_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(339, 200);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(75, 23);
            btnsimpan.TabIndex = 31;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            // 
            // txtpegawai
            // 
            txtpegawai.Location = new Point(177, 154);
            txtpegawai.Name = "txtpegawai";
            txtpegawai.Size = new Size(318, 23);
            txtpegawai.TabIndex = 27;
            // 
            // txtpelanggan
            // 
            txtpelanggan.Location = new Point(177, 123);
            txtpelanggan.Name = "txtpelanggan";
            txtpelanggan.Size = new Size(318, 23);
            txtpelanggan.TabIndex = 26;
            // 
            // txtidjenis
            // 
            txtidjenis.Location = new Point(177, 91);
            txtidjenis.Name = "txtidjenis";
            txtidjenis.Size = new Size(318, 23);
            txtidjenis.TabIndex = 25;
            // 
            // txtidmobil
            // 
            txtidmobil.Location = new Point(177, 59);
            txtidmobil.Name = "txtidmobil";
            txtidmobil.Size = new Size(318, 23);
            txtidmobil.TabIndex = 24;
            // 
            // txtidtransaksi
            // 
            txtidtransaksi.Location = new Point(177, 30);
            txtidtransaksi.Name = "txtidtransaksi";
            txtidtransaksi.Size = new Size(318, 23);
            txtidtransaksi.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 59);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 22;
            label7.Text = "ID MOBIL :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 91);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 21;
            label6.Text = "ID JENIS :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 123);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 20;
            label5.Text = "ID PELANGGAN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 154);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 19;
            label4.Text = "PEGAWAI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 17;
            label1.Text = "ID TRANSAKSI :";
            // 
            // tambahdatatransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(512, 254);
            Controls.Add(btnkeluar);
            Controls.Add(btnsimpan);
            Controls.Add(txtpegawai);
            Controls.Add(txtpelanggan);
            Controls.Add(txtidjenis);
            Controls.Add(txtidmobil);
            Controls.Add(txtidtransaksi);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "tambahdatatransaksi";
            Text = "Tambah Data Transaksi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnkeluar;
        private Button btnsimpan;
        private TextBox txtpegawai;
        private TextBox txtpelanggan;
        private TextBox txtidjenis;
        private TextBox txtidmobil;
        private TextBox txtidtransaksi;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
    }
}