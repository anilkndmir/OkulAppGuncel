using OkulApp.DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenKaydet(Ogretmen ogretmen)
        {
            var helper = new Helper();
            var p = new SqlParameter[]
            {
                    new SqlParameter("@Ad",ogretmen.OgretmenAdi),
                    new SqlParameter("@Soyad",ogretmen.OgretmenSoyadi),
                    new SqlParameter("@KimlikNo",ogretmen.OgretmenTc)
            };
            return helper.ExecuteNonQuery("Insert into tblOgretmenler Values (@Ad,@Soyad,@KimlikNo)", p) > 0;
        }
        public Ogretmen OgretmenBul(string Tc)
        {
            try
            {
                var hlp = new Helper();
                SqlParameter[] p = { new SqlParameter("@KimlikNo", Tc) };
                var dr = hlp.ExecuteReader("Select OgretmenID,Ad,Soyad,KimlikNo from tblOgretmenler where KimlikNo=@KimlikNo", p);
                Ogretmen ogr = null;
                if (dr.Read())
                {
                    ogr = new Ogretmen();
                    ogr.OgretmenId = dr["OgretmenID"].ToString();
                    ogr.OgretmenAdi = dr["Ad"].ToString();
                    ogr.OgretmenSoyadi = dr["Soyad"].ToString();
                    ogr.OgretmenTc = dr["KimlikNo"].ToString();
                }
                dr.Close();
                return ogr;
            }

            catch (Exception ex)
            {
                throw new Exception("Hata: " + ex);
            }


        }
        public bool OgretmenSil(String Tc)
        {
            try
            {
                var hlp = new Helper();
                var p = new SqlParameter[] {
                   new SqlParameter("@KimlikNo", Tc)
                };
                return hlp.ExecuteNonQuery("DELETE FROM tblOgretmenler WHERE KimlikNo = @KimlikNo", p) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Hata: " + ex.Message, ex);
            }
        }

        public bool OgretmenGuncelle(Ogretmen ogr)
        {
            try
            {
                SqlParameter[] p =
                {
                new SqlParameter("@Ad",ogr.OgretmenAdi),
                new SqlParameter("@Soyad", ogr.OgretmenSoyadi),
                new SqlParameter("@KimlikNo",ogr.OgretmenTc)
                };

                Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Update tblOgretmenler set Ad=@Ad,Soyad=@Soyad where KimlikNo=@KimlikNo", p) > 0;
               
            }
            catch (Exception ex)
            {
                throw new Exception("Hata: " + ex);
            }
        }
    }
}
