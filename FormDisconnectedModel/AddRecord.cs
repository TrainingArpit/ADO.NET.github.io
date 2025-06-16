using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracDisconnected
{
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Server=WKSPUN05GTR1010;Database=PracDisconnected;Trusted_Connection=true";
            SqlConnection conn = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Employees",conn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");
            ds.Tables[0].Constraints.Add("Empno_PK", ds.Tables[0].Columns[0], true);
            DataRow row;
            row = ds.Tables[0].NewRow();
            row["Empno"] = txtEmpno.Text;
            row["Ename"] = txtEname.Text;
            row["Salary"] = txtSalary.Text;
            row["HireDate"] = dtpHiredate.MinDate;
            ds.Tables[0].Rows.Add(row);
            da.Update(ds.Tables[0]);
            MessageBox.Show("Employee Record  Added.",this.Text);
        }
    }
}
