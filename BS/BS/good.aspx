<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="good.aspx.cs" Inherits="BS.good" %>

<%@ Register src="inc/top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="inc/down.ascx" tagname="down" tagprefix="uc2" %>

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
        <tr><td rowspan="4" style="width:250px;">
            <asp:Image ID="img" runat="server" />
            </td><td>商品：<asp:Label ID="title" runat="server" Text="Label"></asp:Label>
            </td></tr>
        <tr><td>单价：<asp:Label ID="price" runat="server" Text="Label"></asp:Label>
            </td></tr>
        <tr><td>数量：<asp:Label ID="num" runat="server" Text="Label"></asp:Label>
            </td></tr>
        <tr><td><a href="user/shopping_add.aspx?id=<%=Request.QueryString["id"] %>">加入购物车</a></td></tr>
        </table>

        <table width="1000" align="center" border="0">
        <tr><td>
            <asp:Label ID="detail" runat="server" Text="Label"></asp:Label>
            </td></tr>
        </table>
        <uc2:down ID="down1" runat="server" />
    
    </div>
    </form>
</body>
</html>
