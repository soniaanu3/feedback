﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestExcel.aspx.cs" Inherits="Campus.TestExcel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Import Excel Data into GridView</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Has Header ?"></asp:Label>
        <asp:RadioButtonList ID="rbHDR" runat="server">
            <asp:ListItem Text = "Yes" Value = "Yes" Selected = "True" ></asp:ListItem>
            <asp:ListItem Text = "No" Value = "No"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:GridView ID="GridView1" runat="server" OnPageIndexChanging = "PageIndexChanging" AllowPaging = "true"  >
        </asp:GridView>
    &nbsp;</div>
    </form>
</body>
</html>