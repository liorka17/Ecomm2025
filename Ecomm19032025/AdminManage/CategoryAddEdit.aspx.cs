using BLL; 
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecomm19032025.AdminManage
{
    public partial class CategoryAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Cid = Request["Cid"] + ""; // מקבל את מזהה הקטגוריה מהשורת כתובת אם יש
                Category c = null; // מגדיר משתנה שיחזיק את הקטגוריה

                if (!string.IsNullOrEmpty(Cid))
                {
                    c = Category.GetById(int.Parse(Cid));// מחפש את הקטגוריה לפי המזהה שלה
                }

                if (c != null)
                {
                    TxtPname.Text = c.Cname;//  שם הקטגוריה
                    DDLStatus.SelectedValue = c.Status + "";//  סטטוס הקטגוריה
                    HidCid.Value = c.Cid + "";//  קוד הקטגוריה
                    TxtParentCid.Text = c.ParentCid + "";//  קוד הקטגוריה העליונה
                    TxtCatDesc.Text = c.CatDesc; //  תיאור הקטגוריה
                }
                else
                {
                    HidCid.Value = "-1";//  קוד קטגוריה לא קיים
                }
            }
        }


        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Category c = new Category();// יוצר אובייקט חדש של קטגוריה

            c.Cid = int.Parse(HidCid.Value);//  קוד הקטגוריה
            c.Cname = TxtPname.Text;//  שם הקטגוריה
            c.ParentCid = int.Parse(TxtParentCid.Text);//  קוד הקטגוריה העליונה
            c.Status = int.Parse(DDLStatus.SelectedValue);//  סטטוס הקטגוריה
            c.CatDesc = TxtCatDesc.Text; //  תיאור הקטגוריה

            c.Save();//  שומר את הקטגוריה
            Response.Redirect("CategoryList.aspx");//  מפנה את המשתמש לרשימת הקטגוריות לאחר השמירה
        }

    }
}
