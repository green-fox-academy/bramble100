using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Day02.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet]
        [Route("greeter")]
        public IActionResult Greeter(DTO input)
        {
            if (String.IsNullOrEmpty(input.name))
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (String.IsNullOrEmpty(input.title))
            {
                return Json(new { error = "Please provide a title!" });
            }

            return Json(new { welcome_message = $"Oh, hi there {input.name}, my dear {input.title}!" });
        }

        public class DTO
        {
            public string name { get; set; }
            public string title { get; set; }
        }

        [HttpGet]
        [Route("/appenda/{inputString}")]
        public IActionResult AppendA(string inputString)
            => String.IsNullOrEmpty(inputString) ?
            (IActionResult)NotFound() :
            Json(new { appended = $"{inputString}a" });

        [HttpPost]
        [Route("/dountil/{what}")]
        public IActionResult DoUntil([FromBody] DTO2 dto)
        {
            int result2 = 0;
            if (dto == null || dto.until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }

            if (RouteData.Values["what"].ToString() == "sum")
            {
                for (int i = (int)dto.until; i > 0; i--)
                {
                    result2 += i;
                }
            }
            else if (RouteData.Values["what"].ToString() == "factor")
            {
                result2 = 1;
                for (int i = (int)dto.until; i > 0; i--)
                {
                    result2 *= i;
                }
            }

            return Json(new { result = result2 });
        }


        [Route("/dountil/{what}")]
        public IActionResult DoUntilWithEmptyJSON(int? until)
        {
            return Json(new { error = "Please provide a number!" });
        }

        public class DTO2
        {
            public int? until { get; set; }
        }

        [HttpPost]
        [Route("arrays")]
        public IActionResult Arrays([FromBody] DTO3 dto)
        {
            if (dto == null)
            {
                return NotFound();
            }

            if (dto.what == "sum")
            {
                return Json(new { result = dto.numbers.ToList().Sum() });
            }
            else if (dto.what == "multiply")
            {
                int result = 1;
                for (int i = 0; i < dto.numbers.Length; i++)
                {
                    result *= dto.numbers[i];
                }
                return Json(new { result = result });
            }
            else if (dto.what == "double")
            {
                for (int i = 0; i < dto.numbers.Length; i++)
                {
                    dto.numbers[i] *= 2;
                }
                return Json(new { result = dto.numbers });
            }
            return NotFound();
        }

        public class DTO3
        {
            public string what { get; set; }
            public int[] numbers { get; set; }
        }
    }

}
