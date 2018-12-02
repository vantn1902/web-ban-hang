<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPhamLoadControl.ascx.cs" Inherits="cms_admin_SanPham_SanPhamLoadControl" %>
<style type="text/css">
    .cotTrai{float:left;width:18%;box-sizing:border-box;border:solid 1px #dfdfdf;min-height:464px}
    .cotPhai{float:right;width:80%;box-sizing:border-box;border:solid 1px #dfdfdf;min-height:464px;}

    /*Css cho menu quản lý trái*/
.cotTrai .head{background:#f9f9f9;padding:10px;font-weight:bold;border-top:solid 1px #dfdfdf;border-bottom:solid 1px #dfdfdf}
.cotTrai .head:first-child{border-top:none}
.cotTrai ul li{padding:5px 0}
.cotTrai ul li a.current,
.cotTrai ul li a:hover{color:#ff006e}

/*Cột phải*/
.cotPhai .head{background:#f9f9f9;padding:10px;font-weight:bold;border-top:solid 1px #dfdfdf;border-bottom:solid 1px #dfdfdf}
.cotPhai .head:first-child{border-top:none}
</style>
<div class="container">
    <div style="clear:both;height:20px"></div>
<div class="cotTrai">
    <div class="head">
        Quản lý
    </div>
    <ul>
        <li><a href="/Admin.aspx?modul=SanPham&modulphu=DanhMuc">Quản lý danh mục</a></li>
        <li><a href="/Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham">Quản lý sản phẩm</a></li>
    </ul>
    <div class="head">
        Thêm mới
    </div>
    <ul>
        <li><a href="/Admin.aspx?modul=SanPham&modulphu=DanhMuc&thaotac=ThemMoi">Quản lý danh mục</a></li>
        <li><a href="/Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham&thaotac=ThemMoi">Quản lý sản phẩm</a></li>
    </ul>
</div>
<div class="cotPhai">
    <asp:PlaceHolder ID="plSanPhamLoadControl" runat="server"></asp:PlaceHolder>
</div>
<div class="cb"><%------%></div>
 </div>