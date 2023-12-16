namespace SHOOW_ROOM_MOBIL.view
{
    partial class tambahdatamobil
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtmobil = new TextBox();
            txtwarna = new TextBox();
            txtharga = new TextBox();
            txtspekmesin = new TextBox();
            txtmerek = new TextBox();
            txtseri = new TextBox();
            label8 = new Label();
            txtjenis = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 41);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "MOBIL :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-58, -60);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "WARNA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 197);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "SERI :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 165);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "MEREK :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 134);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 4;
            label5.Text = "SPESIFIKASI MESIN :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 102);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 5;
            label6.Text = "HARGA :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 70);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 6;
            label7.Text = "WARNA :";
            // 
            // txtmobil
            // 
            txtmobil.Location = new Point(185, 41);
            txtmobil.Name = "txtmobil";
            txtmobil.Size = new Size(250, 23);
            txtmobil.TabIndex = 7;
            // 
            // txtwarna
            // 
            txtwarna.Location = new Point(185, 70);
            txtwarna.Name = "txtwarna";
            txtwarna.Size = new Size(250, 23);
            txtwarna.TabIndex = 8;
            // 
            // txtharga
            // 
            txtharga.Location = new Point(185, 102);
            txtharga.Name = "txtharga";
            txtharga.Size = new Size(250, 23);
            txtharga.TabIndex = 9;
            // 
            // txtspekmesin
            // 
            txtspekmesin.Location = new Point(185, 134);
            txtspekmesin.Name = "txtspekmesin";
            txtspekmesin.Size = new Size(250, 23);
            txtspekmesin.TabIndex = 10;
            // 
            // txtmerek
            // 
            txtmerek.Location = new Point(185, 165);
            txtmerek.Name = "txtmerek";
            txtmerek.Size = new Size(250, 23);
            txtmerek.TabIndex = 11;
            // 
            // txtseri
            // 
            txtseri.Location = new Point(185, 197);
            txtseri.Name = "txtseri";
            txtseri.Size = new Size(250, 23);
            txtseri.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 226);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 13;
            label8.Text = "JENIS :";
            // 
            // txtjenis
            // 
            txtjenis.Location = new Point(185, 226);
            txtjenis.Name = "txtjenis";
            txtjenis.Size = new Size(250, 23);
            txtjenis.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(279, 271);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(360, 271);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Keluar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tambahdatamobil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(470, 306);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtjenis);
            Controls.Add(label8);
            Controls.Add(txtseri);
            Controls.Add(txtmerek);
            Controls.Add(txtspekmesin);
            Controls.Add(txtharga);
            Controls.Add(txtwarna);
            Controls.Add(txtmobil);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "tambahdatamobil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tambah Data Mobil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtmobil;
        private TextBox txtwarna;
        private TextBox txtharga;
        private TextBox txtspekmesin;
        private TextBox txtmerek;
        private TextBox txtseri;
        private Label label8;
        private TextBox txtjenis;
        private Button button1;
        private Button button2;
    }
}