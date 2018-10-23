<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FundTransferResult.aspx.cs" Inherits="FundTransfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bank of Algonquin</title>
    <link href="App_Themes/SiteStyles.css" rel="stylesheet" />

</head>
<body style="background-color: lightyellow">
    <h1>Online Fund Transfer Service</h1>
    <form id="form1" runat="server">
        <p>Thank you for using our online fund transfer service</p>
        <p>Amount $ 
            <asp:Label ID="lblAmount" runat="server" ></asp:Label>
            Has been transfered</p>

        <asp:Label ID="Label1" runat="server" Text="From"></asp:Label>
        
        <p>
            <asp:Label ID="lblTransferor" runat="server" Text="Name"></asp:Label>
        </p>

        <p>
            <asp:Label ID="lblTransferorAccount" runat="server" Text="Account:"></asp:Label>
        </p>

        <asp:Label ID="Label2" runat="server" Text="To"></asp:Label>

         <p>
            <asp:Label ID="lblTransferee" runat="server" Text="Name"></asp:Label>
        </p>

        <p>
            <asp:Label ID="lblTransfereeAccount" runat="server" Text="Account:"></asp:Label>
        </p>
        
        <asp:Button ID="Button" runat="server" CssClass="button"
            Text="Strat a new Transfer" OnClick="Button_Click" />
        
    </form>
</body>
</html>
