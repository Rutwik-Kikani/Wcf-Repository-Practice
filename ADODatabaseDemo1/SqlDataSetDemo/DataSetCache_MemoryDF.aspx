<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataSetCache_MemoryDF.aspx.cs" Inherits="SqlDataSetDemo.DataSetCache_MemoryDF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLoadData" runat="server" Text="Load Data" 
                        onclick="btnLoadData_Click" />
            <asp:Button ID="btnClearnCache" runat="server" Text="Clear Cache" 
                        onclick="btnClearnCache_Click" />
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="gvProducts" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
