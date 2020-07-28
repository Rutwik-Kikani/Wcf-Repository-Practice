<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserTestForm.aspx.cs" Inherits="WCFUserCRUDOperationDemoClient.UserTestForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <%--<asp:GridView ID="GridView1" runat="server">
            </asp:GridView>--%>
            <table style="border: solid 2px blueviolet; width: 100%">
                <tr>
                    <td colspan="4" style="height: 30px; background: antiquewhite; text-align: center">
                        <span class="TextTitle" style="color: coral">Registration For,</span>
                    </td>
                </tr>
                <tr>
                    <td style="height: 20px"></td>
                </tr>
                <tr>
                    <td style="width: 50%; vertical-align: top">
                        <table id="TableRegistration" cellspacing="4" cellpadding="4" width="100%" runat="server">
                            <tr>
                                <td colspan="3" style="text-align: center">
                                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"
                                        EnableViewState="False" Visible="False"></asp:Label><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class="TextTitle">UserName:</span>
                                </td>
                                <td style="padding: 10px">
                                    <asp:TextBox ID="tbUserName" runat="server" Width="256px"
                                        MaxLength="50" Height="35px"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class="TextTitle">Password:</span>
                                </td>
                                <td style="padding: 10px">
                                    <asp:TextBox ID="tbPassWord" runat="server" Width="256px"
                                        MaxLength="50" Height="35px"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class="TextTitle">Country:</span>
                                </td>
                                <td style="padding: 10px">
                                    <asp:TextBox ID="tbCountry" runat="server" Width="256px"
                                        MaxLength="50" Height="35px"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class="TextTitle">Email:</span>
                                </td>
                                <td style="padding: 10px">
                                    <asp:TextBox ID="tbEmail" runat="server" Width="256px"
                                        MaxLength="50" Height="35px"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td style="padding: 10px">
                                    <asp:Button ID="btnSubmit" runat="server" Width="256px"
                                        MaxLength="50" Height="35px" Text="Submit" OnClick="btnSubmit_Click"></asp:Button><br />
                                </td>
                            </tr>
                            <tr>
                                <td style="padding: 10px"></td>
                                <td style="padding: 10px">
                                    <asp:GridView ID="gvGridView" runat="server" BackColor="LightGoldenrodYellow"
                                        AutoGenerateColumns="False" DataKeyNames="UserID" AllowSorting="True" Width="100%"
                                        BorderColor="Tan" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="None">
                                        <AlternatingRowStyle BackColor="PaleGoldenrod" />
                                        <FooterStyle BackColor="Tan" />
                                        <HeaderStyle BackColor="Tan" Font-Bold="True" HorizontalAlign="Left" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="UserName">
                                                <ItemTemplate>
                                                    <asp:Label ID="gvlblUserName" runat="server" Text='<%#Eval("UserName") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Password">
                                                <ItemTemplate>
                                                    <asp:Label ID="gvlblPassword" runat="server" Text='<%#Eval("Password") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Country">
                                                <ItemTemplate>
                                                    <asp:Label ID="gvlblCountry" runat="server" Text='<%#Eval("Country") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Email">
                                                <ItemTemplate>
                                                    <asp:Label ID="gvlblEmail" runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Edit">
                                                <ItemStyle Width="100px" HorizontalAlign="Left"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="ImageButtonEdit" runat="server" CausesValidation="False"
                                                        OnCommand="ImageButtonEdit_OnCommand"
                                                        CommandArgument='<%#Eval("UserId") %>'
                                                        ToolTip="Edit" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Delete">
                                                <ItemStyle Width="100px" HorizontalAlign="Left"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="ImageButtonDelete" runat="server" CausesValidation="False"
                                                        OnCommand="ImageButtonDelete_OnCommand"
                                                        CommandArgument='<%#Eval("UserId") %>'
                                                        ToolTip="Delete" />
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                        </Columns>
                                        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Left" />
                                        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                                        <SortedAscendingCellStyle BackColor="#FAFAE7" />
                                        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                                        <SortedDescendingCellStyle BackColor="#E1DB9C" />
                                        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
