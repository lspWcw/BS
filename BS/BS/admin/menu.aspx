<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="BS.admin.menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body style="background-color:#dedede; margin:0; padding:0;">
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr align="center"><td><a href="user.aspx" target="shopping">用户管理</a></td></tr>
                <tr align="center"><td><a href="Goods.aspx" target="shopping">商品管理</a></td></tr>
                <tr align="center"><td><a href="Goods_add.aspx" target="shopping">商品发布</a></td></tr>
                <tr align="center"><td><a href="order.aspx"  target="shopping">订单管理</a></td></tr>
            </table>
        </div>
    </form>
</body>
</html>
