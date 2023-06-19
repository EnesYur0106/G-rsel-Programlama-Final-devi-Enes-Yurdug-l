using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Görsel_Programlama_Final_Ödevi_Enes_Yurdugül.DL
{
    public static class Datalayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Database = "otobus",
                UserID = "root",
                Password = "root",

            }.ConnectionString
            ); 

        public static int OtobüsEkle(otobusler o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("otobusekle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", o.id);
                komut.Parameters.AddWithValue("@marka", o.marka);
                komut.Parameters.AddWithValue("@model", o.model);
                komut.Parameters.AddWithValue("@koltuk_sayisi", o.koltuk_sayisi);
                
               int res = komut.ExecuteNonQuery();
               return res;

            }

            catch(Exception ex)
            {
                throw ex; 
               
            }
            finally
            {
               if(conn.State != System.Data.ConnectionState.Closed)
                conn.Close();
            }
        }

        internal static DataSet OtobüsGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {

                    komut = new MySqlCommand("otobushepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
               
                }
                else
                {
                    komut = new MySqlCommand("otobusbul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;

            }

            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OtobüsGüncelle(otobusler o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("otobusguncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", o.id);
                komut.Parameters.AddWithValue("@marka", o.marka);
                komut.Parameters.AddWithValue("@model", o.model);
                komut.Parameters.AddWithValue("@koltuk_sayisi", o.koltuk_sayisi);

                int res = komut.ExecuteNonQuery();
                return res;

            }

            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OtobüsSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("otobussil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", o.id);
               

                int res = komut.ExecuteNonQuery();
                return res;

            }

            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int SoforEkle(soforler s)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("soforekle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", s.id);
                komut.Parameters.AddWithValue("@ad", s.ad);
                komut.Parameters.AddWithValue("@soyad", s.soyad);
                komut.Parameters.AddWithValue("@tc_kimlik", s.tc_kimlik);

                int res = komut.ExecuteNonQuery();
                return res;

            }

            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet SoforGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {

                    komut = new MySqlCommand("soforhepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("soforbul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;

            }

            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int SoforsGüncelle(soforler s)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("soforguncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", s.id);
                komut.Parameters.AddWithValue("@ad", s.ad);
                komut.Parameters.AddWithValue("@soyad", s.soyad);
                komut.Parameters.AddWithValue("@tc_kimlik", s.tc_kimlik);

                int res = komut.ExecuteNonQuery();
                return res;

            }

            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int SoforSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("soforsil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", o.id);


                int res = komut.ExecuteNonQuery();
                return res;

            }

            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
    }
}
