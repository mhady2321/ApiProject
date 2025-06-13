using ApiProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ApiProject.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class DepartmentController : ControllerBase
//    {
//        private readonly ApiAppContext context;

//        public DepartmentController(ApiAppContext _context) 
//        {
//            context = _context;
//        }
//        [HttpGet]
//        public IActionResult GetAll  ()
//        {
//           List<Department> depts=  context.Departments.ToList();

//            return Ok(depts);
//        }
//        [HttpGet]
//        public IActionResult GetById (int id) 
//        {
//            Department dept = context.Departments.FirstOrDefault(d => d.Id == id);
//            return Ok(dept);
//        }
//    }
}
