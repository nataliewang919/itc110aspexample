<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>menu</title>
    <link href="Meal.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
 <h1>Order Menu</h1>
        <h2>Entree</h2>
<asp:CheckBoxList ID="CBLEntree" runat="server"></asp:CheckBoxList>  
        <h2>Drinks</h2>         
<asp:CheckBoxList ID="CBLDrinks" runat="server"></asp:CheckBoxList>
<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
   
 </div>   
    </form>
    
</body>
</html>
