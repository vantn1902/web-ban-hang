using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PersonalPage
/// </summary>
public class PersonalPage: CommonPage
{
   public void Page_PreInit(object o, EventArgs e)
    {
        if(daDangNhap==false)
        {
            Session["RequestUrl"] = Request.Url.AbsoluteUri;

            Response.Redirect("Thongbao.aspx");
        }
    }
}