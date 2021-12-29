using Employee.DAL.Department;
using Employee.DTO.DepartmentDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.BLL.DepartmentBLL
{
    public class DepartmentBLL
    {
        DepartmentDAL departDAL = new DepartmentDAL();
        public List<DepartmentDTO> readDepartList()
        {
            List<DepartmentDTO> lstDepart = departDAL.ReadDepartList();
            return lstDepart;
        }
    }

