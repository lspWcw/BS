<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BS.user.index" %>

<%@ Register src="../inc/top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../inc/down.ascx" tagname="down" tagprefix="uc2" %>

<%@ Register src="../inc/menu.ascx" tagname="menu" tagprefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:top ID="top1" runat="server" />
        <table width="1000" align="center" border="0">
        <tr><td width="200">
            <uc3:menu ID="menu1" runat="server" />
            </td><td align="center">欢迎用户:<asp:Label ID="username" runat="server" Text="Label"></asp:Label>
                使用本网站</td></tr>
        </table>
        <uc2:down ID="down1" runat="server" />
    
    </div>
    </form>
</body>
</html>
