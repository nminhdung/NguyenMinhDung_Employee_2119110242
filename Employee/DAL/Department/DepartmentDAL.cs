using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.DTO.DepartmentDTO;

namespace Employee.DAL.Department
{
    public class DepartmentDAL : DBConnection
    {

       public List<DepartmentDTO> ReadDepartList()

        {
            SqlConnection connect = CreateConnection();
            connect.Open();

            SqlCommand cmd = new SqlCommand("getAllDepartment", connect);
            SqlDataReader reader = cmd.ExecuteReader();
            List<DepartmentDTO> lstDepart = new List<DepartmentDTO>();
            while (reader.Read())
            {
                DepartmentDTO depart = new DepartmentDTO();
                depart.idDepartment = reader["idDepartment"].ToString();
                depart.Name = reader["Name"].ToString();
                lstDepart.Add(depart);
            }
            connect.Close();
            return lstDepart;
        }
        public DepartmentDTO readDepartment(string idDepart)
        {
            SqlConnection connect = CreateConnection();
            connect.Open();

            SqlCommand cmd = new SqlCommand("readDepart @idDepartment", connect);
            cmd.Parameters.Add(new SqlParameter("@idDepartment", idDepart));
            SqlDataReader reader = cmd.ExecuteReader();
            DepartmentDTO depart = new DepartmentDTO();

         

            if(reader.HasRows && reader.Read())

            {
                depart.idDepartment = reader["idDepartment"].ToString();
                depart.Name = reader["Name"].ToString();
            }
            connect.Close();
            return depart;

            //abc
        }

    }
}

   
