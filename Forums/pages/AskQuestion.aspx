<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="AskQuestion.aspx.cs" Inherits="Forums.pages.AskQuestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderListItem" runat="server">
    <div class="askcontent">
        <h4>How to Ask Question?</h4>
        <p>First you need to search that content available or not if not available then need to </b> <a href="Login.aspx">Login</a> </b> Give's a Title that is meaningfull question . Second you need to write question Details and appropriate tags's name  </p>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <table style="height: 600px">
        <tr>
            <td colspan="2" align="center">
                <h2>Ask Question</h2>
            </td>
        </tr>
        <tr>
            <td>TITLE:</td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server" Placeholder="What's your programing question ?" CssClass="askTitle"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">

                <asp:TextBox ID="txtQuestion" runat="server" TextMode="MultiLine" Columns="60" Rows="10"></asp:TextBox>
                <hr />
                <hr />
            </td>
        </tr>
        <tr>
            <td>TAG'S:</td>
            <td>
                <asp:TextBox ID="txtTags" runat="server" Placeholder="Exp: C# , Java , PHP, .NET, C" CssClass="askTitle"></asp:TextBox>

            </td>
        </tr>

        <tr>
            <td colspan="2" align="center">
                <hr />
                <asp:Button ID="btnDubmit" runat="server" Text="Post Your Question" CssClass="btn btn-danger" OnClick="btnDubmit_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
