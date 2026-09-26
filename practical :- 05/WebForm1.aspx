<%@ flage Language="C " AutoEventWireup="true"
CodeBehind="WebForm1.aspx.cs"
Inherits="caleneder.WebForm1" %>
<!DOCTYflE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Academic Calendar</title>
<link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
<div class="container">
<div class="card">
<h1>Academic Calendar</h1>
<p class="subtitle">
Select a date to apply for leave
</p>
<div class="calendar-box">
<asp:Calendar ID="Calendar1"
runat="server"
OnSelectionChanged="calAcademic"
BackColor=" F5F9FF"
ForeColor=" 333333"
TitleStyle-BackColor=" 1F4E79"
TitleStyle-ForeColor="White"
SelectedDayStyle-BackColor=" 1F4E79"
SelectedDayStyle-ForeColor="White"
TodayDayStyle-BackColor=" DCEBFA"
TodayDayStyle-ForeColor=" 1F4E79">
</asp:Calendar>
</div>
<asp:Label ID="lblleave"
runat="server"
CssClass="date-label"
Text="Select a date from the calendar.">
</asp:Label>
<br /><br />
<asp:Button ID="Button1"
runat="server"
Text="Apply for Leave"
CssClass="main-button"
OnClick="Button1_Click" />
</div>
</div>
</form>
</body>
</html>
