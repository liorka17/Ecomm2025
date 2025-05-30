using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecomm19032025
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
           string Email = TxtEmail.Text;//לוקח את האימייל מהטקסט בוקס ומסיר רווחים
           string Pass = TxtPass.Text;//לוקח את הסיסמא מהטקסט בוקס ומסיר רווחים
            Users us = Users.CheckLogin(Email, Pass);//בודק אם המשתמש קיים עם האימייל והסיסמא שנכנסו
            if (us != null)
            {
                Session["Login"]= us;//שומר את המשתמש שנכנס למשתנה סשן בשם Login
                Response.Redirect("/AdminManage");//מעביר את המשתמש לדף הבית
            }
            else
            {
                
            }
        }
    }
}