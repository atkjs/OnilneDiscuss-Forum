<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="welcomePage.aspx.cs" Inherits="Forums.pages.welcomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderListItem" runat="server">
      <h1>Tags</h1>
      <asp:repeater id="RepeaterTag" runat="server">
          <ItemTemplate>
              <ul class="list-group">
                  <li class="list-group-item active"><a href="Tags.aspx"><%#Eval("Tags") %></a></li>
              </ul>
              <%--<asp:LinkButton ID="LinkButtonTag" runat="server" Text='<%#Eval("Tags") %>'></asp:LinkButton>--%>
          </ItemTemplate>
      </asp:Repeater>
        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h1>Top Question</h1>
    
     <asp:repeater id="repeterShowQuestion" runat="server">
        <ItemTemplate>
            <hr />
    <table style="height:50px; width:100%">
        <tr>
            <td colspan="3">
                <asp:LinkButton ID="linkButtonAnswer" runat="server" Text='<%#Eval("QuestionDetails")%>'  Font-Bold="true" Font-Size="16px" ForeColor="#0095ff" OnClick="linkButtonAnswer_Click"></asp:LinkButton>
               
            </td>
        </tr>
        <tr>
             <td>
                 <asp:LinkButton ID="lbtntags" runat="server" Text='<%#Eval("Tags") %>'></asp:LinkButton>
            </td>
            <td>
                <asp:Label ID="lblUserName" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                 <asp:Label ID="lblDate" runat="server" Text='<%#Eval("DateAndTime") %>'></asp:Label>
            </td>
            
        </tr>
    </table>
            <hr />

            <asp:HiddenField ID="HiddenQuestionId" runat="server" Value='<%#Eval("QuestionId")%>'/>
            </ItemTemplate>
        </asp:repeater>
    
</asp:Content>
