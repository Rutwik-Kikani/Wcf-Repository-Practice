<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeServiceTestDf.aspx.cs" Inherits="MessageContractDemoClient.EmployeeServiceTestDf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="font-family: Arial; border: 1px solid black">
                <tr>
                    <td>
                        ID
                    </td>
                    <td>
                        <asp:TextBox ID="tbId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        NAME
                    </td>
                    <td>
                        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        GENDER
                    </td>
                    <td>
                        <%--<asp:DropDownList ID="ddlGender" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>--%>
                        <asp:TextBox ID="tbGender" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        DATE OF BIRTH
                    </td>
                    <td>
                        <asp:TextBox ID="tbDateOfBirth" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnGetEemployee" runat="server" Text="Get Employee" OnClick="btnGetEemployee_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnSaveEmployee" runat="server" Text="Save Employee" OnClick="btnSaveEmployee_Click" style="height: 29px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMessage" runat="server" 
                                   ForeColor="Green" Font-Bold="True"
                                   Text="lblMessage"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
