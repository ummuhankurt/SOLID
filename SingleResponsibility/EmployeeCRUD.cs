using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class EmployeeCRUD
    {
        public void EmployeeAdd(EmployeeDef employeeDef)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert into Employees (FirstName,LastName,City) values(@p1,@p2,@p3)", EmployeeConnection.conn);
            if (sqlCommand.Connection.State != System.Data.ConnectionState.Open)
            {
                EmployeeConnection.conn.Open();
            }
            sqlCommand.Parameters.AddWithValue("@p1", employeeDef.EmployeeName);
            sqlCommand.Parameters.AddWithValue("@p2", employeeDef.EmployeeSurname);
            sqlCommand.Parameters.AddWithValue("@p3", employeeDef.City);
            sqlCommand.ExecuteNonQuery(); // return sqlCommand.ExecuteNonQuery() :> bize bu işten etkilenen kayıt sayısını döndürür.
            EmployeeConnection.conn.Close();
        }

        public void EmployeeDelete(int id)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Delete from Employees where EmployeeID = " + id, EmployeeConnection.conn);
                if (sqlCommand.Connection.State != System.Data.ConnectionState.Open)
                {
                    EmployeeConnection.conn.Open();
                }
                sqlCommand.ExecuteNonQuery();
                EmployeeConnection.conn.Close();
            }
            catch (Exception e )
            {

                Console.WriteLine(e);
            }
        }

        public void EmployeeList()
        {
            SqlCommand sqlCommand = new SqlCommand("Select *from Employees", EmployeeConnection.conn);

            if(sqlCommand.Connection.State != System.Data.ConnectionState.Open)
            {
                EmployeeConnection.conn.Open();
            }
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3]);
            }
            dr.Close();
        }
    }
}
