using Employee.DAL.Employee;
using Employee.DTO.EmployeeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.BLL.EmployeeBLL
{
    public class EmployeeBLL
    {
        EmployeeDAL dal = new EmployeeDAL();
        public List<EmployeeDTO> ReadEmployee()
        {
            List<EmployeeDTO> lstEmp = dal.ReadEmployee();
            return lstEmp;
        }
    }
}
