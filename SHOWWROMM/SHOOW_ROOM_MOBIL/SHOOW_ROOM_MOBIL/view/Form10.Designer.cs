namespace SHOOW_ROOM_MOBIL.view
{
    partial class datatransaksi
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
            btncari = new Button();
            lvwdatatransaksi = new ListView();
            txtcariidtransaksi = new TextBox();
            label1 = new Label();
            btntambah = new Button();
            btnperbaiki = new Button();
            btnhapus = new Button();
            btnselesai = new Button();
            SuspendLayout();
            // 
            // btncari
            // 
            btncari.Location = new Point(572, 12);
            btncari.Name = "btncari";
            btncari.Size = new Size(75, 23);
            btncari.TabIndex = 0;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = true;
            // 
            // lvwdatatransaksi
            // 
            lvwdatatransaksi.Location = new Point(12, 41);
            lvwdatatransaksi.Name = "lvwdatatransaksi";
            lvwdatatransaksi.Size = new Size(635, 400);
            lvwdatatransaksi.TabIndex = 1;
            lvwdatatransaksi.UseCompatibleStateImageBehavior = false;
            // 
            // txtcariidtransaksi
            // 
            txtcariidtransaksi.Location = new Point(132, 13);
            txtcariidtransaksi.Name = "txtcariidtransaksi";
            txtcariidtransaksi.Size = new Size(434, 23);
            txtcariidtransaksi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 3;
            label1.Text = "Cari Id Transaksi";
            // 
            // btntambah
            // 
            btntambah.Location = new Point(653, 41);
            btntambah.Name = "btntambah";
            btntambah.Size = new Size(126, 40);
            btntambah.TabIndex = 7;
            btntambah.Text = "Tambah";
            btntambah.UseVisualStyleBackColor = true;
            btntambah.Click += btntambah_Click;
            // 
            // btnperbaiki
            // 
            btnperbaiki.Location = new Point(653, 87);
            btnperbaiki.Name = "btnperbaiki";
            btnperbaiki.Size = new Size(126, 40);
            btnperbaiki.TabIndex = 8;
            btnperbaiki.Text = "Perbaiki";
            btnperbaiki.UseVisualStyleBackColor = true;
            // 
            // btnhapus
            // 
            btnhapus.Location = new Point(653, 133);
            btnhapus.Name = "btnhapus";
            btnhapus.Size = new Size(126, 40);
            btnhapus.TabIndex = 9;
            btnhapus.Text = "Hapus";
            btnhapus.UseVisualStyleBackColor = true;
            // 
            // btnselesai
            // 
            btnselesai.Location = new Point(653, 179);
            btnselesai.Name = "btnselesai";
            btnselesai.Size = new Size(126, 40);
            btnselesai.TabIndex = 10;
            btnselesai.Text = "Selesai";
            btnselesai.UseVisualStyleBackColor = true;
            btnselesai.Click += btnselesai_Click;
            // 
            // datatransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(782, 450);
            Controls.Add(btnselesai);
            Controls.Add(btnhapus);
            Controls.Add(btnperbaiki);
            Controls.Add(btntambah);
            Controls.Add(label1);
            Controls.Add(txtcariidtransaksi);
            Controls.Add(lvwdatatransaksi);
            Controls.Add(btncari);
            Name = "datatransaksi";
            Text = "Data Transaksi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncari;
        private ListView lvwdatatransaksi;
        private TextBox txtcariidtransaksi;
        private Label label1;
        private Button btntambah;
        private Button btnperbaiki;
        private Button btnhapus;
        private Button btnselesai;
    }
}