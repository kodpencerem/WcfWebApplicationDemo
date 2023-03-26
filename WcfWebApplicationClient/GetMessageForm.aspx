<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetMessageForm.aspx.cs" Inherits="WcfWebApplicationClient.GetMessageForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="font-family:Arial">

            <tr>
                <td>
                    <asp:TextBox ID="tbxGetMessage" runat="server"></asp:TextBox>
                    <asp:Button ID="btnGetMessage" runat="server" Text="Get Message" OnClick="btnGetMessage_Click" />
                </td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="lblGetMessage" runat="server" Font-Bold="true" ></asp:Label>
                </td>
            </tr>

        </table>
    </form>
</body>
</html>
