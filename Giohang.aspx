<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Giohang.aspx.cs" Inherits="Giohang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
           
            <asp:BoundField DataField="MaSP" HeaderText="MaSP" SortExpression="MaSP" />
            <asp:BoundField DataField="Soluong" HeaderText="Soluong" SortExpression="Soluong" />
            <asp:BoundField DataField="DonGia" HeaderText="DonGia" SortExpression="DonGia" />
          
            <asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuanlyBanHangConnectionString %>" SelectCommand="SELECT [MaSP], [Soluong], [DonGia] FROM [Giohang]"></asp:SqlDataSource>
      <asp:Button ID="btnXoaGioHang" runat="server"  
        Text="Xóa giỏ hàng"  />
    <asp:Button ID="btnCapNhat" runat="server"  
        Text="Cập nhật"/>
    <asp:Button ID="btnTiepTuc" runat="server" PostBackUrl="~/Default.aspx" 
        Text="Tiếp tục Mua hàng" />
    <asp:Button ID="btnThanhToan" runat="server" PostBackUrl="~/ThanhToan.aspx" 
        Text="Thanh toán" />
</asp:Content>

