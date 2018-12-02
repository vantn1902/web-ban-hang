<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChiTietSanPham.aspx.cs" Inherits="ChiTietSanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .btnmua{
            background-color: cadetblue;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="panel-heading">CHI TIẾT SẢN PHẨM  </div>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataBy1" TypeName="DataSetTableAdapters.SanPhamDMTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_MaSP" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="TenSP" Type="String" />
                <asp:Parameter Name="HinhAnh" Type="String" />
                <asp:Parameter Name="Mota" Type="String" />
                <asp:Parameter Name="Soluong" Type="Int32" />
                <asp:Parameter Name="Gia" Type="Int32" />
                <asp:Parameter Name="MaDM" Type="Int32" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter Name="ID_SP" QueryStringField="MaSP" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="TenSP" Type="String" />
                <asp:Parameter Name="HinhAnh" Type="String" />
                <asp:Parameter Name="Mota" Type="String" />
                <asp:Parameter Name="Soluong" Type="Int32" />
                <asp:Parameter Name="Gia" Type="Int32" />
                <asp:Parameter Name="MaDM" Type="Int32" />
                <asp:Parameter Name="Original_MaSP" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <asp:DataList ID="DataList2" runat="server" DataKeyField="MaSP" DataSourceID="ObjectDataSource2" >
            <ItemTemplate>
               <div class="col-md-4 " style="margin-top:15px; margin-bottom:30px; margin-left:30px">	
                    <asp:Image ID="Image2" runat="server" ImageUrl='<%# "~/images/"+ Eval("HinhAnh") %>'  Width="260px" Height="260px"/>
			    </div>
		
			    <div class="col-md-4" style="margin-top:15px; margin-bottom:30px; margin-left:100px; color:darkblue">
				    <h3><asp:Label ID="Label1" runat="server" Text='<%# Eval("TenSP") %>' />		    
				    <h4>Đơn giá: <asp:Label ID="Label3" runat="server" Text='<%# Eval("Gia") %>' /></h4>
                     <h4>Số lượng: <asp:Label ID="SoluongLabel" runat="server" Text='<%# Eval("Soluong") %>' /></h4>    	
				    <p>Mô tả:<asp:Label ID="Label2" runat="server" Text='<%# Eval("Mota") %>' /></p>
                    <asp:Button ID="btnMua" runat="server" Text="THÊM VÀO GIỎ" CommandArgument='<%# Eval("MaSP") %>' CssClass="btnmua"/>
				   <%-- <a href="Giohang.aspx">THÊM VÀO GIỎ</a>		--%>			
			    </div>
		        <div class="clearfix"> </div>
            </ItemTemplate>
        </asp:DataList>
</asp:Content>

