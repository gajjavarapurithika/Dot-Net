<%@ Page Language="C#" %>
<!doctype html>
<script runat="server">

    protected void b1_Click(object sender, EventArgs e)
    {
        if(c1.Checked==true&&c2.Checked==true&&c3.Checked==true)
        {
            l1.Text = "All hobbies selected";
        }
        else if(c1.Checked==true&&c2.Checked==true)
        {
            l1.Text = "Reading and writing are selected";
        }
         else if(c1.Checked==true&&c3.Checked==true)
         {
             l1.Text = "Reading and sleeping are selected";
         }
         else if(c2.Checked==true&&c3.Checked==true)
         {
             l1.Text = "writing and sleeping are selected";
         }
          else if(c1.Checked==true)
         {
             l1.Text = "Reading selected";
         }
           else if(c2.Checked==true)
             {
                 l1.Text = "writing  selected";
             }
            else if(c3.Checked==true)
             {
                 l1.Text = "Sleeping  selected";
             }
    }
</script>

<html lang="en">
    <head>
        <title>Checkbox</title>
        <meta charset="uft-8" />
        <meta name="viewport" content="width=device-width,initial-scale=1.0" />
    </head>
    <body>
        <form name="fm1" runat="server">
            <asp:CheckBox ID="c1" runat="server" Text="Reading" />
            <asp:CheckBox ID="c2" runat="server" Text="Writing" />
            <asp:CheckBox ID="c3" runat="server" Text="Sleeping" /><br /><br />
            <asp:Button ID="b1" runat="server" Text="Submit" OnClick="b1_Click" /><br /><br />
            <asp:Label ID="l1" Text=" " runat="server"></asp:Label>
        </form>
    </body>
</html>
