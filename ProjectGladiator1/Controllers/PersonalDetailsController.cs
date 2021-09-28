using ProjectGladiator1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGladiator1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PersonalDetailsController:ControllerBase
    {
        Home_LoanContext context;
        public PersonalDetailsController(Home_LoanContext _context)
        {
            context = _context;
        }
        public IActionResult GetAll()
        {
            return Ok(context.PersonalDetails);
        }
        [HttpPost]
        public IActionResult perdetails(PersonalDetails personaldetails)
        {
            context.PersonalDetails.Add(personaldetails);
            context.SaveChanges();
            return Ok(context.PersonalDetails);
        }
    }
}