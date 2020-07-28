<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DivideServiceTestDF.aspx.cs" Inherits="WcfFaultContractDemoClient.DivideServiceTestDF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNumOne" runat="server" Text="Number 1"></asp:Label><br/>
            <asp:TextBox ID="tbNumOne" runat="server"></asp:TextBox><br/>
            <asp:Label ID="lblNumTow" runat="server" Text="Number 2"></asp:Label><br/>
            <asp:TextBox ID="tbNumTwo" runat="server"></asp:TextBox><br/>
            <asp:Button ID="btnDivide" runat="server" Text="Divide" OnClick="btnDivide_Click" /><br/>
            <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
            <asp:TextBox ID="tbResult" runat="server"></asp:TextBox><br/>
            <br/>
            <br/>
            <asp:Label ID="lblException" runat="server" ForeColor="Red"></asp:Label>

        </div>
    </form>
</body>
</html>
