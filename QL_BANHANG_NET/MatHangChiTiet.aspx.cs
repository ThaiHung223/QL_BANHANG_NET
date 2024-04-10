using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QL_BANHANG_NET
{
    public partial class MatHangChiTiet : System.Web.UI.Page
    {
        LopKetNoi ketnoi = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "Select * From MATHANG";
            DataTable dt = ketnoi.docdulieu(sql);
            dl_chitiet.DataSource = dt; /////////
            dl_chitiet.DataBind();
        }
    }
}