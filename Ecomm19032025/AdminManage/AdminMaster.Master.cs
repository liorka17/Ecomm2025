﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecomm19032025.AdminManage
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)//בודק אם המשתמש לא מחובר
            {
                Response.Redirect("/Error.aspx");//מעביר את המשתמש לדף הכניסה
            }
        }
    }
}