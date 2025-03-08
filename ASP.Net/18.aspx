<%@ Page Language="C#" %>
<!doctype html>
<html lang="en">
    <head>
        <title>Range validator2</title>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width,initial-scale=1.0"/>
    </head>
    <body>
        <form name="fm1" runat="server">
            <asp:Label ID="lb1" runat="server" Text="Age">
            </asp:Label>
            <asp:TextBox ID="tb1" runat="server" placeholder="Enter Age" />
            <asp:RequiredFieldValidator ErrorMessage="Age is must" ControlToValidate="tb1" runat="server" ForeColor="red"/>
            <asp:RangeValidator ErrorMessage="Age must be brtween 18 and 23" ControlToValidate="tb1" runat="server"  Type="Integer" MaximumValue="23" MinimumValue="18" ForeColor="red"/>
        </form>
    </body>
</html>
