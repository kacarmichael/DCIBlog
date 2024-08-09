using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DCIBlog.Server.Models;
using DCIBlog.Server.Utils;

namespace DCIBlog.Server.Controllers 
{
    [Route("api/AddData")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly DCIDbContext _context;

        public TestController(DCIDbContext context) 
        {
            _context = context;
        }
        
        [HttpPost]
        public async void AddData()
        {

        }
    }
}


