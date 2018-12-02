<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<%@ Register Src="~/cms/admin/AdminLoadControl.ascx" TagPrefix="uc1" TagName="AdminLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang quản trị</title>
    <link rel="stylesheet" type="text/css" href="/Data/style.css"/>
    <link href="cms/admin/css/cssAdmin.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="/Data/css/bootstrap.min.css"/>
    <script src="cms/admin/js/jquery-3.3.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--Header--%>
            <div id="header">
                <div class="container">
                    <div class="logo">
                        <a href="/Admin.aspx"><img src="images/logo.jpg" alt="" /></a>
                    </div>
                    <div class="accountMenu">
                        Xin chào:<asp:Literal ID="ltrTenDangNhap" runat="server"></asp:Literal> | <asp:LinkButton ID="lbtDangXuat" runat="server" OnClick="lbtDangXuat_Click" >Đăng xuất</asp:LinkButton>
                    </div>                 
                </div>               
            </div>
             <%--MenuChinh--%>
            <div class="MenuChinh">
                <div class="container">
                    <ul>
                        
                         <li><a href="/Admin.aspx?modul=SanPham">SẢN PHẨM</a></li>
                         <li><a href="/Admin.aspx?modul=KhachHang">KHÁCH HÀNG</a></li>
                         <li><a href="/Admin.aspx?modul=TaiKhoan">TÀI KHOẢN</a></li>
                    </ul>
                </div>              
            </div>        
             <%--Nội dung trang--%>
              <uc1:AdminLoadControl runat="server" ID="AdminLoadControl" />
        </div>
    </form>
</body>
</html>
