<%@ Page Language="C#" %>
<!doctype html>
<html lang="en">
    <head>
        <title>Table1</title>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width,initial-scale=1.0" />
    </head>
    <body>
        <form name="fm1" runat="server">
            <asp:Table GridLines= "Both" runat="server">
                <asp:TableHeaderRow>
                <asp:TableHeaderCell>ENO</asp:TableHeaderCell>
                <asp:TableHeaderCell>ENAME</asp:TableHeaderCell>
                <asp:TableHeaderCell>ESAL</asp:TableHeaderCell>
                <asp:TableHeaderCell>EGRADE </asp:TableHeaderCell>
</asp:TableHeaderRow>
                <asp:TableRow>
     <asp:TableCell>121</asp:TableCell>
     <asp:TableCell>Raj</asp:TableCell>
     <asp:TableCell>6743</asp:TableCell>
     <asp:TableCell>A </asp:TableCell>
 </asp:TableRow>
                <asp:TableRow>
     <asp:TableCell>153</asp:TableCell>
     <asp:TableCell>Varun</asp:TableCell>
     <asp:TableCell>2312</asp:TableCell>
     <asp:TableCell>A+ </asp:TableCell>
         </asp:TableRow>
 </asp:Table>
        </form>
    </body>
</html>
