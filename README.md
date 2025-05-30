💻# ADO.NET.github.io
🧠C#learning with Database Using Sql Server Management Studio(Mysql,Transact Sql)
Connect c sharp with DATABASE

To connect C# WITH DATABASE WE USE ADO.NET

Basic #ADO.net :-
ADO STANDS FOR - [MICROSOFT ACTIVEX DATA OBJECTS] - That we use to communicate with different data sources.
It establishes a connection between the .NET Application and different data sources.
Data Sources:-[Like Sql SERVER , ORACLE , MYSQL , XML]

🔗 Connection Classes(Predefined Classes in ADO.NET)

Used to establish a connection to a data source.

SqlConnection – Connects to SQL Server.
OleDbConnection – Connects to OLE DB data sources.
OdbcConnection – Connects to ODBC data sources.
OracleConnection – Connects to Oracle databases (via System.Data.OracleClient or third-party providers).

🚀Providers:-

#System.Data.SqlClient------ Used for SQL connection
#System.Data.OleDb ------ Used for Ms ACCESS CONNECTION
#System.Data.Odbc ------ Can connect Post-gre 
#Oracle.Data.AccessClient
#System.Data.OracleClient

Components of ADO.NET

#Connection,
#Command,
#DataReader,
#DataAdapter,
#DataSet,
#DataView

Taking Example of Sql and understanding the concepts:-

Like if we are Using for Sql we can use these components like - SqlConnection,SqlCommand,SqlDataReader,SqlDataAdapter[DataSet,DataView]

1.)🔗SqlConnection - 
    Purpose[Establishes a Connection to a Sql Server Database]
    Use - It is generally used to interact with the Sql Database here which is mandatory.

  ✅example- 
  first we need to add a connection string like:
  
  string constr = "Server=HereMentionServerID;Database=MentionDatabaseHere;Trust_Connection=true";
  SqlConnecton conn = new SqlConnection (mention your connection string here like above its constr);
  
  conn.Open(); //opens the connection
  //Write Db operations here
  conn.Close(); //close the connection

  Here,
  ✅ conn.Open()
  
   Purpose: Opens a connection to the database.
   Use: Before executing any SQL command (SELECT, INSERT, etc.).
   Note: If the connection is already open, calling Open() again will throw an exception.

   ❌ conn.Close()
   
   Purpose: Closes the connection to free up resources.
   Use: After you're done with database operations.
   Best Practice: Always close the connection, even if an error occurs (use try-finally or using).

   Using statement ensures the connection to automatically close and dispose even if an error occurs,
   syntax --
  🧪 using (SqlConnection conn = new SqlConnection("your_connection_string"))

  
2.)🧾SqlCommand -

   Purpose: Executes SQL queries or stored procedures.
   Use: CRUD Operations or stored procedures.
   
  🧪 Few Examples :
   
   SqlCommand cmd = new SqlCommand("Insert Into Customers(Cust_Id,Cust_Name)" + "Values(6,'Peter')", conn);

  🧪 One more Examples :
  
   SqlCommand cmd = new SqlCommand("Select * from Customers ",conn);

 3.)📖 SqlDataReader -
   
   Purpose: Reads data from the database in a fast , forward-only , read-only manner. 

   Syntax:

   SqlDataReader reader = cmd.ExecuteReader();//for fetching data from database //we use SqlDataReader for Connected data
   while(reader.Read()) {
   Console.WriteLine(reader["Cust_Name"] + " " + reader["Cust_Id"]);
   }

 📖 ExecuteReader() -method is used with a SqlCommand to execute a SQL SELECT QUERY AND RETRIEVE the results using a 
 [SqlDataReader]

📖 ExecuteNonQuery -
  
  Purpose: It is used with a SqlCommand to execute SQL statements that do not return any data(rows).

4.)🔄 SqlDataAdapter -

  Purpose : Acts as a bridge between the database and a Dataset or DataTable.
  Use: Dataset and Optionally update the database later.

✅ Example:

   SqlDataAdapter adapter = new SqlDataAdapter(cmd);//SqlDataAdapter is used for disconnected ,here DataSet is Used that will Directly fetch the data from database
   DataSet ds = new DataSet();
   adapter.Fill(ds);
   conn.Close();

📦 adapter.Fill(ds) in ADO.NET
The Fill() method is used with a DataAdapter (like SqlDataAdapter) to populate a DataSet or DataTable with data from a database.
   



     
   
   

   
     
  
    

