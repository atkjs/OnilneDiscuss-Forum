<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Forums.Account.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderListItem" runat="server">
    <h2>User Account</h2>
    <ul class="list-group">
        <li class="list-group-item active"><a href="SignUp.aspx">Sign Up</a></li>
        <li class="list-group-item"><a href="Login.aspx">Login</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <table class="regTable" align="center">
        <tr>        
            <td><h2 style="color:blue">Create An  Account</h2></td> 
            <hr />
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtname" runat="server" placeholder="Display Name" CssClass="inputStyle"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="red" ControlToValidate="txtname" ValidationGroup="user">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorName" runat="server" ErrorMessage="Name Not Valid" ForeColor="red" ControlToValidate="txtname" ValidationGroup="user" ValidationExpression="^[a-zA-Z]+$"></asp:RegularExpressionValidator>
              </td>

        </tr>
         <tr>
            
            <td>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" CssClass="inputStyle"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="red" ControlToValidate="txtEmail" ValidationGroup="user">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Email Not Valid" ForeColor="red" ControlToValidate="txtEmail" ValidationGroup="user" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            
            </td>
        </tr>
         <tr>
           
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password" CssClass="inputStyle"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="red" ControlToValidate="txtPassword" ValidationGroup="user">*</asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>            
            <td>
                <asp:TextBox ID="txtRePassword" runat="server" TextMode="Password" placeholder="Re-Enter Password" CssClass="inputStyle"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorRePassword" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="red" ControlToValidate="txtRePassword" ValidationGroup="user">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorPassword" runat="server" ErrorMessage="Password Must be same"  ForeColor="red" ControlToValidate="txtRePassword" ControlToCompare="txtPassword"></asp:CompareValidator>
              </td>
        </tr>
        
        <tr>
            <td>
                <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" CssClass="btn-group inputStyle" OnClick="btnSignUp_Click"  ValidationGroup="user"/>
          <hr />
          </td>
        </tr>
        <tr>
            <td>
                 <%--<a href="Login.aspx"><asp:Label ID="lblSignUpmessageg" runat="server" Text="Already Sign Up?" ForeColor="red"></asp:Label></a>--%> 
                <asp:Button ID="btnLogin" runat="server" Text="Already Sign Up?" CssClass="btn-danger inputStyle" OnClick="btnLogin_Click"/>

                              
            </td>
        </tr>
    </table>
</asp:Content>
