using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DTO.DepartmentDTO
{
    public class DepartmentDTO
    {
        public string idDepartment { get; set; }
        public string Name { get; set; }
        public List<EmployeeDTO.EmployeeDTO> Employees { get; set; }
    }
}
