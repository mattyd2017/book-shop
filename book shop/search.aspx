<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="book_shop.search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1
        {
            width: 54%;
        }
        .auto-style2
        {
            height: 23px;
        }
        .auto-style3
        {
            height: 23px;
            width: 129px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">book title</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxBookTitle" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="search" Width="284px" />
    </p>
    <p>
        return to browsing the books
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/browse.aspx">HERE</asp:HyperLink>
    </p>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="bookid" ForeColor="#333333" Height="344px" HorizontalAlign="Justify" Width="946px" OnRowCommand="GridView1_RowCommand" EnablePersistedSelection="True" EnableSortingAndPagingCallbacks="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:ImageField DataImageUrlField="bookImageURL">
            </asp:ImageField>
            <asp:BoundField DataField="bookTitle" HeaderText="bookTitle" SortExpression="bookTitle" />
            <asp:BoundField DataField="bookPrice" DataFormatString="{0:c}" HeaderText="bookPrice" SortExpression="bookPrice" />
            <asp:ButtonField CommandName="AddToCart" Text="Add to cart" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="check out" Width="284px" />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
