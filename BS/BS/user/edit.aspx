<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="BS.user.edit" %>

<%@ Register src="../inc/top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../inc/down.ascx" tagname="down" tagprefix="uc2" %>

<%@ Register src="../inc/menu.ascx" tagname="menu" tagprefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:top ID="top1" runat="server" />
        <table width="1000" align="center" border="0">
        <tr><td width="200" valign="top">
            <uc3:menu ID="menu1" runat="server" />
            </td><td align="center" valign="top">
            <table width="100%">
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
                <asp:Button ID="Button1" runat="server" Text="保存" onclick="Button1_Click"/>
                </td></tr>
            </table>
            </td></tr>
        </table>
        <uc2:down ID="down1" runat="server" />
    
    </div>
    </form>
</body>
</html>