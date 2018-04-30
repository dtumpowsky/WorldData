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

        [HttpGet("/city")]
        public ActionResult CitySearch()
        {
          string search = Request.Query["city"];
          List<City> foundCities = City.GetAllCityInfo(search);
          return View("Index",foundCities);
        }

        [HttpGet("/country")]
        public ActionResult CountrySearch()
        {
          string search = Request.Query["country"];
          List<Country> foundCountries = Country.GetAllCountryInfo(search);
          return View("Index",foundCountries);
        }
    }
}
