using Employee.BLL.EmployeeBLL;
using Employee.DTO.EmployeeDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        EmployeeBLL empBLL = new EmployeeBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<EmployeeDTO> lstEmp = empBLL.ReadEmployee();
            foreach (EmployeeDTO item in lstEmp)
            {
                dataGvEmp.Rows.Add(item.idEmployee, item.Name, item.DateBirth, item.Gender,item.PlaceBirth,item.idDepartment);
            }
        }

        private void dataGvEmp_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            txtId.Text = dataGvEmp.Rows[idx].Cells[0].Value.ToString();
            txtName.Text = dataGvEmp.Rows[idx].Cells[1].Value.ToString();
            dtDate.Value = (DateTime)dataGvEmp.Rows[idx].Cells[2].Value;
            cbGender.Checked = (Boolean)dataGvEmp.Rows[idx].Cells[3].Value;
            txtPlace.Text = dataGvEmp.Rows[idx].Cells[4].Value.ToString();
            comboUnit.Text = dataGvEmp.Rows[idx].Cells[5].Value.ToString();
        }
    }
    
}
