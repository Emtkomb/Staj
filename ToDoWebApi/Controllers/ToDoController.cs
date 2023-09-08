using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using ToDo.BusinessLayer.Abstract;
using ToDo.DataAccessLayer.Abstract;
using ToDo.EntityLayer.Concrete;

namespace ToDoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _todoservice;

        public ToDoController(IToDoService todoservice)
        {
            _todoservice = todoservice;
        }

        [HttpGet]
         public IActionResult ToDoList()
        {
            var values=_todoservice.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddToDo(todo todoo) 
        {
            _todoservice.TInsert(todoo);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteToDo(int id)
        {
            var values=_todoservice.TGetByID(id);
            _todoservice.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateToDo(todo todoo)
        {
            _todoservice.TUpdate(todoo);
            return Ok();
        }
        [HttpGet("(id)")]
        public IActionResult GetToDo(int id)
        {
            var values = _todoservice.TGetByID(id);

            return Ok(values);
        }
    }
}
