using Framework4._7.Dac;
using System;
using System.Data;
using System.Web;

namespace Ryu_WebForm
{
    public partial class View1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            DacMsSql dac = new DacMsSql();
            DataSet ds = new DataSet();
            ds = dac.GetData("Get_TestTable");

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            if(HttpContext.Current.Request.Cookies["testCookie"] != null)
            {
                txtCookie.Text = HttpUtility.UrlDecode(HttpContext.Current.Request.Cookies["testCookie"].Value);
            }   
        }
    }
}