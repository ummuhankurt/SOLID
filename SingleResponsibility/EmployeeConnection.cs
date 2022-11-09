using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SingleResponsibility
{
    public class EmployeeConnection
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
    }
}
