using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Employee.DTO.EmployeeDTO;


using Employee.DTO.DepartmentDTO;

using Employee.DAL.Department;

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
            DepartmentDAL departDAL = new DepartmentDAL();
            while (reader.Read())
            {
                EmployeeDTO emp = new EmployeeDTO();
                emp.idEmployee = reader["idEmployee"].ToString();
                emp.Name = reader["Name"].ToString();
                emp.DateBirth = (DateTime)reader["DateBirth"];
                emp.Gender = (Boolean)reader["Gender"];
                emp.PlaceBirth = reader["PlaceBirth"].ToString();


                emp.Depart = departDAL.readDepartment(reader["idDepartment"].ToString());

                lstEmp.Add(emp);
            }
            connect.Close();
            return lstEmp;
        }



        


        public void AddEmployee(EmployeeDTO emp)
        {
            SqlConnection connect = CreateConnection();
            connect.Open();

            SqlCommand cmd = new SqlCommand("addEmployee @idEmployee,@Name,@DateBirth,@Gender,@PlaceBirth,@idDepartment", connect);
            cmd.Parameters.Add(new SqlParameter("@idEmployee", emp.idEmployee));
            cmd.Parameters.Add(new SqlParameter("@Name", emp.Name));
            cmd.Parameters.Add(new SqlParameter("@DateBirth", emp.DateBirth));
            cmd.Parameters.Add(new SqlParameter("@Gender", emp.Gender));
            cmd.Parameters.Add(new SqlParameter("@PlaceBirth", emp.PlaceBirth));
            cmd.Parameters.Add(new SqlParameter("@idDepartment", emp.Depart.idDepartment));

            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void DeleteEmployee(EmployeeDTO emp)
        {
            SqlConnection connect = CreateConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("deleteEmployee @idEmployee", connect);
            cmd.Parameters.Add(new SqlParameter("@idEmployee", emp.idEmployee));
            cmd.ExecuteNonQuery();
            connect.Close();
        }

    }
}
