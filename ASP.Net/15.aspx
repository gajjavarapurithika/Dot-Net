<%@ Page Language="C#" %>
<!doctype html>
<script runat="server">

    protected void d1_SelectedIndexChanged(object sender, EventArgs e)
    {
        lb1.Text = d1.SelectedItem.Value;
    }
</script>

<html lang="en">
    <head>
        <title>Deop Down List</title>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width,initial-scale=1.0" />
    </head>
    <body>
        <form name="fm1" runat="server">
            <asp:DropDownList ID="d1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="d1_SelectedIndexChanged">
                <asp:ListItem>Pen</asp:ListItem>
                <asp:ListItem>Pencil</asp:ListItem>
                <asp:ListItem>Book</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="lb1" runat="server" Text=""></asp:Label>
        </form>
    </body>
</html>
