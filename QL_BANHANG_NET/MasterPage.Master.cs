using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace QL_BANHANG_NET
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LopKetNoi ketnoi = new LopKetNoi();
            string sql = "Select * From LOAIHANG";
            DataTable dt = ketnoi.docdulieu(sql);
            dl_loaihang.DataSource = dt;
            dl_loaihang.DataBind();

        }
        LopKetNoi ketnoi = new LopKetNoi();
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTendangnhap.Text;
            string matkhau = txtMatkhau.Text;
            bool rememberMe = chkRememberMe.Checked;
            pnlLogin.Visible = false;
            pnlLoggedIn.Visible = true;

            string sql = "Select * From KHACHHANG";

        }
    }
}