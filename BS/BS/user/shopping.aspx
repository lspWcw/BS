<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="shopping.aspx.cs" Inherits="BS.user.shopping" %>

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
            <table width="100%" border="1">
            <tr align="center"><td>编号</td><td>商品</td><td>封面</td><td>价格</td><td>数量</td><td>操作</td></tr>
            <%
                string id = Request.QueryString["id"];
                if (id != null)
                {
                    BSBll.ShoppingBll.DelShopping(int.Parse(id));
                    BSUtility.JsHelper.AlertAndRedirect("删除成功！", "shopping.aspx");
                }
                BSModel.Users user1 = new BSModel.Users();
                user1 = (BSModel.Users)BSUtility.SessionHelper.GetSession("user");
                List<BSModel.Shopping> list = BSBll.ShoppingBll.ShoppingList(user1.id);
            for (int i = 0; i < list.Count; i++)
            {
             %>
            <tr align="center"><td><%=list[i].id %></td><td><%=list[i].goods.title %></td><td><img src="/img/<%=list[i].goods.img %>" width="100" alt=""/></td><td><%=list[i].goods.price %>元/人</td><td><%=list[i].num %></td><td><a href="shopping.aspx?id=<%=list[i].id %>">删除</a></td></tr>
            <%} %>
            </table>
            <table width="100%" border="0">
            <tr><td align ="right">
                <asp:Button ID="Button1" runat="server" Text="下单" onclick="Button1_Click" />
                </td></tr>
            </table>
            </td></tr>
        </table>
        <uc2:down ID="down1" runat="server" />
    
    </div>
    </form>
</body>
</html>