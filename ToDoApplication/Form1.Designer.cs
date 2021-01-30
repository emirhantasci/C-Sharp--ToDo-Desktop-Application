
namespace ToDoApplication
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chcSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnSifre = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 27);
            this.txtId.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(109, 67);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(125, 27);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // chcSifreyiGoster
            // 
            this.chcSifreyiGoster.AutoSize = true;
            this.chcSifreyiGoster.Location = new System.Drawing.Point(109, 101);
            this.chcSifreyiGoster.Name = "chcSifreyiGoster";
            this.chcSifreyiGoster.Size = new System.Drawing.Size(119, 24);
            this.chcSifreyiGoster.TabIndex = 2;
            this.chcSifreyiGoster.Text = "Şifreyi Göster";
            this.chcSifreyiGoster.UseVisualStyleBackColor = true;
            this.chcSifreyiGoster.CheckedChanged += new System.EventHandler(this.chcSifreyiGoster_CheckedChanged);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(264, 21);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(94, 55);
            this.btnKayit.TabIndex = 4;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnSifre
            // 
            this.btnSifre.Location = new System.Drawing.Point(264, 82);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(94, 52);
            this.btnSifre.TabIndex = 5;
            this.btnSifre.Text = "Şifremi Unuttum";
            this.btnSifre.UseVisualStyleBackColor = true;
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(109, 140);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(249, 45);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 198);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnSifre);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.chcSifreyiGoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chcSifreyiGoster;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnSifre;
        private System.Windows.Forms.Button btnGiris;
    }
}

