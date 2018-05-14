using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace stock_mangement.BL
{
    class CLS_Orders
    {
        public DataTable Get_Last_Id()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.opendb();
            dt = dal.select("Get_Last_Id", null);
            dal.closedb();
            return dt;
        }
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public void Add_Order(DateTime Date, string Description, string Salesman, int cID)
        {
            dal.opendb();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[0].Value = Date;

            param[1] = new SqlParameter("@Description", SqlDbType.VarChar, 50);
            param[1].Value = Description;

            param[2] = new SqlParameter("@Salesman", SqlDbType.VarChar, 50);
            param[2].Value = Salesman;

            param[3] = new SqlParameter("@cID", SqlDbType.Int);
            param[3].Value = cID;
            
            dal.execmd("Add_Order", param);
            dal.closedb();
        }

        public void Add_oDetails(int pID,int oID,string price,double discount,string net,string final,int quantity)
        {
            dal.opendb();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@pID", SqlDbType.Int);
            param[0].Value = pID;

            param[1] = new SqlParameter("@oID", SqlDbType.Int);
            param[1].Value = oID;

            param[2] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[2].Value = price;

            param[3] = new SqlParameter("@Discount", SqlDbType.Float);
            param[3].Value = discount;

            param[4] = new SqlParameter("@Net_Price", SqlDbType.VarChar, 50);
            param[4].Value = net;

            param[5] = new SqlParameter("@Final_Price", SqlDbType.VarChar, 50);
            param[5].Value = final;

            param[6] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[6].Value = quantity;

            dal.execmd("Add_Odetails", param);
            dal.closedb();
        }

        public DataTable Verify_Quantity(int pID, int Quantity)
        {
            dal.opendb();
            SqlParameter[] param = new SqlParameter[2];
            DataTable dt = new DataTable();

            param[0] = new SqlParameter("@pID", SqlDbType.Int);
            param[0].Value = pID;

            param[1] = new SqlParameter("Quantity", SqlDbType.Int);
            param[1].Value = Quantity;

            dt = dal.select("Verify_Quantity", param);
            return dt;
        }

        public DataTable Get_Last_Id_For_Print()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.opendb();
            dt = dal.select("Get_Last_Id_For_Print", null);
            dal.closedb();
            return dt;
        }

        public DataTable Get_Order_Details(int oID)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.opendb();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("oID", SqlDbType.Int);
            param[0].Value = oID;
            dt = dal.select("Get_Order_Details", param);
            dal.closedb();
            return dt;
        }

        public DataTable Search_Orders(string criterion)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.opendb();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar,50);
            param[0].Value = criterion;
            dt = dal.select("Search_Orders", param);
            dal.closedb();
            return dt;
        }
    }
}
