using AutofacDependencyInjectionInWebforms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutofacDependencyInjectionInWebforms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public ISomeDataService MyDataService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (string anItemString in MyDataService.GetSomeData())
            {
                Response.Write(anItemString);
                Response.Write("<br/>");
            }
        }
    }
}