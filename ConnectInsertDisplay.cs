using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectPrac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string constr = "Server=WKSPUN05GTR1010;Database=SQL_Customers;Trusted_Connection=true";
              // SqlConnection conn = new SqlConnection(constr);
             //conn.Open();
            //SqlCommand cmd = new SqlCommand("Select * from Customers",conn);
             // SqlDataReader reader = cmd.ExecuteReader();//for fetching data from database
            // while(reader.Read()) {
            //    Console.WriteLine(reader["Cust_Name"] + " " + reader["Cust_Id"]);
            //  }


            SqlConnection conn  = new SqlConnection(constr);
           conn.Open();
            SqlCommand cmd = new SqlCommand
                ("Insert Into Customers(Cust_Id,Cust_Name)" +
                "Values(6,'Peter')", conn);
           cmd.ExecuteNonQuery();// for manipulation
        }
    }
}
