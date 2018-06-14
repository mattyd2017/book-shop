<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="payments.aspx.cs" Inherits="book_shop.Payments.payments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
        <h2>
        Enter Delivery Address
    </h2>
    <table>
        <tr>
            <td>
                Address 1
            </td>
            <td>
                <asp:TextBox ID="TextBoxOrderAddress1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Address 2
            </td>
            <td>
                <asp:TextBox ID="TextBoxOrderAddress2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Town
            </td>
            <td>
                <asp:TextBox ID="TextBoxOrderTown" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                County
            </td>
            <td>
                <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="book_shop.booksDataContext" EntityTypeName="" OrderBy="county1" TableName="counties"></asp:LinqDataSource>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="LinqDataSource1" DataTextField="county1" DataValueField="countyid"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Post Code
            </td>
            <td>
                <asp:TextBox ID="TextBoxOrderPostCode" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit order" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

</asp:Content>
