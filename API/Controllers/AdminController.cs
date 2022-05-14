using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{

    public class AdminController : BaseApiController
    {
        [Authorize(Policy="RequiredAdminRole")]

        [HttpGet("users-with-roles")]
        public ActionResult GetUsersWithRoles()
        {
            return Ok("only admins can see this ");
        }

        [Authorize(Policy = "ModeratePhotoRole")]

        [HttpGet("photos-to-moderate")]
        public ActionResult GetPhotosForModeration()
        {
            return Ok("Admin or moderators can see this");
        }
    }
}
