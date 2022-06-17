<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit_user.aspx.cs" Inherits="BS.edit_user" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table  style="text-align: center;">
    <tr><td>密码：</td><td>
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td>姓名：</td><td>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td>地址：</td><td>
        <asp:TextBox ID="address" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td>性别：</td><td>
        <asp:DropDownList ID="sex" runat="server">
            <asp:ListItem Value="0">女</asp:ListItem>
            <asp:ListItem Value="1">男</asp:ListItem>
        </asp:DropDownList>
        </td></tr>
    <tr><td>手机：</td><td>
        <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td>状态：</td><td>
        <asp:DropDownList ID="state" runat="server">
            <asp:ListItem Value="0">正常</asp:ListItem>
            <asp:ListItem Value="1">关闭</asp:ListItem>
        </asp:DropDownList>
        </td></tr>
    <tr><td>
        <asp:HiddenField ID="id" runat="server" 
            onvaluechanged="HiddenField1_ValueChanged" />
        </td><td>
        <asp:Button ID="Button1" runat="server" Text="保存" onclick="Button1_Click" />
        </td></tr>
    </table>
    </div>
    </form>
</body>
</html>