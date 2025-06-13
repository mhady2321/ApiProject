using ApiProject.Models;

namespace ApiProject.Dto
{
    public class EmployeesWithDepartmentDto
    {
        public int Id { get; set; }

        public string EmpName { get; set; }

        public int Phone { get; set; }
        public int Salary { get; set; }
        public string Address { get; set;}
        public virtual Department Department { get; set; }

    }
}
