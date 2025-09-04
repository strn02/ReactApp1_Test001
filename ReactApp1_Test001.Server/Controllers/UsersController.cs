using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactApp1_Test001.Server.Data;
using ReactApp1_Test001.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace ReactApp1_Test001.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MyDbContext _context;

        public UsersController(MyDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetUsers()
        //{
        //    var users = await _context.Users.ToListAsync();

        //    return Ok(users);
        //}

        [HttpGet]
        public IActionResult GetUsers()
        {
            var testusers = new List<object>()
            {
                new { EmployeeNo = "001", Name = "山田太郎", Department = "営業部" },
                new { EmployeeNo = "002", Name = "鈴木花子", Department = "総務部" },
            };
            return Ok(testusers);
        }
    }

    
}
