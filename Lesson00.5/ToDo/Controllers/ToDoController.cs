using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        private static Dictionary<int, Status> statuses = new Dictionary<int, Status>
        {
            { 1, new Status {Id = 1, Value = "Not started"} },
            { 2, new Status {Id = 2, Value = "In Progress"} },
            { 3, new Status {Id = 3, Value = "Done"} }
        };
        private static List<ToDo> list = new List<ToDo>
        {
            new ToDo {Id = 1, Title = "My first ToDo", Description = "Get the app working", Status = statuses[2]}
        };
        public IActionResult Index()
        {
            return View(list);
        }
    }
}