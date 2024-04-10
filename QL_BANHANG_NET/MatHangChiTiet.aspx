<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MatHangChiTiet.aspx.cs" Inherits="QL_BANHANG_NET.MatHangChiTiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dl_chitiet" runat="server">
        <ItemTemplate>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# "HinhAnh/" + Eval("HinhAnh") %>' Width="200px" />

            <asp:LinkButton ID="LinkButton2" runat="server" Text='<%# Eval("TenHang") %>'></asp:LinkButton>

            <asp:LinkButton ID="LinkButton3" runat="server" Text='<%# Eval("MoTa") %>'></asp:LinkButton>

            <asp:LinkButton ID="LinkButton4" runat="server" Text='<%# Eval("DonGia") %>'></asp:LinkButton>

        </ItemTemplate>
    </asp:DataList>
</asp:Content>
