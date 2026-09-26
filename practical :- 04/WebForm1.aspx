<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs"
Inherits="Practical__04.WebForm1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Online Event Registration</title>
<link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
<form id="form1" runat="server">
<div class="container">
<h2>Online Event Registration</h2>
<table class="formTable">
<tr>
<td>
<asp:Label ID="Label1" runat="server" Text="Full Name"></asp:Label>
</td>
<td>
<asp:TextBox ID="TextBox1" runat="server"
CssClass="textbox"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
</td>
<td>
<asp:TextBox ID="TextBox2" runat="server"
CssClass="textbox"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="Label3" runat="server" Text="Contact Number"></asp:Label>
</td>
<td>
<asp:TextBox ID="TextBox3" runat="server"
CssClass="textbox"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="Label4" runat="server" Text="College Name"></asp:Label>
</td>
<td>
<asp:TextBox ID="TextBox4" runat="server"
CssClass="textbox"></asp:TextBox>
</td>
</tr>
<tr>
<td valign="top">
<asp:Label ID="Label5" runat="server" Text="Department"></asp:Label>
</td>
<td>
<asp:RadioButton ID="RadioButton1" runat="server" GroupName="Department"
Text="CSE" /><br />
<asp:RadioButton ID="RadioButton2" runat="server" GroupName="Department"
Text="ECE" /><br />
<asp:RadioButton ID="RadioButton3" runat="server" GroupName="Department"
Text="EEE" />
</td>
</tr>
<tr>
<td>
<asp:Label ID="Label6" runat="server" Text="Event Name"></asp:Label>
</td>
<td>
<asp:DropDownList ID="DropDownList1" runat="server" CssClass="textbox">
<asp:ListItem>--Select Event--</asp:ListItem>
<asp:ListItem>Hackathon</asp:ListItem>
<asp:ListItem>Workshop</asp:ListItem>
<asp:ListItem>Seminar</asp:ListItem>
<asp:ListItem>Conference</asp:ListItem>
</asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
</td>
<td>
<asp:RadioButton ID="RadioButton4" runat="server" GroupName="gender"
Text="Male" />
&nbsp;&nbsp;
<asp:RadioButton ID="RadioButton5" runat="server" GroupName="gender"
Text="Female" />
</td>
</tr>
<tr>
<td valign="top">
<asp:Label ID="Label8" runat="server" Text="Skills"></asp:Label>
</td>
<td>
<asp:CheckBox ID="CheckBox1" runat="server" Text="Programming" />
<br />
<asp:CheckBox ID="CheckBox2" runat="server" Text="Design" />
<br />
<asp:CheckBox ID="CheckBox3" runat="server" Text="Management" />
</td>
</tr>
<tr>
<td valign="top">
<asp:Label ID="Label9" runat="server" Text="Address"></asp:Label>
</td>
<td>
<textarea id="TextArea1" runat="server" class="textbox"
rows="3"></textarea>
</td>
</tr>
<tr>
<td valign="top">
<asp:Label ID="Label10" runat="server" Text="Terms &
Conditions"></asp:Label>
</td>
<td>
<asp:CheckBox ID="CheckBox4" runat="server"
Text="I agree to the Terms and Conditions" />
</td>
</tr>
<tr>
<td></td>
<td>
<asp:Button ID="Button1"
runat="server"
Text="Submit"
CssClass="btn"
OnClick="Button1_Click" />
</td>
</tr>
</table>
</div>
</form>
</body>
</html>
