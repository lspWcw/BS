<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order_list.aspx.cs" Inherits="BS.user.order_list" %>

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
            <tr align="center"><td>订单编号</td><td>商品明细</td><td>状态</td><td>金额</td><td>日期</td><td>操作</td></tr>
            <%
                string id = Request.QueryString["id"];
                if (Request.QueryString["action"] == "1")
                {
                    BSBll.OrderBll.UpOrder(id, 2);
                    BSUtility.JsHelper.AlertAndRedirect("付款完成","order_list.aspx");
                }else if (Request.QueryString["action"] == "2")
                {
                    BSBll.OrderBll.UpOrder(id, 3);
                    BSUtility.JsHelper.AlertAndRedirect("交易完成", "order_list.aspx");
                }
                
                
                BSModel.Users user1 = new BSModel.Users();
                user1 = (BSModel.Users)BSUtility.SessionHelper.GetSession("user");

                List<BSModel.Order> list = BSBll.OrderBll.OrderList(user1.id);
            for (int i = 0; i < list.Count; i++)
            {
                string state = "";
                if (list[i].state == 1)
                {
                    state = "未付款";
                }else if(list[i].state == 2)
                {
                    state = "已付款";
                }
                else
                {
                    state = "已成交";
                }
                
             %>
            <tr align="center"><td><%=list[i].id %></td><td>
            <table>
            <%
                List<BSModel.Shopping> shoppingList = BSBll.ShoppingBll.ShoppingList(list[i].id);
                for (int j = 0; j < shoppingList.Count; j++)
                {
            %>
            <tr><td><img src="/img/<%=shoppingList[j].goods.img %>" width="100" alt=""/></td><td><%=shoppingList[j].goods.title%> : </td><td><%=shoppingList[j].goods.price%> * <%=shoppingList[j].num%> = </td><td><%=shoppingList[j].goods.price * shoppingList[j].num%>元</td></tr>
            <%} %>
            </table>
            </td><td><%=state%></td><td><%=list[i].amount %>元</td><td><%=list[i].addtime%></td><td>
                <a href="order_list.aspx?id=<%=list[i].id %>&action=1">付款</a> | <a href="order_list.aspx?id=<%=list[i].id %>&action=2">完成</a></td></tr>
            <%} %>
            </table>
            </td></tr>
        </table>
        <uc2:down ID="down1" runat="server" />
    
    </div>
    </form>
</body>
</html>
