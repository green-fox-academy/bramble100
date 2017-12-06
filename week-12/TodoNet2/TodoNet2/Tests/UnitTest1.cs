using Moq;
using NUnit.Framework;
using TodoNet2;
using TodoNet2.Controllers;
using TodoNet2.Repositories;
using TodoNet2.Interfaces;
using Newtonsoft.Json;
using TodoNet2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tests
{
    [TestFixture]
    public class UnitTest1
    {
     
        [Test]
        public void ControllerJson()
        {
            var expectedTodo = new Todo() { Id = 1, Title = "Mock Todo" };
            var expectedTodoList = new List<Todo>() { expectedTodo };
            var expextedResultJson = JsonConvert.SerializeObject(expectedTodoList);

            var todoRepository = new Mock<ITodoRepository>();
            todoRepository
                .Setup(m => m.GetList())
                .Returns(expectedTodoList);

            var rESTController = new RESTController(todoRepository.Object);
            var result = (JsonResult)rESTController.List();
            var resultJson = JsonConvert.SerializeObject(result.Value);
            Assert.AreEqual(expextedResultJson, resultJson);
        }

        [Test]
        public void Controller()
        {
            var expectedTodo = new Todo() { Id = 1, Title = "Mock Todo" };
            var expectedTodoList = new List<Todo>() { expectedTodo };

            var todoRepository = new Mock<ITodoRepository>();
            todoRepository
                .Setup(m => m.GetList())
                .Returns(expectedTodoList);

            var rESTController = new RESTController(todoRepository.Object);
            JsonResult result = (JsonResult)rESTController.List();
            Assert.AreEqual(expectedTodoList, result.Value);
        }

        //[Test]
        //public async Task ControllerAsync()
        //{
        //    var expectedTodo = new Todo() { Id = 1, Title = "Mock Todo" };
        //    var expectedTodoList = new List<Todo>() { expectedTodo };
        //    var expextedResultJson = JsonConvert.SerializeObject(expectedTodoList);

        //    var todoRepository = new Mock<ITodoRepository>();
        //    todoRepository
        //        .Setup(m => m.GetList())
        //        .Returns(expectedTodoList);

        //    var rESTController = new RESTController(todoRepository.Object);
        //    var result = rESTController.List();
        //    var resultJson = JsonConvert.SerializeObject(await result.ExecuteResultAsync());
        //    Assert.AreEqual(expextedResultJson, resultJson);
        //}
    }
}
