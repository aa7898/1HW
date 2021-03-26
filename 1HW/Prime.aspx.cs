using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int number = 32;
            int a = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    a = a + 1;
                }
                if (a > 2) break;
            }

            if (a == 2) { 
                Response.Write("YES");
            }
            else
                Response.Write("NO");
        }
    }
}