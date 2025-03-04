<%@ Page Language="C#" %>
<!doctype html>
<script runat="server">
    double p, t, r, si, ci;
    
    protected void btn1_Click(object sender, EventArgs e)
    {
        p = Convert.ToDouble(tbx1.Text);
        t = Convert.ToDouble(tbx2.Text);
        r = Convert.ToDouble(tbx3.Text);
        si = p * t * r / 100;
        lb4.Text = "Simple Interest Payable: ";
        lb5.Text = Convert.ToString(si);
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        p = Convert.ToDouble(tbx1.Text);
        t = Convert.ToDouble(tbx2.Text);
        r = Convert.ToDouble(tbx3.Text);
        ci = p * Math.Pow(1 + r / 100, t) - p;
        lb4.Text = "Compound Interest Payable: ";
        lb5.Text = Convert.ToString(ci);
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        tbx1.Text = "";
        tbx2.Text = "";
        tbx3.Text = "";
        lb4.Text = "";
        lb5.Text = "";
    }
</script>

<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width,initial-scale=1.0" />
        <title>WebApplication5</title>
    </head>
    <body>
        <form name="fm1" runat="server">
            <asp:Label ID="lb1" runat="server" Text="Principal"></asp:Label>
            <asp:TextBox ID="tbx1" runat="server" placeholder="Enter principal"></asp:TextBox><br /><br />
            <asp:Label ID="lb2" runat="server" Text="Time"></asp:Label>
            <asp:TextBox ID="tbx2" runat="server" placeholder="Enter Time"></asp:TextBox><br /><br />
            <asp:Label ID="lb3" runat="server" Text="Rate of Interest"></asp:Label>
            <asp:TextBox ID="tbx3" runat="server" placeholder="Enter Interest"></asp:TextBox><br /><br />
            <asp:Button ID="btn1" runat="server" Text="Simple Interest" OnClick="btn1_Click" />
            <asp:Button ID="btn2" runat="server" Text="Compound Interest" OnClick="btn2_Click" />
            <asp:Button ID="btn3" runat="server" Text="Clear" OnClick="btn3_Click" />
            <asp:Label ID="lb4" runat="server" Text="Interest Payable"></asp:Label><br />
            <asp:Label ID="lb5" runat="server" Text=""></asp:Label>
        </form>
    </body>
</html>
