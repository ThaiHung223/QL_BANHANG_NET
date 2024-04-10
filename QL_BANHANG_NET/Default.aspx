<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QL_BANHANG_NET.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dl_mathang" runat="server" OnItemCommand="dl_mathang_ItemCommand">
        <ItemTemplate>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# "HinhAnh/" + Eval("HinhAnh") %>' Width="200px" />
            
            <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("MaHang") %>'></asp:LinkButton>

            <asp:LinkButton ID="LinkButton2" runat="server" Text='<%# Eval("TenHang") %>'></asp:LinkButton>

            <asp:LinkButton ID="LinkButton3" runat="server" Text="chi tiết" CommandName="ChiTiet" CommandArgument='<%# Eval("MaHang") %>'></asp:LinkButton>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
