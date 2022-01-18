using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusSeferApp.Dal
{
    internal class Execute
    {
        //public static SqlConnection _con = new SqlConnection(@"Data Source = DESKTOP-N6OJNIH\SQLEXPRESS; Initial Catalog=OTOBUS; Integrated Security=TRUE;");
        public const string _cs = @"Server=Z36-04\SQLEXPRESS;Database=OTOBUS;User Id=sa;Password=12345678;";
        //public DataTable executeDt(string _sql,SqlParameter[] _params)
        //{
        //    DataTable dt = new DataTable();
        //    SqlConnection _con = new SqlConnection();
        //    SqlCommand _cmd = new SqlCommand(_sql,_con);
        //    if (_params != null) _cmd.Parameters.AddRange(_params);
        //    SqlDataAdapter _adapter = new SqlDataAdapter(_cmd);
        //    _adapter.Fill(dt);
        //    return dt;
        //}
        public DataTable executeDT(string _sql, SqlParameter[] _params)
        {
            DataTable dtResult = new DataTable();


            try
            {
                SqlConnection _con = new SqlConnection(_cs);
                SqlCommand _cmd = new SqlCommand(_sql, _con);
                if (_params != null) _cmd.Parameters.AddRange(_params);
                SqlDataAdapter _adapter = new SqlDataAdapter(_cmd);
                _adapter.Fill(dtResult);
            }
            catch 
            {
                dtResult = null;
            }

            //return data
            return dtResult;
        }
        public bool execute(string sql,SqlParameter[] _params)
        {
            bool result = true;
            SqlConnection _con = new SqlConnection(_cs);

            try
            {
                _con.Open();
                SqlCommand _cmd = new SqlCommand(sql, _con);
                if (_params != null) _cmd.Parameters.AddRange(_params);
                _cmd.ExecuteNonQuery();
            }
            catch 
            {
                result = false;
            }
            finally
            {
                _con.Close();
            }
            return result;
        }
    }
}
