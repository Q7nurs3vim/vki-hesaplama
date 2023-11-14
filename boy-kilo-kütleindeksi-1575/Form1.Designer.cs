namespace boy_kilo_kütleindeksi_1575
{
    partial class Form1
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
            lblKilo = new Label();
            lblBoy = new Label();
            txtKilo = new TextBox();
            txtBoy = new TextBox();
            btnHesapla = new Button();
            lblVki = new Label();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Location = new Point(17, 21);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(72, 20);
            lblKilo.TabIndex = 0;
            lblKilo.Text = "KİLO(kg) :";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Location = new Point(17, 63);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(74, 20);
            lblBoy.TabIndex = 1;
            lblBoy.Text = "BOY(cm) :";
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(122, 18);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(125, 27);
            txtKilo.TabIndex = 2;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(122, 60);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(125, 27);
            txtBoy.TabIndex = 3;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.LimeGreen;
            btnHesapla.Location = new Point(33, 115);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(214, 40);
            btnHesapla.TabIndex = 4;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lblVki
            // 
            lblVki.AutoSize = true;
            lblVki.Location = new Point(17, 179);
            lblVki.Name = "lblVki";
            lblVki.Size = new Size(34, 20);
            lblVki.TabIndex = 6;
            lblVki.Text = "VKİ:";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(19, 217);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(52, 20);
            lblSonuc.TabIndex = 7;
            lblSonuc.Text = "Sonuç:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(288, 325);
            Controls.Add(lblSonuc);
            Controls.Add(lblVki);
            Controls.Add(btnHesapla);
            Controls.Add(txtBoy);
            Controls.Add(txtKilo);
            Controls.Add(lblBoy);
            Controls.Add(lblKilo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKilo;
        private Label lblBoy;
        private TextBox txtKilo;
        private TextBox txtBoy;
        private Button btnHesapla;
        private Label lblVki;
        private Label lblSonuc;
    }
}