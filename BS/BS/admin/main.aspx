<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="BS.admin.main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id ="Head1" runat="server">
    <title></title>
</head>
<frameset rows="100,*" cols="*" frameborder="no" border="0" framespacing="0">
    <frame src="top.aspx" name="topFrame" scrolling="No" noresize="noresize" id="topFrame"></frame>
    <frameset cols="200,*" frameborder="no" border="0" framespacing="0">
        <frame src="menu.aspx" name="leftFrame" scrolling="No" noresize="noresize" id="leftFrame"></frame>
        <frame src="" name="shopping" id="mainFrame"></frame>
    </frameset>
</frameset>
<body></body>
</html>
