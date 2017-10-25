<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Tags.aspx.cs" Inherits="Forums.pages.Tags" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderListItem" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h1>Show All Tags</h1>
    <asp:DataList runat="server" ID="DataTags" RepeatColumns="3" RepeatLayout="Table" RepeatDirection="Horizontal">
          <ItemTemplate>
              <table style="height: 50px; width: 200px; border:1px dotted">
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="50px" ImageUrl="~/Images/tags.png" />
                       <asp:Label ID="Label1" runat="server" Text='<%#Eval("Tags") %>' ></asp:Label>
                    </td>
                </tr>
            </table>
              
              </ItemTemplate>
    </asp:DataList>
</asp:Content>
