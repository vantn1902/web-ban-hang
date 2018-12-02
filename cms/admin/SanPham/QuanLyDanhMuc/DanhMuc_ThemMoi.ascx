﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMuc_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyDanhMuc_DanhMuc_ThemMoi" %>

<div class="head">
    Thêm mới,chỉnh sửa danh mục sản phẩm
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Danh mục cha</div>
        <div class="oNhap"><asp:DropDownList ID="ddlDanhMucCha" runat="server"></asp:DropDownList></div>
    </div>   
    <div class="thongTin">
        <div class="tenTruong">Tên danh mục</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbTenDanhMuc" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Ảnh Đại Diện</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="hdTenAnhDaiDienCu" runat="server" />
                <asp:Literal ID="ltrAnhDaiDien" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAnhDaiDien" runat="server" />
        </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Thứ tự</div>
        <div class="oNhap">
            <asp:TextBox ID="tbThuTu" runat="server"></asp:TextBox>
        </div>
    </div>  
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbThemNhieuDanhMuc" runat="server" Text="Tạo thêm danh mục khác sau khi tạo danh mục này"/></div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" CausesValidation="false" OnClick="btHuy_Click" />
        </div>
    </div>
</div>