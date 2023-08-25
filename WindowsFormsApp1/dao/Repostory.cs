using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.enumaration;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1.dao
{
    public class Repostory
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnValue;
        List<LoginTable> loginTableList;


        public Repostory()
        {
            con = new SqlConnection(@"Data Source=MERVE\SQLEXPRESS;Initial Catalog=market;Integrated Security=True");
        }
        public void baglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
        }

        public User login(string kullaniciAdi,string sifre)
        {
            con.Open();
            cmd = new SqlCommand("select * from loginTable where kullaniciAdi=@kulad and sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.kullaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.emailAdress = dr["emailAdress"].ToString();
                user.guvenlikSorusu = dr["güvenlikSorusu"].ToString();
                user.guvenlikCevabi = dr["güvenlikCevabi"].ToString();
                user.status = LoginStatus.basarili;
                return user;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.basarisiz;
                return user;
            }
        }

        public List<LoginTable> getLoginTable()
        {
            loginTableList = new List<LoginTable>();
            try
            {
                con.Open();
                cmd = new SqlCommand("güvenlikSorusuGetir_sp", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LoginTable loginTable = new LoginTable();
                    loginTable.id = int.Parse(dr["id"].ToString());
                    loginTable.kullaniciAdi = dr["kullaniciAdi"].ToString();
                    loginTable.sifre = dr["sifre"].ToString();
                    loginTable.yetki = dr["yetki"].ToString();
                    loginTable.emailAdress = dr["emailAdress"].ToString();
                    loginTable.guvenlikSorusu = dr["güvenlikSorusu"].ToString();
                    loginTable.guvenlikCevabi = dr["güvenlikCevabi"].ToString();
                    loginTableList.Add(loginTable);
                }
                con.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("hata oluştu");
            }
            
            return loginTableList;
        }

    
        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlikCevabi)
        {
            con.Open();
            cmd = new SqlCommand("select count(*) from loginTable where kullaniciAdi=@kulAd and güvenlikSorusu=@guvSorusu and güvenlikCevabi=@guvCevabi",con);
            cmd.Parameters.AddWithValue("@kulAd", kullaniciAdi);
            cmd.Parameters.AddWithValue("@guvSorusu", guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvCevabi", guvenlikCevabi);
            returnValue=(int)cmd.ExecuteScalar();

            con.Close();
            if (returnValue == 1)
                return LoginStatus.basarili;
            else
                return LoginStatus.basarisiz;
                    
        }
    
        public LoginStatus changePassword(string kullaniciAdi,string sifre)
        {
            con.Open();
            cmd = new SqlCommand("sifreGunceller_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            returnValue = cmd.ExecuteNonQuery();

            con.Close();
            return LoginStatus.basarili;
        }
    
        public string CheckEmailAddress(string kullaniciAdi)
        {
            con.Open();
            cmd = new SqlCommand("select emailAdress from loginTable where kullaniciAdi=@kulad", con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);

            string emailAdres = (string)cmd.ExecuteScalar();

            con.Close();
            return emailAdres;
        }
    }

}
