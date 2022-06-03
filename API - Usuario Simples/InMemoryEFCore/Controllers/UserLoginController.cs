using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemoryEFCore.Models;
using InMemoryEFCore.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace InMemoryEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
            private UserLoginDBContext _context;

            public UserLoginController(UserLoginDBContext context)
            {
                _context = context;
            }

            // GET api/userLogin
            [HttpGet]
            public ActionResult<IEnumerable<UserLoginModel>> Get()
            {
                return _context.UserLogin;
            }

            // GET api/userLogin/1
            [HttpGet("{id}")]
            public ActionResult<UserLoginModel> Get(int id)
            {
                return _context.UserLogin.FirstOrDefault(usert => usert.id == id);
            }

            [HttpPost]
            public async Task<ActionResult<UserLoginModel>> Post(UserLoginModel user)
            {
                _context.UserLogin.Add(user);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(Get), new { user.id }, user);
            }

    }
}
