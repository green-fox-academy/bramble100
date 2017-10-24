using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day02Intro.Controllers
{
    public class HomeController
    {
        [Route("hello")]
        public string Hello()
        {
            return "Hello Controller World!";
        }
    }
}
