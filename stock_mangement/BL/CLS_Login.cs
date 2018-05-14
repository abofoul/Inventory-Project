using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace stock_mangement.BL
{
    class CLS_Login
    {
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

        public DataTable Login(string id, string pwd)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = pwd;

            DAL.opendb();
            DataTable dt = new DataTable();
            dt = DAL.select("SP_Login", param);
            DAL.closedb();
            return dt;
        }

        public void Add_User(string uid, string pwd, string usertpye, string username)
        {
            DAL.opendb();
            
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@uid", SqlDbType.VarChar, 50);
            param[0].Value = uid;

            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = pwd;

            param[2] = new SqlParameter("@usertype", SqlDbType.VarChar, 50);
            param[2].Value = usertpye;

            param[3] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[3].Value = username;

            DAL.execmd("Add_User", param);
            DAL.opendb();
        }

       

        public DataTable Search_User(string criterion)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[0].Value = criterion;

            DataTable dt = new DataTable();
            DAL.opendb();            
            dt = DAL.select("Search_User", param);
            DAL.closedb();
            return dt;
        }
    }
}
