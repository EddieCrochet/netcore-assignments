using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.Services;

namespace ToDoApp.ViewCOmponents
{
    public class CardGroupViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var oldestToDos = Repository.ToDos
                .OrderBy(x => x.Created)
                .Take(4)
                .Select(todo => new CardViewModel
                {
                    Title = todo.Title,
                    Summary = todo.Description
                });
            return View(oldestToDos);
        }
    }
}
