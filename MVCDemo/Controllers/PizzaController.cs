using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Service;

namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);
        }
        public IActionResult List()
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);
        }
        public IActionResult Details(int id)
        {
            Pizza p= PizzaService.Get(id);
            return View(p);
        }

        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        //public IActionResult Create(int id,string name,int size,decimal price,bool Isglutenfreee)
        public IActionResult Create(Pizza p)
        {
            PizzaService.Add(p);
            return RedirectToAction("List");
        }
    }
}
