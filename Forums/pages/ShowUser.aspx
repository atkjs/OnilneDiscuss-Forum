<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="ShowUser.aspx.cs" Inherits="Forums.pages.ShowUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderListItem" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <br />
    <br />
    <br />
    <h1>Show All User Information</h1>
  

    <asp:DataList ID="DataUser" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
         <ItemTemplate>
            <table style="height: 50px; width: 300px; border:1px dotted">
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="50px" ImageUrl="~/Images/user.png" />
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                         <asp:Label ID="Label2" runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                    </td>
                </tr>
            </table>

           
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
