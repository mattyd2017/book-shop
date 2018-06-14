<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="book_shop.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>The computer book shop.</h2>
    </hgroup>

    <article>
        <p>        
           the computer book store specializing in used computer sceince textbooks.<br />
            To browse or buy a book please log in</p>

        <p>        
            &nbsp;</p>

        <p>        
            &nbsp;</p>
    </article>

    <aside>
        <h3>Links</h3>
        <p>        
            ckick the links below to log in or return to home page
        </p>
        <ul>
            <li><a runat="server" href="~/">Home</a></li>
            <li><a runat="server" href="~/Account/Login.aspx">login</a></li>
            <li><a runat="server" href="~/browse.aspx">browse</a></li>
        </ul>
    </aside>
</asp:Content>