using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Görsel_Programlama_Final_Ödevi_Enes_Yurdugül.DL;
using Görsel_Programlama_Final_Ödevi_Enes_Yurdugül.UI;

namespace Görsel_Programlama_Final_Ödevi_Enes_Yurdugül.BL
{
    public static class BLogic
    {
        public static bool OtobüsEkle(otobusler o)
        {
            try
            {
                int res = Datalayer.OtobüsEkle(o);
                return (res > 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluştu::" + ex.Message);
                return false;
            }
        }

        internal static DataSet OtobüsGetir(string filtre)
        {
            try
            {
               DataSet ds  = Datalayer.OtobüsGetir(filtre);
                return ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluştu::" + ex.Message);
                return null;
            }
        }

        internal static bool OtobüsGüncelle(otobusler o)
        {
            try
            {
                int res = Datalayer.OtobüsGüncelle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu::" + ex.Message);
                return false;
            }
        }

        internal static bool OtobüsSil(string id)
        {
            try
            {
                int res = Datalayer.OtobüsSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu::" + ex.Message);
                return false;
            }
        }

        internal static bool SoforEkle(soforler s)
        {
            try
            {
                int res = Datalayer.SoforEkle(s);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu::" + ex.Message);
                return false;
            }
        }

        internal static DataSet SoforGetir(string filtre)
        {
            try
            {
                DataSet ds = Datalayer.SoforGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu::" + ex.Message);
                return null;
            }
        }

        internal static bool SoforGüncelle(soforler s)
        {
            try
            {
                int res = Datalayer.SoforsGüncelle(s);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu::" + ex.Message);
                return false;
            }
        }

        internal static bool SoforSil(string id)
        {
            try
            {
                int res = Datalayer.SoforSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu::" + ex.Message);
                return false;
            }
        }
    }
}
