<%@ Page Language="C#" %>
<!doctype html>
<html lang="en">
    <head>
        <title>Regular Expresssion  validator</title>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width,initial-scale=1.0"/>
    </head>
    <body>
        <form name="fm1" runat="server">
            <asp:Label ID="lb1" runat="server" Text="Age">
            </asp:Label>
            <asp:TextBox ID="tb1" runat="server" placeholder="Enter Age" />
            <asp:RegularExpressionValidator ErrorMessage="Age must be 2 digit number" ControlToValidate="tb1" runat="server" ID="rev1" ValidationExpression="\d{2}" />
    </form>

    </body>
</html>
