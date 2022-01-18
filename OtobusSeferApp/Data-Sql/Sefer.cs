using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusSeferApp.Data_Sql
{
    public class Sefer
    {
        public string getSeferList_Sql()
        {
            return "select * from Sefer";
        }
        public string getSefer_Sql()
        {
            return "select * from Sefer where id=@id";
        }
        public string addSefer_Sql()
        {
            return "insert into Sefer (kalkisYeri,varisYeri,kalkisSaati) values (@kalkisYeri,@varisYeri,@kalkisSaati) ";
        }

        public string updateSefer_Sql()
        {
            return "update Sefer set kalkisYeri=@kalkisYeri,varisYeri=@varisYeri,kalkisSaati=@kalkisSaati where id=@id";
        }
        public string findSefer_Sql()
        {
            return "select * from Sefer where cast(id as nvarchar(max)) like '%' + @aranacakDeger + '%' or lower(kalkisYeri) like '%' + @aranacakDeger + '%' or lower(varisYeri) like '%' + @aranacakDeger + '%';";
        }
        public string deleteSefer_Sql()
        {
            return "delete from Sefer where id=@id";
        }
    }
}
