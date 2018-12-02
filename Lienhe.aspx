<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Lienhe.aspx.cs" Inherits="Lienhe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="panel-heading">LIÊN HỆ</div>
     <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div style="margin-left:18em;">
                   <h2>Thông tin công ty :</h2>
					    <p>Đường Ngô Quyền,</p>
					    <p>Đà Nẵng - Việt Nam</p>
				   	    <p>Điện thoại:(00) 222 666 444</p>
				   	    <p>Fax: (000) 000 00 00 0</p>
				 	    <p>Email: <span><a href="smartshop.com">smartshop@gmail.com</a></span></p>
				   	    <p>Kết nối : <span>Facebook</span>, <span>Twitter</span></p>
                    <br />
                    <br />
                    <br />
                    <br />
                </div>
            </div>
            <div class="col-md-9" style=" margin-right:10em">
				 <div class=" signin-main " style="float:left">
			        <h3>Liên hệ với chúng tôi: </h3>
                    <br />
                    <asp:TextBox ID="txtHoten"  runat=server type="text" placeholder="Họ tên"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtEmail" runat=server type="text" placeholder="Email"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtTieude"  runat=server type="text" placeholder="Tiêu đề"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtNoidung" runat=server type="text" placeholder="Nội dung"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnGui" CssClass="submit" runat="server" Text="Gửi" OnClick="btnGui_Click" />
                    <br />
		            </div>   
            </div>
        </div>
    </div>
</asp:Content>

