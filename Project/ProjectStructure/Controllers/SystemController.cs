﻿using Microsoft.AspNetCore.Mvc;

namespace ProjectStructure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SystemController : ControllerBase
    {
        /// <summary>
        /// Get Status
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetStatus")]
        public string GetStatus()
        {
            return "It works.";
        }
    }
}
