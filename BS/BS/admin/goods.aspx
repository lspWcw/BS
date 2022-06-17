<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goods.aspx.cs" Inherits="BS.admin.Goods" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="1000" align="center" border="1">
    <tr style="text-align: center;"><td>编号</td><td>商品</td><td>图片</td><td>价格</td><td>数量</td><td>上架时间</td><td>
        状态</td><td>操作</td></tr>
    <%
        List<BSModel.Goods> list = BSBll.GoodsBll.GoodsList();
        for (int i = 0; i < list.Count; i++)
        {
            string state = "";
            if (list[i].state == 1)
            {
                state = "正常";
            }
            else
            {
                state = "下架";
            }
         %>
         <tr style="text-align: center;"><td><%=i + 1%></td><td><%=list[i].title%></td><td><img src="../img/<%=list[i].img %>" width="200" alt="" /></td><td><%=list[i].price %></td><td><%=list[i].num %></td><td><%=list[i].addtime %></td><td><%=state %></td>
         <td><a href="../good.aspx?id=<%=list[i].id%>" target="_blank">查看</a> | <a href="goods_edit.aspx?id=<%=list[i].id%>">编辑</a></td></tr>
         <%} %>
    </table>
    </div>
    </form>
</body>
</html>
