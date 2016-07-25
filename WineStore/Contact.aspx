<%@ Page Title="Speak to the Experts" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="Contact.aspx.cs" Inherits="WineStore.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <h2><%: Title %>.</h2>
   
    <h4>Please send us an email using the below form and speak to our experts who will be happy to provide recomendations, offer suggestions for pairing wine and food or answer any other wine related queries you may have.
</h4>
    <p>&nbsp;</p>
    
    <div>
     
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" style="width: 96px">
                    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                </td>
                <td class="" style="width: 519px">
                    <asp:TextBox ID="txtName" CssClass="txtClass" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="* This Field is required"
                    ControlToValidate="txtName" ValidationGroup="save" ForeColor="Red" />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="width: 96px; height: 40px;">
                    <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td class="auto-style4" style="width: 519px; height: 40px;">
                    <asp:TextBox ID="txtLastName" CssClass="txtClass" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* This Field is required"
                    ControlToValidate="txtLastName" ValidationGroup="save" ForeColor="Red" />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="width: 96px; height: 16px;">
                    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                </td>
                <td class="auto-style4" style="width: 519px; height: 16px;">
                    <asp:TextBox ID="txtEmail" CssClass="txtClass" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* This Field is required"
                    ControlToValidate="txtEmail" ValidationGroup="save" ForeColor="Red" />
                    <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator23"
            SetFocusOnError="true" Text="Use Valid email. Example:username@gmail.com" ControlToValidate="txtEmail"
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"
            ValidationGroup="save" ForeColor="Red" />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="width: 96px">
                    <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
                </td>
                <td class="auto-style4" style="width: 519px">
                    &nbsp;
                    <asp:TextBox ID="txtMessage" runat="server" Height="102px" TextMode="MultiLine" Width="341px" OnTextChanged="txtMessage_TextChanged"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* This Field is required"
                    ControlToValidate="txtMessage" ValidationGroup="save" ForeColor="Red" />

                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSend" runat="server" Text="Send message" CssClass="btnClass" OnClick="btnSend_Click" />
                    <br />
                    <br />
                </td>
 
            </tr>
        </table>
     
    </div>
   
   
</asp:Content>

