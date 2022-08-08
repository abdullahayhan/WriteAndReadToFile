
namespace DosyaYazmaOkuma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_adiSoyadi = new System.Windows.Forms.TextBox();
            this.txt_bolumu = new System.Windows.Forms.TextBox();
            this.txt_babaAdi = new System.Windows.Forms.TextBox();
            this.listBox_adiSoyadi = new System.Windows.Forms.ListBox();
            this.listBox_bolumu = new System.Windows.Forms.ListBox();
            this.listBox_babaAdi = new System.Windows.Forms.ListBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrencinin Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğrencinin Bölümü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğrenci Baba Adı";
            // 
            // txt_adiSoyadi
            // 
            this.txt_adiSoyadi.Location = new System.Drawing.Point(11, 41);
            this.txt_adiSoyadi.Name = "txt_adiSoyadi";
            this.txt_adiSoyadi.Size = new System.Drawing.Size(150, 27);
            this.txt_adiSoyadi.TabIndex = 1;
            // 
            // txt_bolumu
            // 
            this.txt_bolumu.Location = new System.Drawing.Point(218, 41);
            this.txt_bolumu.Name = "txt_bolumu";
            this.txt_bolumu.Size = new System.Drawing.Size(150, 27);
            this.txt_bolumu.TabIndex = 1;
            // 
            // txt_babaAdi
            // 
            this.txt_babaAdi.Location = new System.Drawing.Point(421, 41);
            this.txt_babaAdi.Name = "txt_babaAdi";
            this.txt_babaAdi.Size = new System.Drawing.Size(150, 27);
            this.txt_babaAdi.TabIndex = 1;
            // 
            // listBox_adiSoyadi
            // 
            this.listBox_adiSoyadi.FormattingEnabled = true;
            this.listBox_adiSoyadi.ItemHeight = 20;
            this.listBox_adiSoyadi.Location = new System.Drawing.Point(11, 103);
            this.listBox_adiSoyadi.Name = "listBox_adiSoyadi";
            this.listBox_adiSoyadi.Size = new System.Drawing.Size(150, 184);
            this.listBox_adiSoyadi.TabIndex = 2;
            // 
            // listBox_bolumu
            // 
            this.listBox_bolumu.FormattingEnabled = true;
            this.listBox_bolumu.ItemHeight = 20;
            this.listBox_bolumu.Location = new System.Drawing.Point(218, 103);
            this.listBox_bolumu.Name = "listBox_bolumu";
            this.listBox_bolumu.Size = new System.Drawing.Size(150, 184);
            this.listBox_bolumu.TabIndex = 2;
            // 
            // listBox_babaAdi
            // 
            this.listBox_babaAdi.FormattingEnabled = true;
            this.listBox_babaAdi.ItemHeight = 20;
            this.listBox_babaAdi.Location = new System.Drawing.Point(421, 103);
            this.listBox_babaAdi.Name = "listBox_babaAdi";
            this.listBox_babaAdi.Size = new System.Drawing.Size(150, 184);
            this.listBox_babaAdi.TabIndex = 2;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(47, 308);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(200, 52);
            this.btn_Ekle.TabIndex = 3;
            this.btn_Ekle.Text = "Listeye Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(299, 308);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(200, 52);
            this.btn_Sil.TabIndex = 3;
            this.btn_Sil.Text = "Listeden Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 372);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.listBox_babaAdi);
            this.Controls.Add(this.listBox_bolumu);
            this.Controls.Add(this.listBox_adiSoyadi);
            this.Controls.Add(this.txt_babaAdi);
            this.Controls.Add(this.txt_bolumu);
            this.Controls.Add(this.txt_adiSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_adiSoyadi;
        private System.Windows.Forms.TextBox txt_bolumu;
        private System.Windows.Forms.TextBox txt_babaAdi;
        private System.Windows.Forms.ListBox listBox_adiSoyadi;
        private System.Windows.Forms.ListBox listBox_bolumu;
        private System.Windows.Forms.ListBox listBox_babaAdi;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
    }
}

