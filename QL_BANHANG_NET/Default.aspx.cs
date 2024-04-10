using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace QL_BANHANG_NET
{
    public partial class Default : System.Web.UI.Page
    {
        LopKetNoi ketnoi = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "Select * From MATHANG";
            DataTable dt = ketnoi.docdulieu(sql);
            dl_mathang.DataSource = dt; /////////
            dl_mathang.DataBind();
        }
        protected void dl_mathang_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "ChiTiet")
            {
                string maHang = e.CommandArgument.ToString();

                // Chuyển hướng đến trang "MatHangChiTiet.aspx" và truyền mã hàng qua query string
                Response.Redirect($"MatHangChiTiet.aspx?MaHang={maHang}");
            }
        }
    }
}