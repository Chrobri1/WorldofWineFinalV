<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="Contact.aspx.cs" Inherits="WineStore.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <h2><%: Title %>.</h2>
   

    
    <div>
     
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtName" CssClass="txtClass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtLastName" CssClass="txtClass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblEmail" runat="server" Text="Email address"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtEmail" CssClass="txtClass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtMessage" runat="server" Height="102px" TextMode="MultiLine" Width="341px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Button ID="btnSend" runat="server" Text="Send message" CssClass="btnClass" OnClick="btnSend_Click" />
                </td>
 
            </tr>
        </table>
     
    </div>
   
   
</asp:Content>

