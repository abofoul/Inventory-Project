using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace stock_mangement.BL
{
    class CLS_Products
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

        public DataTable Get_Categories()
        {
            dal.opendb();
            DataTable dt = new DataTable();
            dt = dal.select("Get_Categories", null);
            dal.closedb();
            return dt;
        }
        public DataTable VerifyID(int id)
        {
            dal.opendb();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dt = dal.select("VerifyID", param);
            dal.closedb();
            return dt;
        }
        public DataTable Get_Products()
        {
            dal.opendb();
            DataTable dt = new DataTable();
            dt = dal.select("Get_Products", null);
            dal.closedb();
            return dt;
        }
        public DataTable Sarch_Product(string id)
        {
            dal.opendb();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar,50);
            param[0].Value = id;
            dt = dal.select("Search_Product", param);
            dal.closedb();
            return dt;
        }

        public void Add_Product(int pID, string pName, string price, int Stock, byte[] pImage, int cat_id, string checker)
        {
            dal.opendb();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@pID", SqlDbType.Int);
            param[0].Value = pID;

            param[1] = new SqlParameter("@pName", SqlDbType.VarChar,50);
            param[1].Value = pName;

            param[2] = new SqlParameter("@price", SqlDbType.VarChar,50);
            param[2].Value = price;

            param[3] = new SqlParameter("@Stock", SqlDbType.Int);
            param[3].Value = Stock;

            param[4] = new SqlParameter("@pImage", SqlDbType.Image);
            param[4].Value = pImage;

            param[5] = new SqlParameter("@cat_id", SqlDbType.Int);
            param[5].Value = cat_id;

            param[6] = new SqlParameter("@checker", SqlDbType.VarChar, 50);
            param[6].Value = checker;


            dal.execmd("Add_Product", param);
            dal.closedb();
            

            

        }
        public void Delete_Product(int pid)
        {
            dal.opendb();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = pid;
            dal.execmd("Delete_Product", param);
            dal.closedb();
        }
        public DataTable Get_Image(int id)
        {
            dal.opendb();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@pid", SqlDbType.Int);
            param[0].Value = id;
            dt = dal.select("Get_Image", param);
            dal.closedb();
            return dt;
        }
        public void Update_Products(int pID, string pName, string price, int Stock, byte[] pImage, int cat_id,string checker)
        {
            dal.opendb();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@pID", SqlDbType.Int);
            param[0].Value = pID;

            param[1] = new SqlParameter("@pName", SqlDbType.VarChar, 50);
            param[1].Value = pName;

            param[2] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[2].Value = price;

            param[3] = new SqlParameter("@Stock", SqlDbType.Int);
            param[3].Value = Stock;

            param[4] = new SqlParameter("@pImage", SqlDbType.Image);
            param[4].Value = pImage;

            param[5] = new SqlParameter("@cat_id", SqlDbType.Int);
            param[5].Value = cat_id;

            param[6] = new SqlParameter("@checker", SqlDbType.VarChar, 50);
            param[6].Value = checker;

            dal.execmd("Update_Products", param);
            dal.closedb();
        }
        
    }
}
