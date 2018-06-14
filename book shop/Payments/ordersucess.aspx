<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ordersucess.aspx.cs" Inherits="book_shop.Payments.invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>order sucessfully placed onto database!!!!</h2>
    <asp:Button ID="Button1" runat="server" Text="browse books" OnClick="Button1_Click" />
</asp:Content>
