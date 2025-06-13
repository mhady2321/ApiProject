using System.Collections.Generic;

namespace ApiProject.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Manger { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}