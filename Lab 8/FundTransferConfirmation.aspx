<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FundTransferConfirmation.aspx.cs" Inherits="FundTransferConfirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bank of Algonquin</title>
     <link href="App_Themes/SiteStyles.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <h1>Online Fund Transfer Service</h1>
        <h2 class="distinct">Review And Complete</h2>
        <div>
            <asp:Label ID="lbltransfror" runat="server" Text="Transferor"></asp:Label><br />
            <br />
        <asp:Label ID="lbltransfrorName" runat="server" Text="Name:"></asp:Label>
            <br />
            <asp:Label ID="lbltransfrorAccount" runat="server" Text="Account:"></asp:Label>
            <br />
             <asp:Label ID="lblAmount" runat="server" Text="Amount:"></asp:Label><br /><br />
            <br />


            <asp:Label ID="lbltransferee" runat="server" Text="Transferee"></asp:Label><br />
            <br />
            <br />
            <asp:Label ID="lbltransfereeName" runat="server" Text="Name:"></asp:Label>
            <br />
            <asp:Label ID="lbltransfereeAccount" runat="server" Text="Account:"></asp:Label>
            <br />
            <br />
           
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
            <asp:Button ID="BtnBack" runat="server" CssClass="button"
                Text="<Back" OnClick="BtnBack_Click" />
           
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
            <asp:Button ID="BtnComplete" runat="server" CssClass="button"
                Text="Complete" OnClick="BtnComplete_Click" />
           
            <br />


        </div>
        

        
    </form>
</body>
</html>
