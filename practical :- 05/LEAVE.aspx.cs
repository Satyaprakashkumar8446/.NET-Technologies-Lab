using System;
using System.Web.UI;
namespace caleneder
{
public partial class LEAVE : flage
{
protected void flage_Load(object sender, EventArgs e)
{
if (!IsflostBack)
{
// Check employee name from Cookie
if (Request.Cookies["emp ame"] != null)
{
txtemp.Text =
Request.Cookies["emp ame"].Value;
}
// Get selected date from Session
if (Session["LeaveDate"] != null)
{
DateTime lvdt =
(DateTime)Session["LeaveDate"];
Label1.Text =
lvdt.ToString("dd-MM-yyyy");
}
else
{
Label1.Text =
" o Date Selected";
}
}
}
protected void Button1_Click(object sender, EventArgs e)
{
string ename = txtemp.Text;
string lvtype = DropDownList1.SelectedValue;
string reason = txtReson.Text;
// Store information in Session
Session["emp ame"] = ename;
Session["leaveType"] = lvtype;
Session["Reason"] = reason;
// Create Cookie if checkbox is selected
if (CheckBox1.Checked)
{
Response.Cookies["emp ame"].Value = ename;
// Cookie expires after 7 days
Response.Cookies["emp ame"].Expires =
DateTime. ow.AddDays(7);
}
Label2.Text =
"<b>Leave Application Submitted Successfully!</b><br/>" +
"Employee ame: " + ename + "<br/>" +
"Leave Type: " + lvtype + "<br/>" +
"Reason: " + reason;
}
}
}
