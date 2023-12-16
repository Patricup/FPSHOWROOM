namespace SHOOW_ROOM_MOBIL.view
{
    partial class laporandatapelanggan
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
            lvwlaporandatapelanggan = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnkeluar
            // 
            btnkeluar.BackColor = SystemColors.ActiveCaption;
            btnkeluar.Location = new Point(762, 45);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(75, 23);
            btnkeluar.TabIndex = 8;
            btnkeluar.Text = "KELUAR";
            btnkeluar.UseVisualStyleBackColor = false;
            btnkeluar.Click += btnkeluar_Click;
            // 
            // lvwlaporandatapelanggan
            // 
            lvwlaporandatapelanggan.Location = new Point(12, 74);
            lvwlaporandatapelanggan.Name = "lvwlaporandatapelanggan";
            lvwlaporandatapelanggan.Size = new Size(827, 426);
            lvwlaporandatapelanggan.TabIndex = 7;
            lvwlaporandatapelanggan.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(311, 27);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(293, 30);
            label1.TabIndex = 6;
            label1.Text = "LAPORAN DATA PELANGGAN";
            // 
            // laporandatapelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(849, 512);
            Controls.Add(btnkeluar);
            Controls.Add(lvwlaporandatapelanggan);
            Controls.Add(label1);
            Name = "laporandatapelanggan";
            Text = "Laporan Data Pelanggan";
            Load += Form13_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnkeluar;
        private ListView lvwlaporandatapelanggan;
        private Label label1;
    }
}