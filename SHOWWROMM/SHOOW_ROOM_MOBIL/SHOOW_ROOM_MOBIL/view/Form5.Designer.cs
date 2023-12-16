namespace SHOOW_ROOM_MOBIL.view
{
    partial class tambahdatapegawai
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
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            txtnama = new TextBox();
            txtnomorhp = new TextBox();
            SuspendLayout();
            // 
            // btnkeluar
            // 
            btnkeluar.Location = new Point(362, 159);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(75, 23);
            btnkeluar.TabIndex = 32;
            btnkeluar.Text = "Keluar";
            btnkeluar.UseVisualStyleBackColor = true;
            btnkeluar.Click += btnkeluar_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(278, 159);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(75, 23);
            btnsimpan.TabIndex = 31;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            // 
            // txtpegawai
            // 
            txtpegawai.Location = new Point(187, 43);
            txtpegawai.Name = "txtpegawai";
            txtpegawai.Size = new Size(250, 23);
            txtpegawai.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 72);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 22;
            label7.Text = "NAMA :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 104);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 21;
            label6.Text = "NOMOR HP :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 43);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 17;
            label1.Text = "ID PEGAWAI :";
            // 
            // txtnama
            // 
            txtnama.Location = new Point(187, 72);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(250, 23);
            txtnama.TabIndex = 24;
            // 
            // txtnomorhp
            // 
            txtnomorhp.Location = new Point(187, 104);
            txtnomorhp.Name = "txtnomorhp";
            txtnomorhp.Size = new Size(250, 23);
            txtnomorhp.TabIndex = 25;
            // 
            // tambahdatapegawai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(492, 202);
            Controls.Add(btnkeluar);
            Controls.Add(btnsimpan);
            Controls.Add(txtnomorhp);
            Controls.Add(txtnama);
            Controls.Add(txtpegawai);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "tambahdatapegawai";
            Text = "Tambah Data Pegawai";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnkeluar;
        private Button btnsimpan;
        private TextBox txtpegawai;
        private Label label7;
        private Label label6;
        private Label label1;
        private TextBox txtnama;
        private TextBox txtnomorhp;
    }
}