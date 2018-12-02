<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dangnhap.aspx.cs" Inherits="Dangnhap" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  
  <div class="container">
        <div class="signin-main">
            <h1>ĐĂNG NHẬP</h1>
            <asp:TextBox ID="txtMaKH" type="text" runat=server placeholder="Tên KH"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtMatkhau" type="password" runat=server placeholder="Mật khẩu"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" CssClass="submit" runat="server" Text="Đăng nhập" OnClick="btnLogin_Click" />
            <br />
            <asp:Label ID="Label1" CssClass="thongbao" runat=server ForeColor="Blue" Text=""></asp:Label>
            <br />
        </div>
     </div>
</asp:Content>

