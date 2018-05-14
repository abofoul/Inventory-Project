using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace stock_mangement.BL
{
    class CLS_Customers
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public void Add_Customer(string fName, string lName, string phone,string E_Mail, byte[] cImage,string checker)
        {
            dal.opendb();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@fName", SqlDbType.VarChar,50);
            param[0].Value = fName;

            param[1] = new SqlParameter("@lName", SqlDbType.VarChar, 50);
            param[1].Value = lName;

            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 15);
            param[2].Value = phone;

            param[3] = new SqlParameter("@E_Mail", SqlDbType.VarChar, 50);
            param[3].Value = E_Mail;

            param[4] = new SqlParameter("@cImage", SqlDbType.Image);
            param[4].Value = cImage;

            param[5] = new SqlParameter("@checker", SqlDbType.VarChar, 50);
            param[5].Value = checker;   

            dal.execmd("Add_Customer", param);
            dal.closedb();
        }
        public DataTable Get_All_Customers()
        {
            dal.opendb();
            DataTable dt = new DataTable();
            dt = dal.select("Get_All_Customers", null);
            dal.closedb();
            return dt;
        }
        public void Update_Customer(string fName, string lName, string phone, string E_Mail, byte[] cImage, string checker,int id)
        {
            dal.opendb();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@fName", SqlDbType.VarChar, 50);
            param[0].Value = fName;

            param[1] = new SqlParameter("@lName", SqlDbType.VarChar, 50);
            param[1].Value = lName;

            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 15);
            param[2].Value = phone;

            param[3] = new SqlParameter("@E_Mail", SqlDbType.VarChar, 50);
            param[3].Value = E_Mail;

            param[4] = new SqlParameter("@cImage", SqlDbType.Image);
            param[4].Value = cImage;

            param[5] = new SqlParameter("@checker", SqlDbType.VarChar, 50);
            param[5].Value = checker;

            param[6] = new SqlParameter("@id", SqlDbType.Int);
            param[6].Value = id;

            dal.execmd("Update_Customer", param);
            dal.closedb();
        }
        public void Delete_Customer(int id)
        {
            dal.opendb();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;            

            dal.execmd("Delete_Customer", param);
            dal.closedb();
        }
        public DataTable Search_Customer(string search)
        {
            dal.opendb();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            DataTable dt = dal.select("Search_Customer", param);
            dal.closedb();
            return dt;
        }        
    }
}
