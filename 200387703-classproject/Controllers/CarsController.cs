using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _200387703_classproject.Models;

namespace _200387703_classproject.Controllers
{
    public class CarsController : Controller
    {
        List<Car> carList = new List<Car>()
        {
           new Car {Id = 1, Brand = "Ferrari", Model = "Italia", Type = "Sports", Year = 2017},
           new Car {Id = 2, Brand = "Mercedes", Model = "Cclass", Type = "Sports", Year = 2018},
           new Car {Id = 3, Brand = "BMW", Model = "Xseries" , Type = "SUV" , Year = 2018}

        };
        // GET: Cars
        public ActionResult Index()
        {
            return View(carList);
        }
    }
}