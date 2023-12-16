namespace SHOOW_ROOM_MOBIL.view
{
    partial class laporandatapenjualan
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
            lvwlaporanpenjualan = new ListView();
            btnkeluar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(476, 34);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(230, 30);
            label1.TabIndex = 0;
            label1.Text = "LAPORAN PENJUALAN";
            label1.Click += label1_Click;
            // 
            // lvwlaporanpenjualan
            // 
            lvwlaporanpenjualan.Location = new Point(12, 70);
            lvwlaporanpenjualan.Name = "lvwlaporanpenjualan";
            lvwlaporanpenjualan.Size = new Size(1173, 435);
            lvwlaporanpenjualan.TabIndex = 1;
            lvwlaporanpenjualan.UseCompatibleStateImageBehavior = false;
            // 
            // btnkeluar
            // 
            btnkeluar.BackColor = SystemColors.ActiveCaption;
            btnkeluar.Location = new Point(1110, 42);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(75, 23);
            btnkeluar.TabIndex = 2;
            btnkeluar.Text = "KELUAR";
            btnkeluar.UseVisualStyleBackColor = false;
            btnkeluar.Click += btnkeluar_Click;
            // 
            // laporandatapenjualan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1197, 580);
            Controls.Add(btnkeluar);
            Controls.Add(lvwlaporanpenjualan);
            Controls.Add(label1);
            Name = "laporandatapenjualan";
            Text = "Laporan Penjualan";
            Load += laporandatapenjualan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvwlaporanpenjualan;
        private Button btnkeluar;
    }
}