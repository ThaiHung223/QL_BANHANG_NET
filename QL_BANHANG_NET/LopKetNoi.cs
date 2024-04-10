using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace QL_BANHANG_NET
{
    public class LopKetNoi
    {
        SqlConnection con;
        private void ketnoi()
        {
            string sqlCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KTTMDT\QL_BANHANG_NET\QL_BANHANG_NET\App_Data\QL_KH.mdf;Integrated Security=True";
            con = new SqlConnection(sqlCon);
            con.Open();

        }
        private void dongketnoi()
        {
            con.Close();
        }
        public DataTable docdulieu(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                ketnoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                //DataSet ds = new DataSet();
                //da.Fill(ds);
                da.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                dongketnoi();
            }
            return dt;
        }
    }
}