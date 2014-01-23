<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab1_1Versaler.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style5.css" rel="stylesheet" />
</head>
<body>
    <h1 id="lol">Hur många versaler?</h1>
    <form id="form1" runat="server" method="post" action="Default.aspx">

    <div>
        <asp:TextBox ID="VersalerTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="VersalerLabel" runat="server" Text=""></asp:Label>
        <asp:Button ID="CountButton" runat="server" Text="Bestäm antalet vasaler" OnClick="CountButton_Click" />
        <asp:Button ID="ClearButton" runat="server" Text="Rensa" OnClick="ClearButton_Click" Visible="false"/>

    </div>
    </form>
</body>
</html>
