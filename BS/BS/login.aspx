<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BS.login" %>
<%@ Register src="inc/top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="inc/down.ascx" tagname="down" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 458px;
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
    <tr><td align="right" class="style1">密  码：</td><td>
        <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
        </td></tr>
    <tr><td class="style1">&nbsp;</td><td>
        <asp:Button ID="Button1" runat="server" Text="登 录" onclick="Button1_Click" />
        &nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="注册" 
            onclick="Button2_Click" />
        </td></tr>
    </table>
    <uc2:down ID="down1" runat="server" />
    </div>
    </form>
</body>
</html>

