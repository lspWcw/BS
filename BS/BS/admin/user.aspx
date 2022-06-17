<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="BS.admin.user" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="800" align="center" border="1">
    <tr style="text-align: center;"><td>编号</td><td>用户名</td><td>密码</td><td>姓名</td><td>地址</td><td>性别</td><td>电话</td><td>
        状态</td><td>时间</td><td>操作</td></tr>

    <%
        string id = Request.QueryString["id"];
        if(id != null)
        {
            if (BSBll.ShoppingBll.List(int.Parse(id)).Count > 0)
            {
                BSUtility.JsHelper.AlertAndRedirect("用户无法删除，存在尚未完成的订单！", "user.aspx");
            }
            else 
            {
                BSBll.UsersBll.DelUser(int.Parse(id));
                BSUtility.JsHelper.AlertAndRedirect("删除成功！", "user.aspx");
            }
        }
        List<BSModel.Users> list = BSBll.UsersBll.UsersList();
    %>
    <%for (int i = 0; i < list.Count; i++)
      {
          string sex = "";
          if (list[i].sex == 0)
          {
              sex = "女";
          }else
          {
              sex = "男";
          }
          string state = "";
          if (list[i].state == 1)
          {
              state = "正常";
          }
          else
          {
              state = "关闭";
          }
          %>
    <tr style="text-align: center;"><td><%=list[i].id %></td><td><%=list[i].username %></td><td>
        <%=list[i].password %></td><td><%=list[i].name %></td><td><%=list[i].address %></td><td>
        <%=sex %></td><td><%=list[i].mobile %></td><td><%=state%></td><td><%=list[i].addtime %></td><td>
        <a href="user.aspx?id=<%=list[i].id %>">删除</a> | <a href="edit_user.aspx?id=<%=list[i].id %>">编辑</a></td></tr>
    <%} %>

    </table>
    </div>
    </form>
</body>
</html>
