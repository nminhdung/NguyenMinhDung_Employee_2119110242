using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DTO.EmployeeDTO
{
   public class EmployeeDTO
    {
        public string idEmployee { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public Boolean Gender { get; set; }
        public string PlaceBirth { get; set; }
        public string idDepartment { get; set; }
    }
}
