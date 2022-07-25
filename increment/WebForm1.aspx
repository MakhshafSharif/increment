<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="increment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:TextBox ID="TextBox1" runat="server" EnableViewState="true" ></asp:TextBox>  
            <asp:Label ID="label1" runat="server" Text="0"></asp:Label>  
            <asp:Button ID="Button1" runat="server" OnClick="IncrementCounter" Text="Submit"  /> 
        </div>
    </form>
</body>
</html>
