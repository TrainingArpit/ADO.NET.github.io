💻# ADO.NET.github.io
🧠C#learning with Database Using Sql Server Management Studio(Mysql,Transact Sql)
Connect c sharp with DATABASE

To connect C# WITH DATABASE WE USE ADO.NET

Basic #ADO.net :-
ADO STANDS FOR - [MICROSOFT ACTIVEX DATA OBJECTS] - That we use to communicate with different data sources.
It establishes a connection between the .NET Application and different data sources.
Data Sources:-[Like Sql SERVER , ORACLE , MYSQL , XML]

🔹 Connected vs Disconnected :

Connected : Maintains a constant connection to the database . 
Components - [SqlConnection , SqlCommand , SqlDataReader]

Disconnected : Data is retrieved and stored in memory , connection is closed.
Components - [SqlDataAdapter , DataSet, DataTable]


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
    
   Features -
    Manages opening and closing of database connections.
    
Supports :-
    Connection pooling[A performance optimization technique that allows applications to reuse existing database connections instead of creating a new one every time a connection required.]

This reduces the overhead of repeatedly opening and closing connections.
    
When the application closes the connection using .Close() or .Dispose(), the connection is returned to the pool instead of being physically closed.

Connection pooling is enabled by default in ADO.NET for most providers like SQL Server.

Pooling=true: Enables connection pooling.

Min Pool Size: Minimum number of connections maintained in the pool.

Max Pool Size: Maximum number of connections allowed in the pool.

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

  Methods :

  Open() - Opens the database connection.
  Close() - Closes the connection.
  Dispose() - Release resources.
  BeginTransaction() - Starts a transaction.
  ChangeDatabase() - Switches to a different database.

2.)🧾SqlCommand -

   Purpose: Executes SQL queries or stored procedures.
   Use: CRUD Operations or stored procedures.

   ⭐ Key Features:
   
   Executes SELECT, INSERT, UPDATE, DELETE.
   Supports parameterized queries.
   Can execute scalar values, non-queries, or data readers.

Some Methods :
   ExecuteReader() - Returns a SqlDataReader for reading rows. [SELECT QUERY]
   ExecuteNonQuery() - Execute commands that don't return rows. [INSERT/UPDATE/DELETE]
   ExecuteScalar() - Returns a single value (first column of first row) [SINGLE VALUE]
   ExecuteXmlReader() - Return results as XML. [XML RESULT]
   Prepare() - Prepares the command for repeated Execution 
   Cancel() - Cancel command execution
   CreateParameters() - Creates a new parameter object.
   
  🧪 Few Examples :
   
   SqlCommand cmd = new SqlCommand("Insert Into Customers(Cust_Id,Cust_Name)" + "Values(6,'Peter')", conn);

  🧪 One more Examples :
  
   SqlCommand cmd = new SqlCommand("Select * from Customers ",conn);

 3.)📖 SqlDataReader -
   
   Purpose: Reads data from the database in a fast , forward-only , read-only manner. 

   ⭐ Key Features:
     High performance for reading large data sets.
     Connected architecture (requires open connection).
     Lightweight and memory-efficient.

 🔧 Some Key Methods:

   Read() - Moves to the new row.
   Close() - Closes the reader.
   GetValue(i) - Gets the value at index i.
   GetString(i) - Gets a string value from column i.
   GetInt32(i) - Gets an integer value from column i.
   IsDBNull(i) - Checks if the column value is null.
   NextResult() - Moves to the next result set.
   GetSchemaTable() - Returns metadata about the columns.

   Syntax:

   SqlDataReader reader = cmd.ExecuteReader();//for fetching data from database //we use SqlDataReader for Connected data
   while(reader.Read()) {
   Console.WriteLine(reader["Cust_Name"] + " " + reader["Cust_Id"]);
   }

   📖 ExecuteReader() -
   Purpose : method is used with a SqlCommand to execute a SQL SELECT QUERY AND RETRIEVE the results using a 
 [SqlDataReader]

  📖 ExecuteNonQuery -
  
  Purpose : It is used with a SqlCommand to execute SQL statements that do not return any data(rows).

4.)🔄 SqlDataAdapter -

  Purpose : Acts as a bridge between the database and a Dataset or DataTable.
  Use : Dataset and Optionally update the database later.

  ✅ Features:
   Supports disconnected data access.
   Automatically generates SQL for updates (with SqlCommandBuilder).
   Can fill and update in-memory data.

✅ Example:

   SqlDataAdapter adapter = new SqlDataAdapter(cmd);//SqlDataAdapter is used for disconnected ,here DataSet is Used that will Directly fetch the data from database
   DataSet ds = new DataSet();
   adapter.Fill(ds);
   conn.Close();

📦 adapter.Fill(ds) in ADO.NET
    
    
   The Fill() method is used with a DataAdapter (like SqlDataAdapter) to populate a DataSet or DataTable with data from a database.
   
   Syntax : adapter.Fill(ds);

   Fill() - Loads into a DataSet or DataTable.
   Update() - Pushes changes from memory to the database.
   FillSchema() - Adds schema into to the DataTable.
   GetFillParameters() - Returns parameters used by the SelectCommand.

 5.)📦DataSet - (REPLICA OF THE DATABASE)

  ✅ Purpose:
  
   Represents an in-memory database — a collection of DataTable objects.

  ✅ Features:
  
   Can hold multiple related tables.
    Supports relations between tables.
      Disconnected from the database (ideal for offline work).
   
   In-Memory representation of data (can hold multiple tables)

   DataSet ds = new DataSet();
   adapter.Fill(ds);
   conn.Close();
   foreach (DataRow dr in ds.Tables[0].Rows)
   {
     Console.WriteLine(dr["Cust_Name"] + " " + dr["Cust_Id"]);
   }
   
   ✅ Commonly Used DataSet Methods

   AcceptChanges()	- Commits all changes made to the DataSet since it was loaded or last called.
    RejectChanges()	- Rolls back all changes made since the last AcceptChanges().
    Clear() -	Removes all rows from all tables in the DataSet.
    Clone() -	Copies the structure (schema) of the DataSet, but not the data.
    Copy()	- Copies both the structure and data of the DataSet.
    GetChanges() - Returns a copy of the DataSet with only the changes (added, modified, deleted rows).
    HasChanges() - Checks if there are any changes in the DataSet.
    Merge(DataSet) - Merges another DataSet into the current one.
    ReadXml(string) - Reads XML data into the DataSet.
    WriteXml(string) - Writes the DataSet contents to an XML file.
    ReadXmlSchema(string) - Reads the XML schema into the DataSet.
    WriteXmlSchema(string) - Writes the schema of the DataSet to an XML file.
    GetXml() - Returns the XML representation of the data.
    GetXmlSchema() - Returns the XML schema as a string.
    AcceptChangesDuringFill - (Property) Indicates whether AcceptChanges() is called during Fill().
    EnforceConstraints	- (Property) Enables or disables constraint enforcement.

6.)🔍DataView :

  A DataView is a powerful component in ADO.NET

✅ Purpose:
    Provides a custom view of a DataTable (e.g., filtered or sorted).

✅ Features:
   Can filter rows using RowFilter.eg[
view.RowFilter = "Name = 'Alice'";
]
   Can sort rows using Sort.[view.Sort = "Id DESC";]
   Can be bound to UI controls like DataGridView.

   ✅ Commonly Used DataView Methods

ToTable() - Creates and returns a new DataTable based on the current view.
Find(object key) - Finds the index of a row in the view by the primary key.
FindRows(object key) - Returns an array of DataRowView objects that match the key.
AddNew() - Adds a new row to the view.
Delete(int index) - Deletes a row at the specified index in the view.
Equals(object) - Checks if the current view is equal to another object.
GetEnumerator() - Returns an enumerator for iterating through the view.


🔧 Key Properties (Often Used Like Methods)

RowFilter - Filters rows based on a condition (like SQL WHERE).
Sort - Sorts rows based on column(s).
RowStateFilter - Filters rows based on their state (Added, Modified, Deleted, etc.).
Table - Gets the source DataTable.
Count  - Gets the number of rows in the view.
Item[index] -Gets the DataRowView at the specified index.

✅ Example:

using System;
using System.Data;

class Program
{
    static void Main()
    {
// Step 1: Create a DataTable
        DataTable table = new DataTable("Employees");
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Name", typeof(string));
        table.Columns.Add("Department", typeof(string));
        
 // Step 2: Add some rows
        table.Rows.Add(1, "Alice", "HR");
        table.Rows.Add(2, "Bob", "IT");
        table.Rows.Add(3, "Charlie", "HR");
        table.Rows.Add(4, "David", "Finance");
 // Step 3: Create a DataView from the DataTable
        DataView view = new DataView(table);
 // Step 4: Apply filtering and sorting
        view.RowFilter = "Department = 'HR'";
        view.Sort = "Name ASC";
 // Step 5: Display the filtered and sorted data
        Console.WriteLine("Filtered and Sorted Employees (HR Department):");
        foreach (DataRowView row in view)
        {
            Console.WriteLine($"Id: {row["Id"]}, Name: {row["Name"]}, Department: {row["Department"]}");
        }
    }
}


7.)📜SqlTransaction :
   Purpose: Manages a group of SQL operations as a single unit.

✅ Features:

   Ensures atomicity (all succeed or all fail).
   Works with SqlCommand.

 Some Methods :

  Commit() - Commits the transaction.
  Rollback() - Rolls back the Transaction.
  Dispose() - Releases resources.
   
8.)📚SqlParameter :

  Purpose : Represents a parameter in a SQL command.
  ✅ Features:
   Prevents SQL injection.
   Supports input, output, and return values.
   Strongly typed.

   🔧 Commonly Used Properties (Very Important)

   ParameterName - Name of the parameter (e.g., @Id).
   SqlDbType - SQL Server data type (e.g., SqlDbType.Int).
   Value - The value assigned to the parameter.
   Direction - Specifies if the parameter is Input, Output, InputOutput, or ReturnValue.
   Size - Size of the parameter (useful for strings or binary data).
   IsNullable - Indicates whether the parameter accepts null values.
   Precision - For decimal types, sets the precision.
   Scale - For decimal types, sets the number of decimal places.
   SourceColumn	Used when binding to a DataSet.

9.)📖DataTable :

  ✅ Purpose :
  
   Represents a single in-memory table of data[like sql table].

  ✅Features :
  
  Stores rows and columns.
  Can define primary keys, constraints, and data types.
  Supports filtering and sorting via DataView.

10.)🔹 DataGridView :

   ✅ Purpose:

   Displays tabular data in a grid format in a Windows Forms application
    
   ✅ Features:
   Supports sorting, editing, and styling.
   Can bind to DataTable, DataView, or DataSet.
   Allows user interaction with data.
   

 
   



     
   
   

   
     
  
    

