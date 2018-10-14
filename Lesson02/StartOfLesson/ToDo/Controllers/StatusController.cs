using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class StatusController : Controller
    {
        private static List<Status> StatusList = new List<Status>()
        {
            new Status {Id = 1, Value = "Not Started" },
            new Status {Id = 2, Value = "In Progress"},
            new Status {Id = 3, Value = "Done" },
            new Status {Id = 4, Value = "In Review"},
        };
        public IActionResult Index()
        {
            return View(StatusList);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(Status Collection)
        {
            return View();
        }
    }
}