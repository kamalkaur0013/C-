<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Statistic Calculator</title>
</head>
<body bgcolor ="f4c2c2">

    <h1>Staticstic Calculator</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInstructions" runat="server" Text="Enter three numbers and click Submit button to find out the statistics"></asp:Label>
        </div>
        <asp:Label ID="lblFirstNumber" runat="server" Text="First Number:"></asp:Label>
        <asp:TextBox ID="txtFirstNumber" runat="server"></asp:TextBox><br />
        
        <asp:Label ID="lblSecondNumber" runat="server" Text="Second Number:"></asp:Label>
        <asp:TextBox ID="txtSecondNumber" runat="server"></asp:TextBox><br />
        
        <asp:Label ID="lblThirdNumber" runat="server" Text="Third Number:"></asp:Label>
        <asp:TextBox ID="txtThirdNumber" runat="server"></asp:TextBox><br />
       
        
        <asp:Label ID="lblerror" runat="server"  ForeColor = "#FF3300 " Visible ="false" ></asp:Label><br />
         <asp:Button ID="btnSubmit" runat="server" Text="Submit" /><br />
            <div>
            <h2>Statistics of the number you entered</h2></div>
                
        
        
            <asp:Label ID="lblMaximum" runat="server" Text="Maximum:"></asp:Label>
          

        
        
     
        <asp:Label ID="lblMaxAnswer" runat="server" Text=" "></asp:Label><br />
        
        <asp:Label ID="lblMinimum" runat="server" Text="Minimum:"></asp:Label><br />
        
        <asp:Label ID="lblAverage" runat="server" Text="Average:"></asp:Label><br />
        <asp:Label ID="lblTotal" runat="server" Text="Total:"></asp:Label>
    </form>
</body>
</html>
