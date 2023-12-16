namespace SHOOW_ROOM_MOBIL
{
    partial class LOGIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnlogin = new Button();
            txtuser = new TextBox();
            btnkeluar = new Button();
            txtpass = new TextBox();
            ceklis = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(159, 44);
            label1.Name = "label1";
            label1.Size = new Size(129, 50);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(118, 244);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(97, 23);
            btnlogin.TabIndex = 1;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click_1;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(118, 123);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(210, 23);
            txtuser.TabIndex = 2;
            // 
            // btnkeluar
            // 
            btnkeluar.Location = new Point(236, 244);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(92, 23);
            btnkeluar.TabIndex = 3;
            btnkeluar.Text = "Cancel";
            btnkeluar.UseVisualStyleBackColor = true;
            btnkeluar.Click += btnkeluar_Click;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(118, 190);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(210, 23);
            txtpass.TabIndex = 4;
            // 
            // ceklis
            // 
            ceklis.AutoSize = true;
            ceklis.Location = new Point(118, 219);
            ceklis.Name = "ceklis";
            ceklis.Size = new Size(133, 19);
            ceklis.TabIndex = 5;
            ceklis.Text = "Tampilkan Password";
            ceklis.UseVisualStyleBackColor = true;
            ceklis.CheckedChanged += ceklis_CheckedChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(118, 99);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 166);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(450, 345);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ceklis);
            Controls.Add(txtpass);
            Controls.Add(btnkeluar);
            Controls.Add(txtuser);
            Controls.Add(btnlogin);
            Controls.Add(label1);
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnlogin;
        private TextBox txtuser;
        private Button btnkeluar;
        private TextBox txtpass;
        private CheckBox ceklis;
        private Label label2;
        private Label label3;
    }
}