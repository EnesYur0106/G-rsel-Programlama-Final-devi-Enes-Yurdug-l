using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Görsel_Programlama_Final_Ödevi_Enes_Yurdugül.UI
{
    public partial class FormSoforler : Form
    {
        public FormSoforler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public soforler soforler { get; set; }
        public bool Güncelleme { get; set; } = false;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!HataKontrol(textBox2)) return;
            if (!HataKontrol(textBox3)) return;
            if (!HataKontrol(textBox4)) return;

            
            soforler.ad = textBox2.Text;
            soforler.soyad = textBox3.Text;
            soforler.tc_kimlik = textBox4.Text;
            

            DialogResult = DialogResult.OK;
        }

        private bool HataKontrol(Control c)
        {
            if (c is TextBox) {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Bu Alan Boş Bırakılamaz");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                }
            }

            return true;
        }

        private void FormSoforler_Load(object sender, EventArgs e)
        {
            textBox1.Text = otobusler.id.ToString();

            if(Güncelleme)
            {
                textBox2.Text = soforler.ad;
                textBox3.Text = soforler.soyad;
                textBox4.Text = soforler.tc_kimlik;
            }
            
        }
    }
}
