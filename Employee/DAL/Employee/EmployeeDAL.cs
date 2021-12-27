using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Employee.DTO.EmployeeDTO;

namespace Employee.DAL.Employee
{
   public class EmployeeDAL : DBConnection
    {
        public List<EmployeeDTO> ReadEmployee()
        {
            SqlConnection connect = CreateConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("getAllEmployees", connect);
            SqlDataReader reader = cmd.ExecuteReader();
            List<EmployeeDTO> lstEmp = new List<EmployeeDTO>();
            while (reader.Read())
            {
                EmployeeDTO emp = new EmployeeDTO();
                emp.idEmployee = reader["idEmployee"].ToString();
                emp.Name = reader["Name"].ToString();
                emp.DateBirth = (DateTime)reader["DateBirth"];
                emp.Gender = (Boolean)reader["Gender"];
                emp.idDepartment = reader["idDepartment"].ToString();
                lstEmp.Add(emp);
            }
            connect.Close();
            return lstEmp;
        }
    }
}
