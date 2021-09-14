using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DemoLib;
namespace FirstWebApplicationContd
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        Person p = new Person();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            
            p.Fname = txtfname.Text;
            p.Lname = txtlname.Text;
            txtbdate.Text = Calendar1.SelectedDate.ToLongDateString();
            p.BirthDate = Convert.ToDateTime(Calendar1.SelectedDate.ToLongDateString());
        }

        protected void btnShowAge_Click(object sender, EventArgs e)
        {
            p.CalculateAge(Convert.ToDateTime(txtbdate.Text));
            txtage.Text = p.Age.ToString();
        }
    }
}