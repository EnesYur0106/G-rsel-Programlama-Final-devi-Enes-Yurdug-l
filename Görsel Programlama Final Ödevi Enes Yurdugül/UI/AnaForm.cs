using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Görsel_Programlama_Final_Ödevi_Enes_Yurdugül.BL;
using Görsel_Programlama_Final_Ödevi_Enes_Yurdugül.UI;



namespace Görsel_Programlama_Final_Ödevi_Enes_Yurdugül
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void BtnOtobusEkle_Click(object sender, EventArgs e)
        {
            OtobusForm otobusForm = new OtobusForm()
            {
                Text = "Otobüs Ekle",
                otobusler = new otobusler() { id = Guid.NewGuid() },
            };
            
            tekrar: 
            var sonuc = otobusForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
              bool b = BLogic.OtobüsEkle(otobusForm.otobusler);

                if (b)
                {
                        DataSet ds = BLogic.OtobüsGetir("");
                        if (ds != null)
                            dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }

        }

        private void BtnOtobusGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            OtobusForm otobusForm = new OtobusForm()
            {
                Text = "Otobüs Güncelle",
                Güncelleme = true,
                otobusler = new otobusler()
                {
                    id = Guid.Parse( row.Cells[0].Value.ToString()),
                    marka = row.Cells[1].Value.ToString(),
                    model = row.Cells[2].Value.ToString(),
                    koltuk_sayisi = row.Cells[3].Value.ToString(),
                },
            };
                 
            var sonuc = otobusForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OtobüsGüncelle(otobusForm.otobusler);

                if (b)
                {

                    row.Cells[1].Value = otobusForm.otobusler.marka;
                    row.Cells[2].Value = otobusForm.otobusler.model;
                    row.Cells[3].Value = otobusForm.otobusler.koltuk_sayisi;
                }
                
            }

        }

        private void BtnOtobusBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.OtobüsGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.OtobüsGetir("");
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];

            DataSet ds2 = BLogic.SoforGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        private void BtnOtobusSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var id = row.Cells[0].Value.ToString(),

           
            var sonuc = MessageBox.Show("seçili kayıt silinsin mi ?", MessageBoxButtons.OKCancel);

            if (sonuc == DialogResult.OK) 
            {
                bool b = BLogic.OtobüsSil(id);

                if (b)
                {
                    DataSet ds = BLogic.OtobüsGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }

        }

        private void BtnSoforEkle_Click(object sender, EventArgs e)
        {
            FormSoforler frm = new FormSoforler()
            {
                Text = "Şoför Ekle",
                soforler = new soforler() { id = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SoforEkle(frm.soforler);

                if (b)
                {
                    DataSet ds = BLogic.SoforGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void BtnSoforBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.SoforGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void BtnSoforGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            FormSoforler frm = new FormSoforler()
            {
                Text = "Şoför Güncelle",
                Güncelleme = true,
                soforler = new soforler()
                {
                    id = Guid.Parse(row.Cells[0].Value.ToString()),
                    ad = row.Cells[1].Value.ToString(),
                    soyad = row.Cells[2].Value.ToString(),
                    tc_kimlik = row.Cells[3].Value.ToString(),
                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SoforGüncelle(frm.soforler);

                if (b)
                {

                    row.Cells[1].Value = frm.soforler.ad;
                    row.Cells[2].Value = frm.soforler.soyad;
                    row.Cells[3].Value = frm.soforler.tc_kimlik;
                }

            }
        }

        private void BtnSoforSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var id = row.Cells[0].Value.ToString(),


            var sonuc = MessageBox.Show("seçili kayıt silinsin mi ?", MessageBoxButtons.OKCancel);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SoforSil(id);

                if (b)
                {
                    DataSet ds = BLogic.OtobüsGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }

            }
        }
    }
}
