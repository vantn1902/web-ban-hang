using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CommonPage
/// </summary>
public class CommonPage: System.Web.UI.Page
{
    #region Property
    /// <summary>
    /// Thuộc tính cart:Truy xuất thông tin giỏ hàng (lưu trong Session)
    /// </summary>
   
    public List<CartItem> GioHang
    {
        get
        {
            //Nếu chưa có session["GioHang"]
            if (Session["GioHang"] == null)
                Session["GioHang"] = new List<CartItem>();
            //lấy giỏ hàng từ session
            return Session["GioHang"] as List<CartItem>;
        }
    }
    public Khachhang NguoiDung
    {
        get
        {
            return Session["KhachHang"] as Khachhang;
        }
        set
        {
            if (value == null)
                Session.Remove("KhachHang");
            else
                Session["KhachHang"] = value;
        }
    }

    public bool daDangNhap
    {
        get { return Session["KhachHang"] != null; }
    }
    #endregion

}