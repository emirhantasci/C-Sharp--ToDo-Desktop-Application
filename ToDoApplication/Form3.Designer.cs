
namespace ToDoApplication
{
    partial class Form3
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
            this.txtKayitIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKayitMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKayitId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKayitSifreTekrar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKayitMailTekrar = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSoru = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKayitIsim
            // 
            this.txtKayitIsim.Location = new System.Drawing.Point(155, 59);
            this.txtKayitIsim.Name = "txtKayitIsim";
            this.txtKayitIsim.Size = new System.Drawing.Size(191, 27);
            this.txtKayitIsim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim-Soyisim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-Mail Tekrar";
            // 
            // txtKayitMail
            // 
            this.txtKayitMail.Location = new System.Drawing.Point(155, 150);
            this.txtKayitMail.Name = "txtKayitMail";
            this.txtKayitMail.Size = new System.Drawing.Size(191, 27);
            this.txtKayitMail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // txtKayitId
            // 
            this.txtKayitId.Location = new System.Drawing.Point(155, 104);
            this.txtKayitId.Name = "txtKayitId";
            this.txtKayitId.Size = new System.Drawing.Size(191, 27);
            this.txtKayitId.TabIndex = 1;
            this.txtKayitId.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre";
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Location = new System.Drawing.Point(155, 247);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.Size = new System.Drawing.Size(191, 27);
            this.txtKayitSifre.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şifre Tekrar";
            // 
            // txtKayitSifreTekrar
            // 
            this.txtKayitSifreTekrar.Location = new System.Drawing.Point(155, 294);
            this.txtKayitSifreTekrar.Name = "txtKayitSifreTekrar";
            this.txtKayitSifreTekrar.Size = new System.Drawing.Size(191, 27);
            this.txtKayitSifreTekrar.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-Mail";
            // 
            // txtKayitMailTekrar
            // 
            this.txtKayitMailTekrar.Location = new System.Drawing.Point(155, 198);
            this.txtKayitMailTekrar.Name = "txtKayitMailTekrar";
            this.txtKayitMailTekrar.Size = new System.Drawing.Size(191, 27);
            this.txtKayitMailTekrar.TabIndex = 3;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(41, 427);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(305, 36);
            this.btnKayitOl.TabIndex = 8;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(41, 469);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(305, 43);
            this.btnGeriDon.TabIndex = 9;
            this.btnGeriDon.Text = "Zaten Hesabım Var";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gizli Soru";
            // 
            // cmbSoru
            // 
            this.cmbSoru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoru.FormattingEnabled = true;
            this.cmbSoru.Items.AddRange(new object[] {
            "En sevdiğin renk",
            "En sevdiğin şehir",
            "Favori mesleğin",
            "Favori öğretmeninin adı",
            "İlk aşkının adı"});
            this.cmbSoru.Location = new System.Drawing.Point(155, 338);
            this.cmbSoru.Name = "cmbSoru";
            this.cmbSoru.Size = new System.Drawing.Size(191, 28);
            this.cmbSoru.Sorted = true;
            this.cmbSoru.TabIndex = 6;
            this.cmbSoru.UseWaitCursor = true;
            this.cmbSoru.SelectedIndexChanged += new System.EventHandler(this.cmbSoru_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gizli Cevap";
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(155, 379);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(191, 27);
            this.txtCevap.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Boş kısımları doldurunuz.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 538);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSoru);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKayitMailTekrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKayitSifreTekrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKayitSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKayitId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKayitMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKayitIsim);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKayitIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKayitMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKayitId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKayitSifreTekrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKayitMailTekrar;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSoru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Label label9;
    }
}