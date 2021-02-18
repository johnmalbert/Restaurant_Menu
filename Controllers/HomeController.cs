using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Crudelicious.Models;
using Microsoft.EntityFrameworkCore;


namespace Crudelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes
            .OrderByDescending(d => d.CreatedAt)
            .ToList();
            ViewBag.Dishes = AllDishes;
            return View();
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("CreateDish")]
        public IActionResult CreateDish(Dish newDish)
        {
            Console.WriteLine(newDish.Chef);
            if(ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("add");
            }
        }

        [HttpGet("{num}")]
        public IActionResult DishNumber(int num)
        {
            Console.WriteLine(num);
            ViewBag.CurrentDish = dbContext.Dishes
                .FirstOrDefault(d => d.DishId == num);
            return View();
        }

        [HttpGet("{num}/Delete")]
        public IActionResult DeleteDish(int num)
        {
            Dish CurrentDish = dbContext.Dishes
                .FirstOrDefault(d => d.DishId == num);
            dbContext.Dishes.Remove(CurrentDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("{num}/update")]
        public IActionResult Update(int num)
        {
            ViewBag.CurrentDish = dbContext.Dishes
                .FirstOrDefault(d => d.DishId == num);

            return View();
        }

        [HttpPost("{num}/updatedish")]
        public IActionResult UpdateDish(int num, Dish updatedDish)
        {   
            Dish CurrentDish = dbContext.Dishes
                .FirstOrDefault(d => d.DishId == num);
            if(ModelState.IsValid)
            {
                CurrentDish.Name = updatedDish.Name;
                CurrentDish.Chef = updatedDish.Chef;
                CurrentDish.Tastiness = updatedDish.Tastiness;
                CurrentDish.Calories = updatedDish.Calories;
                CurrentDish.Description = updatedDish.Description;
                CurrentDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("DishNumber", num);
            }
            else
            {
                return View("Update", num);
            }
        }
    }
}
