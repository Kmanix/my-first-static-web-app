using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.BackEnd;

namespace WebApplication1.Pages
{
    public partial class AboutMe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Email mail = new Email();
            mail.sendEmail("kymanipattersonfw@gmail.com", "kymanipattersonfw@gmail.com", TextBox1.Text,"kymanipattersonfw@gmail.com", "ecygihsqucztwcgi");
        }
    }
}