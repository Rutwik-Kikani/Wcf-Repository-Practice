<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParametrizedSql_QueryDF.aspx.cs" Inherits="SqlInjectionPreventionDemo.ParametrizedSql_QueryDF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="ProductNameTextBox"></asp:TextBox>
            <asp:Button ID="GetProductsButton" runat="server" Text="Get Products" OnClick="GetProductsButton_Click" />
            <br/><br/>
            <asp:GridView ID="ProductsGridView" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
