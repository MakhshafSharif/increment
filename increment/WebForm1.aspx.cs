using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace increment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                ViewState["Count"] = 0;
            }
        }
        protected void IncrementCounter(object sender, EventArgs e)
        {
            int counter;
            if (ViewState["Count"] != null)
            {
                counter = Convert.ToInt32(ViewState["Count"]);
            }
            else
            {
                counter = 0;
            }
            counter = counter + 1;
            ViewState["Count"] = counter;
            this.label1.Text = counter.ToString();
        }
    }
}