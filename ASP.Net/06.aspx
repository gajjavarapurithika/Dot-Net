<%@ Page Language="C#"%>
<!Doctype html>
<script runat="server">
    int a,b,c;
    protected void btn1_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(tb1.Text);
        b = Convert.ToInt32(tb2.Text);
        c = a + b;
        tb3.Text = Convert.ToString(c);
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(tb1.Text);
        b = Convert.ToInt32(tb2.Text);
        c = a - b;
        tb3.Text = Convert.ToString(c);
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(tb1.Text);
        b = Convert.ToInt32(tb2.Text);
        c = a * b;
        tb3.Text = Convert.ToString(c);
    }

    protected void btn4_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(tb1.Text);
        b = Convert.ToInt32(tb2.Text);
        c = a / b;
        tb3.Text = Convert.ToString(c);
    }

    protected void btn5_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(tb1.Text);
        b = Convert.ToInt32(tb2.Text);
        c = a % b;
        tb3.Text = Convert.ToString(c);
    }
</script>

<head>
        <meta charset="utf-8" />
         <meta name="viewport" content="width=device-width,initial-scale=1.0" />
        <title>Simple Calcuator</title>
        <style>
            body {
                background-color: #f1f1f1;
                font-family: Arial, sans-serif;
            }
        </style>
    </head>
<body>
    <form id="fm1" runat="server">
        <asp:Label ID="lb1" runat="server" Text="A"> </asp:Label>
        <asp:Textbox Id="tb1" runat="server" ></asp:Textbox>
        <asp:Label ID="lb2" runat="server" Text="B"> </asp:Label>
        <asp:Textbox Id="tb2" runat="server" ></asp:Textbox>
        <asp:Label ID="lb3" runat="server" Text="C"></asp:Label>
        <asp:Textbox Id="tb3" runat="server" enabled="false"></asp:Textbox><br /><br />
        <asp:Button ID="btn1" runat="server" Text="+" OnClick="btn1_Click" />
        <asp:Button ID="btn2" runat="server" Text="-" OnClick="btn2_Click" />
        <asp:Button ID="btn3" runat="server" Text="*" OnClick="btn3_Click" />
        <asp:Button ID="btn4" runat="server" Text="/" OnClick="btn4_Click" />
        <asp:Button ID="btn5" runat="server" Text="%" OnClick="btn5_Click" /> 
    </form>
</body>
</html>
