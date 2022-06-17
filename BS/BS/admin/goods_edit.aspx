<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goods_edit.aspx.cs" Inherits="BS.admin.goods_edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="1" align="center" width="90%">
    <tr><td>标题：</td><td>
        <asp:TextBox ID="title" runat="server" Width="400px"></asp:TextBox>
        </td></tr>
    <tr><td>价格：</td><td>
        <asp:TextBox ID="price" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td>数量：</td><td>
        <asp:TextBox ID="num" runat="server"></asp:TextBox>
        </td></tr>
    <tr><td>图片：</td><td>
        <asp:FileUpload ID="img" runat="server" />
        <asp:HiddenField ID="oldImg" runat="server" />
        </td></tr>
    <tr><td>详情：</td><td>
        <asp:TextBox ID="detail" runat="server" Height="60px" TextMode="MultiLine" 
            Width="400px"></asp:TextBox>
        </td></tr>
    <tr><td>状态：</td><td>
        <asp:DropDownList ID="state" runat="server">
            <asp:ListItem Value="1">上架</asp:ListItem>
            <asp:ListItem Value="0">下架</asp:ListItem>
        </asp:DropDownList>
        </td></tr>
    <tr><td>&nbsp;</td><td>
        <asp:Button ID="Button1" runat="server" Text="保存" onclick="Button1_Click" />
        <asp:HiddenField ID="goodsid" runat="server" />
        </td></tr>
    </table>
    </div>
    </form>
</body>
</html>
