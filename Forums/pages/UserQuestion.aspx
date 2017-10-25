<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="UserQuestion.aspx.cs" Inherits="Forums.pages.UserQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderListItem" runat="server">
     <br />
    <br />
    <br />
    <br />
    <h2>User Account</h2>
    <ul class="list-group">
        <li class="list-group-item "><a href="Profile.aspx">Profile</a></li>
        <li class="list-group-item active"><a href="UserQuestion.aspx">All Question</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <br />
    <br />
    <br />
    <br />
    <asp:repeater id="repeterShowQuestion" runat="server">
        <ItemTemplate>
           <table style="height:100px; width:100%; border:1px solid">
               <tr>
                   <td>
                       Tags: <asp:Label ID="lblTags" runat="server" Text='<%#Eval("Tags") %>'></asp:Label>
                   </td>
                    <td>
                       Date And Time:  <asp:Label ID="lblDate" runat="server" Text='<%#Eval("DateAndTime") %>'></asp:Label>                   
                    </td>
               </tr>
               <tr>
                   
                    <td colspan="2">
                        Title: <asp:Label ID="lblTitle" runat="server" Text='<%#Eval("QuestionTitle") %>'></asp:Label>
                    </td>
               </tr>
               <tr>
                   
                    <td colspan="2">
                       Question:  <asp:Label ID="lblQuestion" runat="server" Text='<%#Eval("QuestionDetails") %>'></asp:Label>
                    </td>
               </tr>
           </table>   
        </ItemTemplate>
        </asp:repeater>
</asp:Content>