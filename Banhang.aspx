<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Banhang.aspx.cs" Inherits="Banhang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <div style="text-align:right;font-size:16px;">
       
       Xin chào: <asp:Literal ID="ltrTenDangNhap" runat="server"></asp:Literal> | <asp:LinkButton ID="lbtDangXuat" runat="server" OnClick="lbtDangXuat_Click">Đăng xuất</asp:LinkButton>
   </div>
    <div class="panel-heading"><div style="text-align:center">GIỎ HÀNG</div> </div>
    <div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>

