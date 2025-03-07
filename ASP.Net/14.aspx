<%@ Page Language="C#" %>
<!DOCTYPE html>
<script runat="server">

    protected void btn1_Click(object sender, EventArgs e)
    {
        if(r1.Checked==true)
        {
            lb1.Text = "CASH Selected";
        }
        if(r2.Checked==true)
        {
            lb1.Text = "CHEQUE Selected";
        }
        if(r3.Checked==true)
        {
            lb1.Text = "DD Selected";
        }
    }
</script>

<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0" />
    <title>Radiobutton</title>
</head>
    <body>
    <form id="form1" runat="server">
            <asp:RadioButton ID="r1" runat="server" Text="CASH" GroupName="Fees" />
        <asp:RadioButton ID="r2" runat="server" Text="CHEQUE" GroupName="Fees" />
        <asp:RadioButton ID="r3" runat="server" Text="DD" GroupName="Fees" /><br /><br />
        <asp:Button ID="btn1" runat="server" Text="Submit" OnClick="btn1_Click" /><br /><br />
        <asp:label ID="lb1" runat="server" Text=""></asp:label>
        </form>
</html>
