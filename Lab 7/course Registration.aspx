<%@ Page Language="C#" AutoEventWireup="true" CodeFile="course Registration.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Algonquin College Course Registration</title>
    
    <link href="App_Themes/SiteStyles.css" rel="stylesheet" />
</head>
<body>
    <h1 >Algonquin College Course Registration</h1>

    <form id="form1" runat="server" visible ="true">
        <div><asp:Panel ID="pnlStudentType" CssClass="displayInline marginLeft15" runat="server">
            <asp:Label ID="lblStudentName" runat="server" Text="Student Name"></asp:Label>
            <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
            <asp:RadioButton ID="btuFulltime"  GroupName="radio" runat="server" Text="Full Time" />
            <asp:RadioButton ID="btuparttime"  GroupName="radio" runat="server" Text="Part Time" />
            <asp:RadioButton ID="btucoop" GroupName="radio" runat="server" Text="Co-op" /> </asp:Panel>
            
        </div>
        <h2>Fallowing courses are currently available for registration </h2><br />
         <asp:Label ID="lblError" runat="server" CssClass =" error" Visible ="False"></asp:Label>
      
        <asp:CheckBoxList ID="CheckBoxList" runat="server">
        </asp:CheckBoxList>
       
        
        <asp:Button ID="btnSubmit" runat="server" CssClass="button" Text="Submit" OnClick =" btnSubmit_Click" />
          
    </form>
        <div id="studentInfo" runat="server">
        <p>Thank you <asp:Label ID="lblStudentInfoName" CssClass="emphsis" runat="server"></asp:Label>, for using our online registration system.</p>
        <p>You have been registered as a <asp:Label ID="lblStudentInfoType" CssClass="distinct" runat="server"></asp:Label> for the following courses</p>
        <asp:Table ID="tblCourses" CssClass="table" runat="server"></asp:Table>
    </div>
        
    
</body>
</html>
