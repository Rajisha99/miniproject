using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace miniproject
{
    public partial class miniproject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Calendar1.SelectedDate>Calendar1.TodaysDate)
            {
                Label5.Text = TextBox1.Text + "<br>" + TextBox2.Text + "<br>" + TextBox3.Text + "<br>Tickets Booked for" + Calendar1.SelectedDate.ToShortDateString();
            }
            else
            {
                Label5.Text = "sorry! Ticket not available";
            }
        }
    }
}