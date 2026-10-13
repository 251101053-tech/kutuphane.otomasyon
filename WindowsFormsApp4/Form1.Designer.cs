namespace WindowsFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerileriGetir = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListelee = new System.Windows.Forms.Button();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtYazarId = new System.Windows.Forms.TextBox();
            this.txtYayinEviId = new System.Windows.Forms.TextBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblKitapAd = new System.Windows.Forms.Label();
            this.lblYazarId = new System.Windows.Forms.Label();
            this.lblYayinEviId = new System.Windows.Forms.Label();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.lblAra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(953, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnVerileriGetir
            // 
            this.btnVerileriGetir.Location = new System.Drawing.Point(12, 180);
            this.btnVerileriGetir.Name = "btnVerileriGetir";
            this.btnVerileriGetir.Size = new System.Drawing.Size(120, 40);
            this.btnVerileriGetir.TabIndex = 1;
            this.btnVerileriGetir.Text = "Verileri Getir";
            this.btnVerileriGetir.UseVisualStyleBackColor = true;
            this.btnVerileriGetir.Click += new System.EventHandler(this.btnVerileriGetir_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(400, 20);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 40);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(520, 20);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 40);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(400, 70);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 40);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListelee
            // 
            this.btnListelee.Location = new System.Drawing.Point(520, 70);
            this.btnListelee.Name = "btnListelee";
            this.btnListelee.Size = new System.Drawing.Size(100, 40);
            this.btnListelee.TabIndex = 5;
            this.btnListelee.Text = "LİSTELE";
            this.btnListelee.UseVisualStyleBackColor = true;
            this.btnListelee.Click += new System.EventHandler(this.btnListelee_Click);
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(120, 20);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(240, 20);
            this.txtKitapAd.TabIndex = 6;
            // 
            // txtYazarId
            // 
            this.txtYazarId.Location = new System.Drawing.Point(120, 50);
            this.txtYazarId.Name = "txtYazarId";
            this.txtYazarId.Size = new System.Drawing.Size(240, 20);
            this.txtYazarId.TabIndex = 7;
            // 
            // txtYayinEviId
            // 
            this.txtYayinEviId.Location = new System.Drawing.Point(120, 80);
            this.txtYayinEviId.Name = "txtYayinEviId";
            this.txtYayinEviId.Size = new System.Drawing.Size(240, 20);
            this.txtYayinEviId.TabIndex = 8;
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(120, 110);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(240, 20);
            this.txtSayfa.TabIndex = 9;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(120, 140);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(240, 20);
            this.txtAra.TabIndex = 10;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lblKitapAd
            // 
            this.lblKitapAd.AutoSize = true;
            this.lblKitapAd.Location = new System.Drawing.Point(20, 23);
            this.lblKitapAd.Name = "lblKitapAd";
            this.lblKitapAd.Size = new System.Drawing.Size(52, 13);
            this.lblKitapAd.TabIndex = 4;
            this.lblKitapAd.Text = "Kitap Adı:";
            // 
            // lblYazarId
            // 
            this.lblYazarId.AutoSize = true;
            this.lblYazarId.Location = new System.Drawing.Point(20, 53);
            this.lblYazarId.Name = "lblYazarId";
            this.lblYazarId.Size = new System.Drawing.Size(74, 13);
            this.lblYazarId.TabIndex = 3;
            this.lblYazarId.Text = "Yazar No (ID):";
            // 
            // lblYayinEviId
            // 
            this.lblYayinEviId.AutoSize = true;
            this.lblYayinEviId.Location = new System.Drawing.Point(20, 83);
            this.lblYayinEviId.Name = "lblYayinEviId";
            this.lblYayinEviId.Size = new System.Drawing.Size(91, 13);
            this.lblYayinEviId.TabIndex = 2;
            this.lblYayinEviId.Text = "Yayın Evi No (ID):";
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Location = new System.Drawing.Point(20, 113);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(67, 13);
            this.lblSayfa.TabIndex = 1;
            this.lblSayfa.Text = "Sayfa Sayısı:";
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(20, 143);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(66, 13);
            this.lblAra.TabIndex = 0;
            this.lblAra.Text = "Canlı Arama:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1052, 695);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.lblSayfa);
            this.Controls.Add(this.lblYayinEviId);
            this.Controls.Add(this.lblYazarId);
            this.Controls.Add(this.lblKitapAd);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.txtYayinEviId);
            this.Controls.Add(this.txtYazarId);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.btnListelee);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnVerileriGetir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Kütüphane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerileriGetir;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnListelee;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtYazarId;
        private System.Windows.Forms.TextBox txtYayinEviId;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblKitapAd;
        private System.Windows.Forms.Label lblYazarId;
        private System.Windows.Forms.Label lblYayinEviId;
        private System.Windows.Forms.Label lblSayfa;
        private System.Windows.Forms.Label lblAra;
    }
}