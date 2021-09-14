<%@ Page 
    Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="WebForm2.aspx.cs" 
    Inherits="FirstWebApplicationContd.WebForm2" 
    %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Enter First Name :"></asp:Label>
&nbsp;<asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter Last Name"></asp:Label>
        <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Enter Birth Day:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtbdate" runat="server" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtage" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnShowAge" runat="server" BackColor="#CC3300" BorderColor="#FF9900" BorderStyle="Double" BorderWidth="17px" Font-Bold="True" Font-Italic="True" Font-Size="Larger" ForeColor="Blue" OnClick="btnShowAge_Click" Text="CalculateAge" />
    </form>
</body>
</html>
