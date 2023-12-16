namespace SHOOW_ROOM_MOBIL.view
{
    partial class datapelanggan
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
            btnselesai = new Button();
            btnhapus = new Button();
            btnperbaiki = new Button();
            btntambah = new Button();
            label1 = new Label();
            txtcariidpelanggan = new TextBox();
            lvwdatapelanggan = new ListView();
            btncari = new Button();
            SuspendLayout();
            // 
            // btnselesai
            // 
            btnselesai.Location = new Point(658, 178);
            btnselesai.Name = "btnselesai";
            btnselesai.Size = new Size(126, 40);
            btnselesai.TabIndex = 18;
            btnselesai.Text = "Selesai";
            btnselesai.UseVisualStyleBackColor = true;
            btnselesai.Click += btnselesai_Click;
            // 
            // btnhapus
            // 
            btnhapus.Location = new Point(658, 132);
            btnhapus.Name = "btnhapus";
            btnhapus.Size = new Size(126, 40);
            btnhapus.TabIndex = 17;
            btnhapus.Text = "Hapus";
            btnhapus.UseVisualStyleBackColor = true;
            // 
            // btnperbaiki
            // 
            btnperbaiki.Location = new Point(658, 86);
            btnperbaiki.Name = "btnperbaiki";
            btnperbaiki.Size = new Size(126, 40);
            btnperbaiki.TabIndex = 16;
            btnperbaiki.Text = "Perbaiki";
            btnperbaiki.UseVisualStyleBackColor = true;
            // 
            // btntambah
            // 
            btntambah.Location = new Point(658, 40);
            btntambah.Name = "btntambah";
            btntambah.Size = new Size(126, 40);
            btntambah.TabIndex = 15;
            btntambah.Text = "Tambah";
            btntambah.UseVisualStyleBackColor = true;
            btntambah.Click += btntambah_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 14;
            label1.Text = "Cari Id Pelanggan";
            // 
            // txtcariidpelanggan
            // 
            txtcariidpelanggan.Location = new Point(137, 12);
            txtcariidpelanggan.Name = "txtcariidpelanggan";
            txtcariidpelanggan.Size = new Size(434, 23);
            txtcariidpelanggan.TabIndex = 13;
            // 
            // lvwdatapelanggan
            // 
            lvwdatapelanggan.Location = new Point(17, 40);
            lvwdatapelanggan.Name = "lvwdatapelanggan";
            lvwdatapelanggan.Size = new Size(635, 400);
            lvwdatapelanggan.TabIndex = 12;
            lvwdatapelanggan.UseCompatibleStateImageBehavior = false;
            // 
            // btncari
            // 
            btncari.Location = new Point(577, 11);
            btncari.Name = "btncari";
            btncari.Size = new Size(75, 23);
            btncari.TabIndex = 11;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = true;
            // 
            // datapelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnselesai);
            Controls.Add(btnhapus);
            Controls.Add(btnperbaiki);
            Controls.Add(btntambah);
            Controls.Add(label1);
            Controls.Add(txtcariidpelanggan);
            Controls.Add(lvwdatapelanggan);
            Controls.Add(btncari);
            Name = "datapelanggan";
            Text = "Data Pelanggan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnselesai;
        private Button btnhapus;
        private Button btnperbaiki;
        private Button btntambah;
        private Label label1;
        private TextBox txtcariidpelanggan;
        private ListView lvwdatapelanggan;
        private Button btncari;
    }
}