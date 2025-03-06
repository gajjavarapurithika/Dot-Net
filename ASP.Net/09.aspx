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
                <asp:TableRow>
                <asp:TableCell>ENO</asp:TableCell>
                <asp:TableCell>ENAME</asp:TableCell>
                <asp:TableCell>ESAL</asp:TableCell>
                <asp:TableCell>EGRADE </asp:TableCell>
</asp:TableRow>
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
