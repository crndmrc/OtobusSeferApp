using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusSeferApp.Data_Sql
{
    public class Ticket
    {
        public string getTicketList_Sql()
        {
            return "select * from Bilet";
        }
        public string getTicket_Sql()
        {
            return "select * from Bilet where id=@id";
        }
        public string getSefer_Bilet_Sql()
        {
            return "select * from Bilet where sefer_id=@id";
        }
        public string addTicket_Sql()
        {
            return "insert into Bilet (biletSahipAdi,biletSahipSoyadi,biletSahipCep,biletNo,username_id,sefer_id) values (@biletSahipAdi,@biletSahipSoyadi,@biletSahipCep,@biletNo,@username_id,@sefer_id)";
        }
        public string updateTicket_Sql()
        {
            return "update Bilet set biletSahipAdi = @biletSahipAdi, biletSahipSoyadi = @biletSahipSoyadi ,biletSahipCep = @biletSahipCep,biletNo =@biletNo,username_id=@username_id ,sefer_id=@sefer_id where id=@id";
        }
        public string findTicket_Sql()
        {
            return "select * from Bilet where cast(id as nvarchar(max)) like '%' + @aranacakDeger + '%' or lower(biletSahipAdi) like '%' + @aranacakDeger + '%' or lower(biletSahipSoyadi) like '%' + @aranacakDeger + '%';";
        }
        public string deleteTicket_Sql()
        {
            return "delete from Bilet where id=@id";
        }
    }
}
