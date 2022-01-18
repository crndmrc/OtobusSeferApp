using DAL_Example;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebSevices
{
    /// <summary>
    /// Ogrenci için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class Ogrenci : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Merhaba Dünya";
        }

        //Sefer objesi için crud işlemleri yapan web service 
        // win forma clint oluşturma web service i çağırıp çalıştır.
        //4 buton 

        Execute execute = new Execute();
        public DataTable r_Sefer()
        {
            DataTable dt = new DataTable();
            dt = execute.executeDT("select * from Sefer", null);
            return dt;
            dt.TableName = "dtTable";
        }
        public bool c_Sefer(string kalkisYeri,string varisYeri,string kalkisSaati)
        {
            bool result;
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@kalkisYeri", kalkisYeri));
            _params.Add(new SqlParameter("@varisYeri", varisYeri));
            _params.Add(new SqlParameter("@kalkisSaati", kalkisSaati));
            result = execute.execute("insert into Sefer (kalkisYeri,varisYeri,kalkisSaati) values (@kalkisYeri,@varisYeri,@kalkisSaati)", _params.ToArray());
            return result;
        }
        public bool u_Sefer(int id, string kalkisYeri, string varisYeri, string kalkisSaati)
        {
            bool result;
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@id", id));
            _params.Add(new SqlParameter("@kalkisYeri", kalkisYeri));
            _params.Add(new SqlParameter("@varisYeri",varisYeri));
            _params.Add(new SqlParameter("@kalkisSaati", kalkisSaati));
            result = execute.execute("update Sefer set kalkisYeri=@kalkisYeri,varisYeri=@varisYeri,kalkisSaati=@kalkisSaati where id=@id", _params.ToArray());
            return result;
        }
        public bool d_Sefer(int id)
        {
            bool result;

            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@id", id));

            result  = execute.execute("delete from Sefer where id=@id", _params.ToArray());
            return result;
        }

    }
}
