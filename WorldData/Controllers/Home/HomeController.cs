using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorldData.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
