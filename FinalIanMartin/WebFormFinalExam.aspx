<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormFinalExam.aspx.cs" Inherits="FinalIanMartin.WebFormFinalExam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            width: 60%;
            margin: auto;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1 class="auto-style1">PROG37721 - Final Exam</h1>
            <hr />
            <div class="auto-style1">
            <br />
            Select a category or a supplier to view their prodcts.<br />
                <strong><table align="center" border="1">
                <tr>
                    <td class="auto-style2">
            <strong>Categories:</strong></td>
                    <td class="auto-style2">Suppliers:</td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:DropDownList ID="ddlCategories" runat="server" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="ddlCategories_SelectedIndexChanged">
            </asp:DropDownList>
                    </td>
                    <td class="auto-style2">
            <asp:DropDownList ID="ddlSuppliers" runat="server" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="ddlSuppliers_SelectedIndexChanged">
            </asp:DropDownList>
                    </td>
                </tr>
            </table>
                <br />
            </strong>
                <asp:GridView ID="grdProducts" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" style="margin:auto;">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
            </div>
            <br />
&nbsp;&nbsp;&nbsp;
            </div>
    </form>
</body>
</html>
