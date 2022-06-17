<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="BS.reg" %>
<%@ Register src="inc/top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="inc/down.ascx" tagname="down" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 460px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <uc1:top ID="top1" runat="server" />
    <table width="1000" align="center">
    <tr><td align="right" class="style1">用户名：</td><td>
        <asp:TextBox ID="username" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td align="right" class="style1">密 码：</td><td>
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td align="right" class="style1">姓 名：</td><td>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td align="right" class="style1">地 址：</td><td>
        <asp:TextBox ID="address" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td align="right" class="style1">性 别：</td><td>
        <asp:DropDownList ID="sex" runat="server">
            <asp:ListItem Value="0">女</asp:ListItem>
            <asp:ListItem Value="1">男</asp:ListItem>
        </asp:DropDownList>
        </td></tr>
    <tr><td align="right" class="style1">手 机：</td><td>
        <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td class="style1">&nbsp;</td><td>
        <asp:Button ID="Button1" runat="server" Text="注册" onclick="Button1_Click"/>
        &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="登录" 
            onclick="Button2_Click" />
        </td></tr>
    </table>
    <uc2:down ID="down1" runat="server" />
    </div>
    </form>
</body>
</html>
