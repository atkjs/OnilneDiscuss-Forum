<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Forums.pages.Profile" %>

<%@ Register Src="~/CalenderControl.ascx" TagPrefix="uc1" TagName="CalenderControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderListItem" runat="server">
    <br />
    <br />
    <br />
    <br />
    <h2>User Account</h2>
    <ul class="list-group">
        <li class="list-group-item active"><a href="Profile.aspx">Profile</a></li>
        <li class="list-group-item "><a href="UserQuestion.aspx">All Question</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <br />
    <br />
    <br />
    <br />
      <asp:Panel ID="PanelAddProfile" runat="server">
         <table class="regTable" align="center">
             <tr>
                 <td align="center"><h2>Enter Your Information</h2></td>
             </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="txtPhone" runat="server" placeholder="Phone Number" TextMode="Number" CssClass="inputStyle"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="txtLocation" runat="server" placeholder="City" CssClass="inputStyle"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="txtProfession" runat="server" placeholder="Profession" CssClass="inputStyle"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="txtAbout" runat="server" placeholder="About" CssClass="inputStyle"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td align="center">
             <asp:Button ID="btnLogin" runat="server" Text="Add Your Details" CssClass="btn-group inputStyle" ValidationGroup="userLogin" OnClick="btnLogin_Click"/>
            </td>
        </tr>
    </table>
    </asp:Panel>
    <asp:Panel ID="PanelView" runat="server">
    <br />
    <br />
        <h1>Your Profile</h1>
            <asp:repeater id="repeterShowUserInformation" runat="server">
        <ItemTemplate>
             <table style="height: 100px; width: 100px;" align="center">
                <tr>
                    <td>
                        <asp:Image ID="ImageUser" runat="server" Height="50px" ImageUrl="~/Images/user.png" Width="50px"/>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="ImageEmail" runat="server" Height="50px" ImageUrl="~/Images/email-icon.png" Width="50px"/>
                         <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                    </td>
                </tr>

                 <tr>
                    <td>
                          <asp:Image ID="Imagephone" runat="server" Height="50px" ImageUrl="~/Images/tel.png" Width="50px"/>
                         <asp:Label ID="Label3" runat="server" Text='<%#Eval("phone") %>'></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="50px" ImageUrl="~/Images/ane-location-icon.png" Width="50px" />
                         <asp:Label ID="Label4" runat="server" Text='<%#Eval("location") %>'></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Image ID="ImageAbout" runat="server" Height="50px" ImageUrl="~/Images/About-icon.png" Width="50px" />
                         <asp:Label ID="Label5" runat="server" Text='<%#Eval("carear") %>'></asp:Label>
                    </td>
                </tr>
            </table>

            </ItemTemplate>
                </asp:repeater>
    </asp:Panel>
    
    
    
  
</asp:Content>
