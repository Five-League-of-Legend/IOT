using IOT.Core.IRepository.Activity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityController(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        //显示
        [Route("/api/ActivityShow")]
        [HttpGet]
        public IActionResult ActivityShow()
        {
            var ls = _activityRepository.ShowActivity();
            return Ok(new { msg = "", code = 0, data = ls });
        }


    }
}
