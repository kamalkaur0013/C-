<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FundTransferTo.aspx.cs" Inherits="FundTransfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bank of Algonquin</title>
    <link href="App_Themes/SiteStyles.css" rel="stylesheet" />

</head>
<body style="background-color: lightyellow">
    <h1>Online Fund Transfer Service</h1>
    <form id="form1" runat="server">
        <h2 class="distinct">Transfer To</h2>
        <asp:DropDownList ID="dropDownList" CssClass="dropdown"
            runat="server" AutoPostBack="true">

        <asp:ListItem Selected="True" value ="-1">Selected Transferee...</asp:ListItem>
        
        </asp:DropDownList><br /><br />
         <asp:RequiredFieldValidator ID="rfvFundTO" runat="server"  InitialValue="-1" ControlToValidate="dropDownList" ForeColor ="Red"
            ErrorMessage="Must Select One" Display ="Dynamic"></asp:RequiredFieldValidator>

        <asp:Label ID="lblFromAccount" runat="server" Text="From Account"></asp:Label>
       
        <asp:RadioButtonList ID="rblToAccount" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rblFromAccount_SelectedIndexChanged">
            <asp:ListItem Text="Checking">

            </asp:ListItem>
            <asp:ListItem Text="Saving"></asp:ListItem>       

        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="rfvRadioButton" runat="server"  InitialValue="" ControlToValidate="rblToAccount" ForeColor ="Red"
            ErrorMessage="Must Select An Account" Display ="Dynamic"></asp:RequiredFieldValidator><br />



        
        &nbsp;&nbsp;&nbsp;



        
        <asp:Button ID="btnback" runat="server" CssClass="button"
            OnClick="Button1_Click" Text="< Back" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="ButtonNext" runat="server"  CssClass="button"
           Text="Next >" OnClick="ButtonNext_Click" />



    </form>
</body>
</html>
