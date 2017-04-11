<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calendar.aspx.cs" Inherits="calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Array Sample</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:Label ID="ResultLabel" runat="server" Text="Author"></asp:Label><br />
        <asp:DropDownList ID="AuthorsDropDownList" runat="server" AutoPostBack="True" 
            OnSelectedIndexChanged="AuthorsDropDownList_SelectedIndexChanged"></asp:DropDownList>
       
    </div>
    </form>
</body>
</html>
