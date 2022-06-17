<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="BS.admin.order" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="100%" border="1">
            <tr align="center"><td>订单编号</td><td>商品明细</td><td>状态</td><td>金额</td><td>日期</td><td>操作</td></tr>
            <%
                string id = Request.QueryString["id"];
                if (Request.QueryString["action"] == "1")
                {
                    BSBll.OrderBll.UpOrder(id, 2);
                    BSUtility.JsHelper.AlertAndParentUrl("付款完成","order_list.aspx");
                }else if (Request.QueryString["action"] == "2")
                {
                    BSBll.OrderBll.UpOrder(id, 3);
                    BSUtility.JsHelper.AlertAndParentUrl("交易完成", "order_list.aspx");
                }
                List<BSModel.Order> list = BSBll.OrderBll.OrderList();
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
    </div>
    </form>
</body>
</html>
