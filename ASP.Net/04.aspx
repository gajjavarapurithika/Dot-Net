<%@ Page Language="C#" %>
<!doctype html>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Redirect to the desired URL when the button is clicked
        Response.Redirect("https://www.indiatimes.com");
    }
</script>

<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width,initial-scale=1.0" />
    <title>WebApplication4</title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <asp:Button ID="Button1" runat="server" Text="INDIATIMES" OnClick="Button1_Click" />
        </div>
        </body>
    </form>
    </html>
    
