using BigSchool_2080600040_PhamHoangNam.DTOs;
using BigSchool_2080600040_PhamHoangNam.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool_2080600040_PhamHoangNam.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followeingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followeingDto.FolloweeId))
                return BadRequest("Following already exists!");
            var folowing = new Following
            {
                FollowerId = userId,
                FolloweeId = followeingDto.FolloweeId
            };
            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
