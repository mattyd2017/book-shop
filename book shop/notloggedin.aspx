<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="notloggedin.aspx.cs" Inherits="book_shop.notloggedin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Opps to view this page you must be logged in </h2>
    <p>
        to continue press the log in button</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="log in" />
    </p>
</asp:Content>
