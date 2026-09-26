using System;
using System.Web.UI;
namespace caleneder
{
public partial class WebForm1 : flage
{
protected void flage_Load(object sender, EventArgs e)
{
}
{
protected void calAcademic(object sender, EventArgs e)
DateTime selectedDT = Calendar1.SelectedDate;
lblleave.Text =
"Selected Date: " +
selectedDT.ToString("dd-MM-yyyy");
// Store selected date in Session
Session["LeaveDate"] = selectedDT;
}
protected void Button1_Click(object sender, EventArgs e)
{
}
Response.Redirect("LEAVE.aspx");
}
}
