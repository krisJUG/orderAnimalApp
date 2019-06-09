using AnimalCateringProject.Data;
using AnimalCateringProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalCateringProject.Controllers
{
    [Route("pages/[controller]/")]
    [ApiController]
    public class OrderPageAllDishController : ControllerBase
    {
        private readonly DishContext _context;

        public OrderPageAllDishController(DishContext context)
        {
            _context = context;

            if (_context.Dish.Count() == 0)
            {
                _context.Dish.Add(new Dish { IsComplete = false, Name = "SchabowySpokoLux", Desc = "Calkiem spoko" });
                _context.SaveChanges();
            }
        }

        // GET: api/pages/orderpage/Dish
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dish>>> GetDish()
        {
            return await _context.Dish.ToListAsync();
        }

        // GET: api/pages/orderpage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dish>> GetDish(long id)
        {
            var dish = await _context.Dish.FindAsync(id);

            if (dish == null)
            {
                return NotFound();
            }

            return dish;
        }

        // DELETE: api/pages/orderpage/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDish(long id)
        {
            var Dish = await _context.Dish.FindAsync(id);

            if (Dish == null)
            {
                return NotFound();
            }

            AddOrder(Dish);
            return NoContent();
        }

        private void AddOrder(Dish dish)
        {
            _context.OrderedDish.Add(new OrderedDish() { DishId = dish.Id });
            _context.SaveChanges();
        }
    }
}