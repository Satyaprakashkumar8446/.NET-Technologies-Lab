using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Practical__04
{
public partial class WebForm1 : System.Web.UI.Page
{
protected void Page_Load(object sender, EventArgs e)
{
}
protected void Button1_Click(object sender, EventArgs e)
{
// Clear TextBoxes
TextBox1.Text = "";
TextBox2.Text = "";
TextBox3.Text = "";
TextBox4.Text = "";
// Clear Department RadioButtons
RadioButton1.Checked = false;
RadioButton2.Checked = false;
RadioButton3.Checked = false;
// Reset Event DropDownList
DropDownList1.SelectedIndex = 0;
// Clear Gender RadioButtons
RadioButton4.Checked = false;
RadioButton5.Checked = false;
// Clear Skills CheckBoxes
CheckBox1.Checked = false;
CheckBox2.Checked = false;
CheckBox3.Checked = false;
// Clear Terms and Conditions
CheckBox4.Checked = false;
  }
 }
}

