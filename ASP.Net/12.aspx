<%@ Page Language="C#" %>
<!doctype html>
<html lang="en">
    <head>
        <title>Bulleted List</title>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width,initial-scale=1.0" />
    </head>
    <body>
        <form name="fm1" runat="server">
            <asp:BulletedList ID="b1" runat="server" BulletStyle="Circle">
                <asp:ListItem>Pen</asp:ListItem>
                <asp:ListItem>Pencil</asp:ListItem>
                <asp:ListItem>Book</asp:ListItem>
            </asp:BulletedList>
        </form>
    </body>
</html>
