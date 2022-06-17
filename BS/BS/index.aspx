<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BS.index" %>

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
        <div style="width:1000px; margin:0 auto;">
        <ul style="list-style:none; margin:0;padding:0;">
        <%
            List<BSModel.Goods> list = BSBll.GoodsBll.OnlineGoodsList();
        for (int i = 0; i < list.Count; i++)
        {
         %>
         <li style="float:left; height:180px; width:238px; text-align:center; border:#dedede solid 1px; margin:10px 10px 10px 0;"><a href="good.aspx?id=<%=list[i].id%>" target="_blank"><img src="../img/<%=list[i].img %>" width="100%" height="80%" alt=""/><%=list[i].title%> | <%=list[i].price %>元/人</a></li>
         <%} %>
         </ul>
        </div>
        <uc2:down ID="down1" runat="server" />
    
    </div>
    </form>
</body>
</html>
