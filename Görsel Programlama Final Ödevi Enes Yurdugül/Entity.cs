using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Görsel_Programlama_Final_Ödevi_Enes_Yurdugül
{
    public class soforler
    {
        public Guid id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tc_kimlik { get; set; }

    }

    public class otobusler
    {
        public Guid id { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string koltuk_sayisi { get; set; }

    }

    public class seferler
    {
        public Guid id { get; set; }
        public string otobus_id { get; set; }
        public DateTime yolculuk_tarihi { get; set; }
        public string baslangic_yeri { get; set; }
        public string bitis_yeri { get; set; }
    }

    public class yolcular
    {
        public Guid id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tc_kimlik { get; set; }
        public string biletler { get; set; }
    }
}
