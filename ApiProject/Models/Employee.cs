using System.ComponentModel.DataAnnotations;

namespace ApiProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int Phone { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }

        public virtual Department Department { get; set; }

    }
}
