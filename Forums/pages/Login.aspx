<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Forums.Account.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderListItem" runat="server">
    <br />
    <br />
    <br />
    <br />
    <asp:Panel ID="Panel1" runat="server">
        <ul class="list-group">
        <li class="list-group-item "><a href="Profile.aspx">Profile</a></li>
        <li class="list-group-item "><a href="UserQuestion.aspx">All Question</a></li>
    </ul>
    </asp:Panel>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <asp:Panel ID="PanelLogin" runat="server">
         <table class="loginTable" align="center">
        <tr>

            <td>
                <h2 style="color: blue">Log In</h2>
            </td>
            <hr />
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblErroeMessage" runat="server" Text="" ForeColor="red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" CssClass="inputStyle"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is Required" ControlToValidate="txtEmail" ValidationGroup="userLogin" ForeColor="red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>

            <td>
                <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" CssClass="inputStyle" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password is Required" ControlToValidate="txtPassword" ValidationGroup="userLogin" ForeColor="red"></asp:RequiredFieldValidator>
            
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn-group inputStyle" OnClick="btnLogin_Click"  ValidationGroup="userLogin"/>
                <hr />
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Not Have any Account ? Sign Up" CssClass="btn-danger inputStyle" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    </asp:Panel>
   
   
            <asp:HiddenField ID="hiddenUserId" runat="server"/>
        
</asp:Content>
