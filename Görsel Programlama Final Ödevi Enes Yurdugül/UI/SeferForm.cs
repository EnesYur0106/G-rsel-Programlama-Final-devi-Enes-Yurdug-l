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
    public partial class SeferForm : Form
    {
        public SeferForm()
        {
            InitializeComponent();
        }

        public soforler soforler { get; set; }
        public otobusler otobusler { get; set; }

        public seferler seferler { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            seferler.otobus_id = textBox2.Text;
            seferler.yolculuk_tarihi = dateTimePicker1.Value;
            seferler.baslangic_yeri = textBox4.Text;
            seferler.bitis_yeri = textBox5.Text;
            

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

       
    }
}
