<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPham_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLySanPham_SanPham_ThemMoi" %>
<div class="head">
    Thêm mới,chỉnh sửa sản phẩm
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Chọn danh mục</div>
        <div class="oNhap"><asp:DropDownList ID="ddlDanhMucCha" runat="server"></asp:DropDownList></div>
    </div>   
    <div class="thongTin">
        <div class="tenTruong">Tên sản phẩm</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbTenSanPham" runat="server"></asp:TextBox>
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
        <div class="tenTruong">Số lượng</div>
        <div class="oNhap">
            <asp:TextBox ID="tbSoLuong" runat="server"></asp:TextBox>
        </div>
    </div>  
    <div class="thongTin">
        <div class="tenTruong">Giá bán</div>
        <div class="oNhap">
            <asp:TextBox ID="tbGiaBan" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Mô tả sản phẩm</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbMoTa" TextMode="MultiLine" runat="server" Height="150px"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbThemNhieuDanhMuc" runat="server" Text="Tạo thêm sản phẩm khác sau khi tạo sản phẩm này"/></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btThemMoi_Click1" />
            <asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" CausesValidation="false" OnClick="btHuy_Click1" />
        </div>
    </div>
    
</div>