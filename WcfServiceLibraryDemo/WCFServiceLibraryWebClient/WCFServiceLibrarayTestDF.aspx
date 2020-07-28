<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WCFServiceLibrarayTestDF.aspx.cs" Inherits="WCFServiceLibraryWebClient.WCFServiceLibrarayTestDF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbMessage" runat="server" Hint ="Enter only Interger"></asp:TextBox>
            <asp:Button ID="btnGetMessage" runat="server" Text="Get Message" OnClick="btnGetMessage_Click" />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
