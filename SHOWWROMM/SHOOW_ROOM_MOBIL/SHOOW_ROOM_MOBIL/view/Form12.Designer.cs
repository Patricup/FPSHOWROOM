namespace SHOOW_ROOM_MOBIL.view
{
    partial class laporandatamobil
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
            lvwlaporandatamobil = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnkeluar
            // 
            btnkeluar.BackColor = SystemColors.ActiveCaption;
            btnkeluar.Location = new Point(764, 44);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(75, 23);
            btnkeluar.TabIndex = 11;
            btnkeluar.Text = "KELUAR";
            btnkeluar.UseVisualStyleBackColor = false;
            btnkeluar.Click += btnkeluar_Click;
            // 
            // lvwlaporandatamobil
            // 
            lvwlaporandatamobil.Location = new Point(12, 73);
            lvwlaporandatamobil.Name = "lvwlaporandatamobil";
            lvwlaporandatamobil.Size = new Size(827, 426);
            lvwlaporandatamobil.TabIndex = 10;
            lvwlaporandatamobil.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(286, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(234, 30);
            label1.TabIndex = 9;
            label1.Text = "LAPORAN DATA MOBIL";
            // 
            // laporandatamobil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(858, 531);
            Controls.Add(btnkeluar);
            Controls.Add(lvwlaporandatamobil);
            Controls.Add(label1);
            Name = "laporandatamobil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laporan Data Mobil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnkeluar;
        private ListView lvwlaporandatamobil;
        private Label label1;
    }
}