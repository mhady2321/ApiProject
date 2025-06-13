using ApiProject.Dto;
using ApiProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApiAppContext _context;

        public EmployeeController(ApiAppContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            List<Employee> Employees = _context.Employees.Include(d=>d.Department).ToList();
            return Ok(Employees);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetEmployeeById(int id) 
        {
         Employee employee = _context.Employees.Include(d=>d.Department).FirstOrDefault(x => x.Id == id);
            EmployeesWithDepartmentDto EmpDto = new EmployeesWithDepartmentDto();
            EmpDto.Id = employee.Id;
            EmpDto.Address = employee.Address;
            EmpDto.EmpName = employee.Name;
            EmpDto.Phone = employee.Phone;
            EmpDto.Department = employee.Department;
            return Ok(EmpDto);
        }

        [HttpGet("{Name:alpha}")]
        public IActionResult GetEmployeeByName(string Name)
        {
            Employee employee = _context.Employees.FirstOrDefault(x => x.Name == Name);
            return Ok(employee);
        }
        //[HttpPost]
        //public IActionResult AddEmployee(Employee employee ) 
        //{
        //   if(ModelState.IsValid)
        //    {
        //        _context.Employees.Add(employee);
        //        _context.SaveChanges();
        //        string url = Url.Link( "GetOneDeptRoute", new { id = employee.Id });
        //        return Created(url,employee);
        //    }
        //    else
        //    {
        //        return BadRequest(ModelState);
        //    }

        //}
      
        //public IActionResult Edit(int id, Employee emp) 
        //{
        //    if(ModelState.IsValid) 
        //    { 
        //        if (emp.Id != null) 
        //        {
        //            OldEmp= GetEmployeeById(emp.Id);
        //        }
        //    }
        //}
    }
   
}
