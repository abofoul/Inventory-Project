using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace stock_mangement.DAL
{
    class DataAccessLayer
    {
        SqlConnection con;

        //intializing sql connection 
        public DataAccessLayer()
        {
            con = new SqlConnection(@"server=OMAR-PC;Database=Sales_Mangement; Integrated Security=true");
        }
        //open the connection
        public void opendb()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        //close the connection
        public void closedb()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
        // read data from database 
        public DataTable select(string stored_procedure, SqlParameter[] param)
        {
            opendb();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;

            if (param != null)
                cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closedb();
            return dt;
            
        }
        //Method for adding,deletingand updating data on database
        public void execmd(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            cmd.ExecuteNonQuery();
        }

    }
}
