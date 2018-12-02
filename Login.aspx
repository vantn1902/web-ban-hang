<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang đăng nhập vào khu vực quản trị website</title>
    <link href="cms/admin/css/cssDangNhap.css" rel="stylesheet" />
   
</head>
<body>
    <form id="form1" runat="server">
    <div class="FormDangNhap">
        <div class="head">Đăng nhập hệ thống</div>
        <div class="controls">
            <div class="row">
            <div class="left">Tên đăng nhập</div>
            <div class="right">
                <asp:TextBox ID="tbTenDangNhap" runat="server"></asp:TextBox>
            </div>            
        </div>
        <div class="row">
            <div class="left">Mật khẩu</div>
            <div class="right">
                <asp:TextBox ID="tbMatKhau" runat="server" TextMode="Password"></asp:TextBox>
            </div>            
        </div>
        <div class="row">
            <div class="left">&nbsp;</div>
            <div class="right">
                <asp:LinkButton ID="lbtDangNhap" runat="server" CssClass="btDangNhap" OnClick="lbtDangNhap_Click">Đăng nhập</asp:LinkButton>
              
            </div>            
        </div>
        <div style="text-align:center;font-size:16px; color:red">
            <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
        </div>
        </div>
    </div>
    </form>
</body>
</html>
