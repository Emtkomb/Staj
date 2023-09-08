using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Newtonsoft.Json;
using System.Text;
using WebUI.Dtos.ToDoDto;




namespace WebUI.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ToDoController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5256/api/ToDo");
            if(responseMessage.IsSuccessStatusCode) 
            { 
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultToDoDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddToDo()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddToDo(CreateToDoDto model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(model);
            StringContent stringContent= new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("http://localhost:5256/api/ToDo",stringContent);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task <IActionResult> DeleteToDo(int id)
        {
            var client = _httpClientFactory.CreateClient();          
            var responseMessage = await client.DeleteAsync($"http://localhost:5256/api/ToDo/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public async Task<IActionResult> UpdateToDo(int id)
        {
            var client = _httpClientFactory.CreateClient();          
            var responseMessage = await client.GetAsync($"http://localhost:5256/api/ToDo/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
               var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<UpdateToDoDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateToDo(UpdateToDoDto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"Application/Json");
            var responseMessage = await client.PutAsync("http://localhost:5256/api/ToDo/",stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
       
    }
}
