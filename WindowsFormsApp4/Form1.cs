using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        // LocalDB SQL Bağlantı Cümlesi
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=KutupHaneDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KitapListele();
        }

        // ==========================================
        // 1. LİSTELEME VE ARAMA FONKSİYONU
        // ==========================================
        private void KitapListele(string aramaMetni = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                        SELECT 
                            k.Id AS [Kitap No],
                            k.KAdi AS [Kitap Adı],
                            k.YazarId AS [Yazar No],
                            y.YazarAd + ' ' + y.YazarSoyad AS [Yazar],
                            k.YayinEviId AS [Yayın Evi No],
                            ye.YayinEviAdi AS [Yayın Evi],
                            k.SSayisi AS [Sayfa Sayısı],
                            ISNULL(u.Ad + ' ' + u.Soyad, '—') AS [Son İşlem Yapan Üye],
                            CASE 
                                WHEN o.Durum = 'Ödünçte' THEN 'Dışarıda (Ödünç Verildi)'
                                WHEN o.Durum = 'Teslim Edildi' THEN 'Rafta (Teslim Alındı)'
                                ELSE 'Rafta (Müsait)'
                            END AS [Kitap Durumu]
                        FROM Kitap k
                        INNER JOIN Yazar y ON k.YazarId = y.Id
                        INNER JOIN YayinEvi ye ON k.YayinEviId = ye.Id
                        LEFT JOIN Odunc o ON k.Id = o.KitapId
                        LEFT JOIN Uye u ON o.UyeId = u.Id
                        WHERE k.KAdi LIKE @ara OR y.YazarAd LIKE @ara OR ye.YayinEviAdi LIKE @ara
                        ORDER BY k.Id DESC;";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ara", "%" + aramaMetni + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri çekme hatası: " + ex.Message);
                }
            }
        }

        // Form Kutularını Temizleme Yardımcısı
        private void KutulariTemizle()
        {
            txtKitapAd.Clear();
            txtYazarId.Clear();
            txtYayinEviId.Clear();
            txtSayfa.Clear();
        }

        // LİSTELE / VERİLERİ GETİR BUTONU
        private void btnVerileriGetir_Click(object sender, EventArgs e)
        {
            KitapListele();
        }

        private void btnListelee_Click(object sender, EventArgs e)
        {
            KitapListele();
        }

        // ==========================================
        // 2. KİTAP EKLEME (AYNI YAZAR VE YAYINEVİ ID GIRILEBILIR)
        // ==========================================
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Kitap (KAdi, YazarId, YayinEviId, SSayisi) VALUES (@ad, @yazarId, @yayineviId, @sayfa)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ad", txtKitapAd.Text);
                    cmd.Parameters.AddWithValue("@yazarId", Convert.ToInt32(txtYazarId.Text));
                    cmd.Parameters.AddWithValue("@yayineviId", Convert.ToInt32(txtYayinEviId.Text));
                    cmd.Parameters.AddWithValue("@sayfa", Convert.ToInt32(txtSayfa.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Kitap başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KitapListele();
                    KutulariTemizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Hatası! Yazar No, Yayın Evi No ve Sayfa alanlarına var olan sayısal ID'leri giriniz.\n\nDetay: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 3. KİTAP SİLME
        // ==========================================
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kitap No"].Value);

                    if (MessageBox.Show("Seçilen kitabı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string query = "DELETE FROM Kitap WHERE Id = @id";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@id", secilenId);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Kitap silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KitapListele();
                            KutulariTemizle();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kitabı tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==========================================
        // 4. KİTAP GÜNCELLEME
        // ==========================================
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kitap No"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = @"UPDATE Kitap 
                                         SET KAdi = @ad, YazarId = @yazarId, YayinEviId = @yayineviId, SSayisi = @sayfa 
                                         WHERE Id = @id";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", secilenId);
                        cmd.Parameters.AddWithValue("@ad", txtKitapAd.Text);
                        cmd.Parameters.AddWithValue("@yazarId", Convert.ToInt32(txtYazarId.Text));
                        cmd.Parameters.AddWithValue("@yayineviId", Convert.ToInt32(txtYayinEviId.Text));
                        cmd.Parameters.AddWithValue("@sayfa", Convert.ToInt32(txtSayfa.Text));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Kitap bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KitapListele();
                        KutulariTemizle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // 5. CANLI ARAMA
        // ==========================================
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            KitapListele(txtAra.Text);
        }

        // ==========================================
        // 6. TABLODAN TIKLANAN KİTABIN TÜM BİLGİLERİNİ KUTULARA DOLDURMA
        // ==========================================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtKitapAd.Text = row.Cells["Kitap Adı"].Value.ToString();
                txtYazarId.Text = row.Cells["Yazar No"].Value.ToString();
                txtYayinEviId.Text = row.Cells["Yayın Evi No"].Value.ToString();
                txtSayfa.Text = row.Cells["Sayfa Sayısı"].Value.ToString();
            }
        }
    }
}