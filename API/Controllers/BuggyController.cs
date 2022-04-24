using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataDbContext _context;
        public BuggyController(DataDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("auth")]

        public ActionResult<string> GetSecret()
        {
            return "secret text";
        }

        [HttpGet("not-found")]

        public ActionResult<AppUser> GetNotFound()
        {
            var thing = _context.Users.Find(-1);
            if (thing == null) return NotFound();
            return Ok(thing);
        }


        [HttpGet("server-error")]

        public ActionResult<string> GetServerError()
        {
        //    try
        //    {
                var thing = _context.Users.Find(-1);
                var thingToReturn = thing.ToString();
                return thingToReturn;
            //}
            //catch (Exception ex)
            //{

            //    return StatusCode(500, ex.Message);
            //}
           
        }

        [HttpGet("bad-request")]

        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("this is was not a good request");
        }
    }
}
