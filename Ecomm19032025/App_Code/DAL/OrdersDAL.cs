using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BLL;
using DATA;

namespace DAL
{
    public class OrdersDAL
    {

        public static Orders GetById(int OrderID)
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג דאטה בייס
            string sql = $"SELECT * FROM T_Orders Where OrderID={OrderID}";//שאילתא לשליפת הזמנה לפי קוד
            DataTable Dt = Db.Execute(sql);//שליפת נתונים מהמסד
            Orders Tmp = null;//יצירת אובייקט מסוג הזמנה

            if (Dt.Rows.Count > 0)
            {
                string orderDesc = ""; // משתנה זמני עבור תיאור ההזמנה
                if (Dt.Rows[0]["OrderDesc"] != DBNull.Value)
                    orderDesc = Dt.Rows[0]["OrderDesc"].ToString();

                Tmp = new Orders()//יצירת אובייקט מסוג הזמנה
                {
                    OrderId = int.Parse(Dt.Rows[0]["OrderId"] + " "),//קוד ההזמנה
                    Uid = int.Parse(Dt.Rows[0]["Uid"] + " "),//קוד משתמש
                    TotalPrice = Convert.ToSingle(Dt.Rows[0]["TotalPrice"]),//סכום כולל
                    TotalAmount = Convert.ToSingle(Dt.Rows[0]["TotalAmount"]),//כמות כוללת
                    Status = (string)Dt.Rows[0]["Status"],//סטטוס ההזמנה
                    OrderDesc = orderDesc // תיאור הזמנה
                };
                Db.Close();//סגירת החיבור לבסיס הנתונים
                return Tmp;//מחזירה את האובייקט
            }
            return new Orders();//מחזירה אובייקט ריק במקרה ולא נמצא
        }


        public static List<Orders> GetAll() // מחזירה את כל ההזמנות
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג דאטה בייס
            string sql = "SELECT * FROM T_Orders";//שאילתא לשליפת כל ההזמנות
            DataTable Dt = Db.Execute(sql);//שליפת נתונים מהמסד
            List<Orders> lst = new List<Orders>();//יצירת רשימה חדשה של הזמנות

            //  בלולאה אנו מבצעים המרות כדי להתאים את סוגי הנתונים

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                string orderDesc = "";
                if (Dt.Rows[i]["OrderDesc"] != DBNull.Value)
                    orderDesc = Dt.Rows[i]["OrderDesc"].ToString();

                Orders Tmp = new Orders()
                {
                    OrderId = Convert.ToInt32(Dt.Rows[i]["OrderId"]),
                    Uid = Convert.ToInt32(Dt.Rows[i]["Uid"]),
                    TotalPrice = Convert.ToSingle(Dt.Rows[i]["TotalPrice"]),
                    TotalAmount = Convert.ToSingle(Dt.Rows[i]["TotalAmount"]),
                    Status = Dt.Rows[i]["Status"].ToString(),
                    OrderDesc = orderDesc
                };
                lst.Add(Tmp);
            }


            Db.Close(); // סגירת החיבור לבסיס הנתונים
            return lst;
        }


        public static int Save(Orders Tmp)
        {
            DbContext Db = new DbContext();
            string sql;

            if (Tmp.OrderId == -1)
            {
                sql = $"INSERT INTO T_Orders(Uid, TotalPrice, TotalAmount, Status, OrderDesc) " +
                      $"VALUES('{Tmp.Uid}', '{Tmp.TotalPrice}', '{Tmp.TotalAmount}', N'{Tmp.Status}', N'{Tmp.OrderDesc}')";
            }
            else
            {
                sql = $"UPDATE T_Orders SET " +
                      $"Uid = '{Tmp.Uid}', " +
                      $"TotalPrice = '{Tmp.TotalPrice}', " +
                      $"TotalAmount = '{Tmp.TotalAmount}', " +
                      $"Status = N'{Tmp.Status}', " +
                      $"OrderDesc = N'{Tmp.OrderDesc}' " +
                      $"WHERE OrderId = {Tmp.OrderId}";
            }

            int i = Db.ExecuteNonQuery(sql);

            if (Tmp.OrderId == -1)
            {
                sql = $"SELECT MAX(OrderId) FROM T_Orders WHERE Uid = {Tmp.Uid}";
                Tmp.OrderId = (int)Db.ExecuteScalar(sql);
            }
            Db.Close();
            return i;
        }


        public static int DeleteById(int OrderId)//מוחקת את ההזמנה לפי קוד
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג דאטה בייס
            string sql = $"DELETE FROM T_Orders Where OrderId={OrderId}";//שאילתא למחיקת הזמנה לפי קוד
            int i = Db.ExecuteNonQuery(sql);//מחזירה מספר שורות שהוסרו מהמסד נתונים
            Db.Close();//סגירת החיבור לבסיס הנתונים
            return i;//מחזירה את מספר השורות שהוסרו מהמסד נתונים
        }
    }
}