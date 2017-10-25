<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Answer.aspx.cs" Inherits="Forums.pages.Answer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderListItem" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <asp:Repeater ID="repeterShowQuestion" runat="server">
        <ItemTemplate>
            <hr />
            <table style="height: 50px; width: 100%">
                <tr>
                    <td>
                        <asp:Label ID="lblQuestion" runat="server" Text="Question:"  Font-Bold="true" Font-Size="Large"></asp:Label>
                        <asp:Label ID="lblQestionTitle" runat="server" Text='<%#Eval("QuestionTitle") %>' Font-Bold="true" Font-Size="Large" ForeColor="blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblQuestionDetails" runat="server" Text="Question Details:"  Font-Bold="true" Font-Size="Large"></asp:Label>
                        <asp:Label ID="lblQestion" runat="server" Text='<%#Eval("QuestionDetails") %>' Font-Bold="true" Font-Size="Medium" Font-Underline="true" ForeColor="blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                     <td>
                        Ask By:<asp:Label ID="lblUserName" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                        <asp:Label ID="lblDate" runat="server" Text='<%#Eval("DateAndTime") %>'></asp:Label>
                    </td>
                </tr>
            </table>
            <hr />
        </ItemTemplate>
    </asp:Repeater>
    <asp:Label ID="lblAnswer" runat="server" Text="Top Answer" Font-Size="X-Large"></asp:Label>
    <asp:Repeater ID="RepeaterAnswer" runat="server">
        <ItemTemplate>

            <table style="background-color:antiquewhite; height: 50px; width: 100%" >
                <tr>
                    <td>
                        <asp:Label ID="lblAns" runat="server" Text='<%#Eval("AnswerDetails") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                      Answer By:<asp:Label ID="lblUserNameAns" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                        <asp:Label ID="lblDateAns" runat="server" Text='<%#Eval("DateAndTime") %>'></asp:Label>
                    </td>
                </tr>
            </table>
            <hr />
        </ItemTemplate>
    </asp:Repeater>

    <asp:Panel ID="Panelanswer" runat="server">
         <hr />
    <table>
        <tr>
            <td>
                <h3>Your Answer:</h3>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtAnswer" runat="server" TextMode="MultiLine" Columns="60" Rows="10"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Post Your Answer" CssClass="btn btn-danger" OnClick="btnSubmit_Click" />

            </td>
        </tr>
    </table>
    <hr />
    </asp:Panel>
   
</asp:Content>
