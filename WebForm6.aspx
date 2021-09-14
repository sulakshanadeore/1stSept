<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="FirstWebApplicationContd.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>Select Your Data:
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Personal</asp:ListItem>
                        <asp:ListItem>Educational</asp:ListItem>
                        <asp:ListItem>Upload</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:MultiView ID="MultiView1" runat="server">
                        <asp:View ID="Personal" runat="server">
                            <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </asp:View>

                        <asp:View ID="Educational" runat="server">
                            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

                        </asp:View>

                        <asp:View ID="Upload" runat="server">
                        Upload File :    <asp:FileUpload ID="FileUpload1" runat="server" />
                            &nbsp;
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload Resume" />
                        </asp:View>

                    </asp:MultiView>
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
