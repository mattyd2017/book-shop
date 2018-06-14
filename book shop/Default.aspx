<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="book_shop._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>The Book Shop</h2>
            </hgroup>
            <p>
                A small computer book store for all your text books!!!</p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <p>
    This is a small academic book store that specalises in textbooks and book for the budding novice computer scienctist <br />
    to browse and purchase a book please log in</p>
    <asp:Button ID="Button1" runat="server" Text="log in" OnClick="Button1_Click" />
</asp:Content>
