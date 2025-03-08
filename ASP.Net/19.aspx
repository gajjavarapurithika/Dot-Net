<%@ Page Language="C#" %>
<!doctype html>
<html lang="en">
    <head>
        <title>Compare validator</title>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width,initial-scale=1.0"/>
    </head>
    <body>
        <form name="fm1" runat="server">
            <asp:Label ID="lb1" runat="server" Text="Age">
            </asp:Label>
            <asp:TextBox ID="tb1" runat="server" placeholder="Enter Age" />
            <asp:Label ID="lb2" runat="server" Text="Age">
            </asp:Label>
            <asp:TextBox ID="tb2" runat="server" placeholder="Enter Age" />
            <asp:CompareValidator ErrorMessage="Ages must be equal" ControlToValidate="tb2" runat="server"  ControlToCompare="tb1" ForeColor="red"/>
    </form>

    </body>
</html>
