﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMuc_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyDanhMuc_DanhMuc_HienThi" %>

<div class="head">
    Các danh mục sản phẩm đã tạo
    <div class="fr tar">
        <a class="btThemMoi" href="/Admin.aspx?modul=SanPham&modulphu=DanhMuc&thaotac=ThemMoi">Thêm mới danh mục</a>
    </div>
</div>
<div class="KhungChuaBang">
    <table class="tbDanhMuc">
        <tr>
            <th class="cotMa">Mã DM</th>
            <th class="cotTen">Tên danh mục</th>
            <th class="cotAnh">Ảnh đại diện</th>
            <th class="cotThuTu">Thứ tự</th>
            <th class="cotCongCu">Công cụ</th>
        </tr>
        <asp:Literal ID="ltrDanhMuc" runat="server"></asp:Literal>
    </table>
</div>
<script type="text/javascript">
    function XoaDanhMuc(MaDM) {
        if (confirm("Bạn có muốn xóa danh mục này không ?")) {
            //Code xóa danh mục.
            $.post("cms/admin/SanPham/QuanLyDanhMuc/Ajax/DanhMuc.aspx",
                {
                    "ThaoTac": "XoaDanhMuc",
                    "MaDM": MaDM
                },
                function (data, status) {
                   // alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + MaDM).slideUp();

                    }
                });
        }
    }
</script>