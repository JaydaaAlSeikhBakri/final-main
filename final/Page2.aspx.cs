using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tecno_2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br>");
            /*string name = Request.QueryString.Get("name");
            TextBox1.Text = name;*/
            Response.Write(Request.QueryString.Get("name"));
          // label5.Text = "Welcome " + Request.QueryString["name"].ToString();



            HttpCookie cookie = Request.Cookies["Cookie"];
            if(cookie!=null)
            {
                Label1.Text = "The Name Is : " + cookie["Name"];
                Label2.Text="The Age Is : " + cookie["Age"];
            }

            if(Session["name"]!=null)
            {
                Label3.Text = "<--Session--> The Name Is : " + Session["name"].ToString();
                Label4.Text = "<--Session--> The Age Is : " + Session["age"].ToString();
            }
            

            
        }
    }
}