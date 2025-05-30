using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectPrac1
{
    class Program
    {

      
        static void Main(string[] args)
        {
          string constr = "Server=WKSPUN05GTR1010;Database=SQL_Customers;Trusted_Connection=true";
              SqlConnection conn = new SqlConnection(constr);
             conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Customers",conn);
            // SqlDataReader reader = cmd.ExecuteReader();//for fetching data from database //we use SqlDataReader for Connected data

            // while(reader.Read()) {
            //   Console.WriteLine(reader["Cust_Name"] + " " + reader["Cust_Id"]);
            //}
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);//SqlDataAdapter is used for disconnected ,here DataSet is Used that will Directly fetch the data from database
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr["Cust_Name"] + " " + dr["Cust_Id"]);
            }
                ///////////////////////////for maniplution/////////////////////////////////

                //  SqlConnection conn1  = new SqlConnection(constr);
                //conn.Open();
                // SqlCommand cmd1 = new SqlCommand
                //   ("Insert Into Customers(Cust_Id,Cust_Name)" +
                //  "Values(6,'Peter')", conn1);
                //cmd.ExecuteNonQuery();// for manipulation

                // Class1 class1 = new Class1();
                // Class2 class2 = new Class2();

                // class2.swim();
            }
    }
}
