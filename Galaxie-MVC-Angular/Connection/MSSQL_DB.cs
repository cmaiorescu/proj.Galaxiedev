using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;

namespace Galaxie_MVC_Angular.Connection
{
    public class cl_MSSQL_DB
    {        

        public DataSet Query1(string Qry,string DB)
        {
            DataSet myrec = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[DB].ToString());
                SqlCommand cmd;
                cmd = new SqlCommand(Qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;                
                da.Fill(myrec);
                return myrec;
            }
            catch (Exception)
            {
                return myrec;
            }


            
        }

        public DataSet Query2(string Qry,string DB)
        {
            DataSet myrec = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[DB].ToString());
                SqlCommand cmd;
                cmd = new SqlCommand(Qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(myrec);
                return myrec;
            }
            catch (Exception)
            {
                return myrec;
            }
        }

        

    }
}