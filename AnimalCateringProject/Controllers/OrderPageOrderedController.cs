using AnimalCateringProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalCateringProject.Controllers
{
    [Route("pages/[controller]/")]
    [ApiController]
    public class OrderPageOrderedController : ControllerBase
    {
        private readonly DishContext _context;

        public OrderPageOrderedController(DishContext context)
        {
            _context = context;
        }

        // GET: api/pages/orderpage/Dish
        [HttpGet]
        public IEnumerable<Dish> GetDish()
        {
            List < Dish > ordered = new List<Dish>();
            var t = Task.Run(() =>
            {
                foreach (var item in _context.OrderedDish)
                {
                    if (_context.Dish.Any(x => x.Id == item.DishId))
                        ordered.Add(_context.Dish.First(x => x.Id == item.DishId));
                }
            });
            t.Wait();
            return ordered;
        }

        //// GET: api/pages/orderpage/Dish
        //[HttpGet]
        //public Task<ActionResult<IEnumerable<Dish>>> GetDish()
        //{
        //    List<Dish> ordered = new List<Dish>();
        //    foreach (var item in _context.OrderedDish)
        //    {
        //        if (_context.Dish.Any(x => x.Id == item.DishId))
        //            ordered.Add(_context.Dish.First(x => x.Id == item.DishId));
        //    }
        //    return ordered;
        //}
    }
}