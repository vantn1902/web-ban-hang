<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dangki.aspx.cs" Inherits="Dangki" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
		<div class="signin-main">
			<h1>Đăng ký thành viên</h1>
			<h2>Thông tin</h2>
             <asp:TextBox ID="txtHoten"  runat=server type="text" placeholder="Họ tên"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtSdt" runat=server type="text" placeholder="Số điện thoại"></asp:TextBox>
            <br />    
            <asp:TextBox ID="txtDiachi" runat=server type="text" placeholder="Địa chỉ"></asp:TextBox>
            <br />   
             <asp:TextBox ID="txtEmail" runat=server type="text" placeholder="Email"></asp:TextBox>
            <br />
			 <asp:TextBox ID="txtPass" runat=server type="password" placeholder="Mật khẩu"></asp:TextBox>
            <br />
            <asp:Button ID="btnDangky" CssClass="submit" runat="server" Text="Đăng ký" OnClick="btnDangky_Click"/>
            <br />
		</div>
	</div>
</asp:Content>

