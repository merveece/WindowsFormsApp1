using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.dao;
using WindowsFormsApp1.enumaration;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1.controller
{
    public class Controller
    {
        Repostory repostory;

        public Controller()
        {
            repostory = new Repostory();

        }
        public User login(string kullaniciAdi, string sifre)
        {
            User result;
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                result = repostory.login(kullaniciAdi, sifre);

                return result;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.eksikParametre;
                return user;
            }
             
        }

        public List<LoginTable> getLoginTable()
        {
            List<LoginTable> loginTableList= repostory.getLoginTable();
            return loginTableList;
        }

        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlikCevabi)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(guvenlikSorusu) && !string.IsNullOrEmpty(guvenlikCevabi))
            {
                LoginStatus result = repostory.doAuthentication(kullaniciAdi, guvenlikSorusu, guvenlikCevabi);

                if (result == LoginStatus.basarili)
                    return result;
                else
                    return LoginStatus.basarisiz;
            }
            else
                return LoginStatus.eksikParametre;
        }

        public LoginStatus changePassword(string kullaniciAdi,string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
                return repostory.changePassword(kullaniciAdi, sifre);
            else
                return LoginStatus.eksikParametre;
        }



        public string CheckEmailAddress(string kullaniciAdi)
        {
            return repostory.CheckEmailAddress(kullaniciAdi);
        }
    }
}
