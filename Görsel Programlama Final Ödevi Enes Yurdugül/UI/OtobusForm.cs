using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel_Programlama_Final_Ödevi_Enes_Yurdugül.UI
{
    public partial class OtobusForm : Form
    {
        public OtobusForm()
        {
            InitializeComponent();
        }

        public otobusler otobusler { get; set; }
        public bool Güncelleme { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!HataKontrol(textBox2)) return;
            if (!HataKontrol(textBox3)) return;
            if (!HataKontrol(textBox4)) return;

            
            otobusler.marka = textBox2.Text;
            otobusler.model = textBox3.Text;
            otobusler.koltuk_sayisi = textBox4.Text;

            DialogResult = DialogResult.OK;
        }

        private bool HataKontrol(Control c)
        {
            if (c is TextBox)
            {
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
