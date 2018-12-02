<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="panel-heading" style="text-align:center; font-size:18px">SẢN PHẨM NỔI BẬT</div>

         <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetTableAdapters.SanPhamDMTableAdapter" UpdateMethod="Update">
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
         <asp:ListView ID="ListView1" runat="server" DataKeyNames="MaSP" DataSourceID="ObjectDataSource2" GroupItemCount="3">
            
             <GroupTemplate>
                 <tr id="itemPlaceholderContainer" runat="server">
                     <td id="itemPlaceholder" runat="server"></td>
                 </tr>
             </GroupTemplate>
          
             <ItemTemplate>
                <div class="col-md-4 home-grid" style="width:237px; height:350px; margin-top:15px; margin-bottom:30px; margin-left:5px">
                 
						<div class="home-product-main">
                                <div class="home-product-top">
								    <h4 style="text-align:center; padding-top:1em;"><asp:HyperLink ID="Label1" runat="server" NavigateUrl='<%# "ChiTietSanPham.aspx?MaSP=" + Eval("MaSP") %>' Text='<%# Eval("TenSP") %>' /></h4> 
								    <a href="ChiTietSanPham.aspx?MaSP=<%# Eval("MaSP") %>"><asp:Image ID="Image2" runat="server"  ImageUrl='<%# "~/images/"+ Eval("HinhAnh") %>' Width="100%" Height="220px"/></a>
							    </div>
							    <div class="home-product-bottom">
								    <p style="text-align:center; margin-top:2em;"><asp:Label ID="Label2" runat="server" Text='<%# Eval("Gia") %>'/> VND</p>
                                    <%--<asp:LinkButton ID="lbt_Themvaogio" runat="server">THÊM VÀO GIỎ</asp:LinkButton>--%>
                                 <h4 style="text-align:center;"><a  href="#">THÊM VÀO GIỎ</a></h4> 
								    <p> </p >      
							    </div>
                            </div>
						
					</div>
             </ItemTemplate>
             <LayoutTemplate>
                 <table runat="server">
                     <tr runat="server">
                         <td runat="server">
                             <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                 <tr id="groupPlaceholder" runat="server">
                                 </tr>
                             </table>
                         </td>
                     </tr>
                     <tr runat="server">
                         <td runat="server" style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;">
                             <asp:DataPager ID="DataPager1" runat="server" PageSize="12">
                                 <Fields>
                                     <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                     <asp:NumericPagerField />
                                     <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                 </Fields>
                             </asp:DataPager>
                         </td>
                     </tr>
                 </table>
             </LayoutTemplate>
            
         </asp:ListView>
     
</asp:Content>

