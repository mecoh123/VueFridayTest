using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VueFridayTest.Models;
using Newtonsoft.Json;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Diagnostics;

namespace VueFridayTest.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet("[action]")]
        public async Task<IActionResult> Read([DataSourceRequest]DataSourceRequest request)
        {
            List<Users> users = new List<Users>()
            {
                new Users { Id = 1, FirstName = "juan", MiddleName = "cruz", LastName = "dela cruz", NumberToWord = "1", Birthday = new DateTime(1991, 12, 12), Gender = "m", Status = "single", Location = "Philippines"},
                new Users { Id = 2, FirstName = "narciso", MiddleName = "pepe", LastName = "dela torre", NumberToWord = "2", Birthday = new DateTime(1991, 12, 12), Gender = "m", Status = "single", Location = "Philippines"},
                new Users { Id = 3, FirstName = "juana", MiddleName = "santos", LastName = "garcia", NumberToWord = "3", Birthday = new DateTime(1991, 12, 12), Gender = "m", Status = "single", Location = "Philippines"},
                new Users { Id = 4, FirstName = "omar", MiddleName = "segundo", LastName = "zamora", NumberToWord = "4", Birthday = new DateTime(1991, 12, 12), Gender = "m", Status = "single", Location = "Philippines"},
                new Users { Id = 5, FirstName = "bettany", MiddleName = "urdaneta", LastName = "reyes", NumberToWord = "5", Birthday = new DateTime(1991, 12, 12), Gender = "m", Status = "single", Location = "Philippines"}
            };
                        
            return Json(await users.ToDataSourceResultAsync(request));
        }        
    }
}
