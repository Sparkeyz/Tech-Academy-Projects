using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace My_First_Challenge
{
    public partial class Challenge_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void fortuneButton_Click(object sender, EventArgs e)
        {
            string age = yearsOld.Text;
            string money = moneyInPocket.Text;


            string result = "At " + age + " years old, I would expect you to have more than " + money + " in your pocket.";
            Label1.Text = result;
        }
    }
}