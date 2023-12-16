namespace SHOOW_ROOM_MOBIL.view
{
    partial class tambahdatapelanggan
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
            button2 = new Button();
            button1 = new Button();
            txtnomorhp = new TextBox();
            txtalamat = new TextBox();
            txtnama = new TextBox();
            txtidpelanggan = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(369, 159);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 32;
            button2.Text = "Keluar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(288, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 31;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtnomorhp
            // 
            txtnomorhp.Location = new Point(194, 130);
            txtnomorhp.Name = "txtnomorhp";
            txtnomorhp.Size = new Size(250, 23);
            txtnomorhp.TabIndex = 26;
            // 
            // txtalamat
            // 
            txtalamat.Location = new Point(194, 98);
            txtalamat.Name = "txtalamat";
            txtalamat.Size = new Size(250, 23);
            txtalamat.TabIndex = 25;
            // 
            // txtnama
            // 
            txtnama.Location = new Point(194, 66);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(250, 23);
            txtnama.TabIndex = 24;
            // 
            // txtidpelanggan
            // 
            txtidpelanggan.Location = new Point(194, 37);
            txtidpelanggan.Name = "txtidpelanggan";
            txtidpelanggan.Size = new Size(250, 23);
            txtidpelanggan.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 66);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 22;
            label7.Text = "NAMA :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 98);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 21;
            label6.Text = "ALAMAT :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 130);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 20;
            label5.Text = "NOMOR HP :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 37);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 17;
            label1.Text = "ID PELANGGAN :";
            // 
            // tambahdatapelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(472, 231);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtnomorhp);
            Controls.Add(txtalamat);
            Controls.Add(txtnama);
            Controls.Add(txtidpelanggan);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "tambahdatapelanggan";
            Text = "Tambah Data Pelanggan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txtnomorhp;
        private TextBox txtalamat;
        private TextBox txtnama;
        private TextBox txtidpelanggan;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
    }
}