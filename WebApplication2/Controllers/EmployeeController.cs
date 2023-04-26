using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Designation = "manager", Name = "vasu" },
                new Employee { Id = 2, Designation = "software developer", Name = "pragna" },
                new Employee { Id = 1, Designation = " Software Trainee", Name = "seetha" }



            };
        }
    }
}
