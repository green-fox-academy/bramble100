using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LagopusExam.Services;
using LagopusExam.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LagopusExam.Controllers
{
    [Route("api")]
    public class APIController : Controller
    {
        private LagopusExamService lagopusExamService;

        public APIController(LagopusExamService lagopusExamService)
            => this.lagopusExamService = lagopusExamService;

        [Route("")]
        public IActionResult Index()
        {
            return Json(new { Alles = "ist ok" });
        }

        [HttpGet]
        [Route("question/{id}")]
        public IActionResult GetQuestionById(int id)
        {
            try
            {
                return Json(lagopusExamService.GetQuestionById(id));
            }
            catch (Exception)
            {
                return BadRequest(new { invalidId = id });
            }
        }

        [HttpGet]
        [Route("questions")]
        [Route("quiz")]
        public IActionResult GenerateNewQuiz()
        {
            try
            {
                int id = lagopusExamService.GenerateNewQuiz();
                return Json(lagopusExamService.GetQuizById(id));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Route("addquestion")]
        public IActionResult AddQuestion([FromBody]            QuestionWithAnswer question)
        {
            lagopusExamService.AddQuestion(question);
            return Ok();
        }
    }
}
