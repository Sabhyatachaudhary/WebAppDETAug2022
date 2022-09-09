using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System.Reflection;

namespace MVCDemo.Controllers
{
    public class EventController : Controller
    {
        public List<Booking>events { get; set; }
        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add(new Booking { Title="ask CEO",EventDate=DateTime.Today,Qty=10});
            events.Add(new Booking { Title = "cultural", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = "sports", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = "cricket", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = "imdoor", EventDate = DateTime.Today, Qty = 10 });
            return View(events);
        }
        public IActionResult Detail(string title)
        {
            Booking b=events.FirstOrDefault(x=>x.Title == title);
            return View(b);
        }
    }
}
