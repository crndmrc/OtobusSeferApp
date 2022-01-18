using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusSeferApp.Data_Sql
{
    public class User
    {
        public string getUser_Sql()
        {
            return "select count(*) as Sayi from Kullanici where kullaniciadi=@kullaniciadi and sifre=@sifre";
        }
        public string getUserList_Sql()
        {
            return "select * from Kullanici";
        }
        public string addUser_Sql()
        {
            return "insert into Kullanici (kullaniciadi,sifre) values (@kullaniciadi,@sifre)";
        }
        public string updateUser_Sql()
        {
            return "update Kullanici set kullaniciadi=@kullaniciadi, sifre=@sifre where id=@id";
        }
        public string findUser_Sql()
        {
            return "select * from Kullanici where cast(id as nvarchar(max)) like '%' + @aranacakDeger + '%' or lower(kullaniciadi) like '%' + @aranacakDeger + '%';";
        }
        public string deleteUser_Sql()
        {
            return "delete from Kullanici where id=@id";
        }
    }
}
