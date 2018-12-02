<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaiKhoan_ThemMoi.ascx.cs" Inherits="cms_admin_TaiKhoan_TaiKhoan_ThemMoi" %>
<div class="head">
    Thêm mới, chỉnh sửa tài khoản
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Chọn quyền</div>
        <div class="oNhap"><asp:DropDownList ID="ddlQuyenDangNhap" runat="server"></asp:DropDownList></div>
    </div>   
    <div class="thongTin">
        <div class="tenTruong">Tên đăng nhập</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbTenDangNhap" runat="server"></asp:TextBox>
           
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Mật khẩu</div>
        <div class="oNhap"> 
            <asp:HiddenField ID="hdMatKhauCu" runat="server" />           
            <asp:TextBox ID="tbMatKhau" runat="server" TextMode="Password"></asp:TextBox>
           
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Email</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Địa chỉ</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbDiaChi" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Họ tên</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbHoTen" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Ngày sinh (Tháng/Ngày/Năm)</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbNgaySinh" runat="server"></asp:TextBox>
        </div>
    </div>
   
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbThemNhieuDanhMuc" runat="server" Text="Tạo thêm tài khoản khác sau khi tạo tài khoản này"/></div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btThemMoi_Click"  />
            <asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy"  CausesValidation="false" OnClick="btHuy_Click" />
        </div>
    </div>
</div>