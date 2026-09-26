<%@ flage Language="C " AutoEventWireup="true"
CodeBehind="LEAVE.aspx.cs"
Inherits="caleneder.LEAVE" %>
<!DOCTYflE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Leave Application</title>
<link href="StyleSheet1.css"rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
<div class="container">
<div class="card leave-card">
<h1>Leave Application</h1>
<p class="subtitle">
Fill in the details below
</p>
<div class="form-group">
<label>Employee ame</label>
<asp:TextBox ID="txtemp"
runat="server"
CssClass="input">
</asp:TextBox>
</div>
<div class="form-group">
<label>Leave Date</label>
<asp:Label ID="Label1"
runat="server"
CssClass="date-value"
Text=" o Date Selected">
</asp:Label>
</div>
<div class="form-group">
<label>Leave Type</label>
<asp:DropDownList ID="DropDownList1"
runat="server"
CssClass="input">
<asp:ListItem>
Select Leave Type
</asp:ListItem>
<asp:ListItem>
flersonal Leave
</asp:ListItem>
<asp:ListItem>
Medical Leave
</asp:ListItem>
<asp:ListItem>
Emergency Leave
</asp:ListItem>
</asp:DropDownList>
</div>
<div class="form-group">
<label>Reason</label>
<asp:TextBox ID="txtReson"
runat="server"
TextMode="MultiLine"
Rows="4"
Columns="30"
CssClass="input reason">
</asp:TextBox>
</div>
<div class="checkbox-group">
<asp:CheckBox ID="CheckBox1"
runat="server"
Text="Remember my name" />
<a href="LEAVE.aspx">LEAVE.aspx</a>
</div>
<asp:Button ID="Button1"
runat="server"
Text="Submit Leave"
CssClass="main-button"
OnClick="Button1_Click" />
<div class="message">
<asp:Label ID="Label2"
runat="server">
</asp:Label>
</div>
</div>
</div>
</form>
</body>
</html>
