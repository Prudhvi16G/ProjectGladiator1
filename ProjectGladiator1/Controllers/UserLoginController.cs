using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectGladiator1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGladiator1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        Home_LoanContext context;
        public UserLoginController(Home_LoanContext _context)
        {
            context = _context;
        }
        [HttpPost]
        public IActionResult UserLogin(PersonalDetails perdet)
        {
            var data = context.PersonalDetails.Where(x => x.Username == perdet.Username && x.Password == perdet.Password).FirstOrDefault();
            if(data != null)
            {
                return Ok(context.PersonalDetails);
            }
            else
            {
                return BadRequest("Login Failed");
            }
        }
    }
    
}
