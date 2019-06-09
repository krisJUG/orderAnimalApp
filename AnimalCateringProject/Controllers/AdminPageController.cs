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
    public class AdminPageController : ControllerBase
    {
        private readonly DishContext _context;

        public AdminPageController(DishContext context)
        {
            _context = context;
        }

        // GET: api/pages/adminpage/Dish
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dish>>> GetDish()
        {
            return await _context.Dish.ToListAsync();
        }

        // GET: api/pages/adminpage/Dish/5
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

        // POST: api/pages/adminpage/Dish
        [HttpPost]
        public async Task<ActionResult<Dish>> PostDish(Dish item)
        {
            _context.Dish.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDish), new { id = item.Id }, item);
        }

        // PUT: api/pages/adminpage/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDish(long id, Dish item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //// DELETE: api/pages/adminpage/5
        //[HttpDelete("{id}")]
        //public IActionResult DeleteDish(long id)
        //{
        //    try
        //    {
        //        var tempDish = _context.Dish.Find(id);

        //        if (tempDish == null)
        //        {
        //            return NotFound();
        //        }

        //        _context.Dish.Remove(tempDish);
        //        _context.SaveChanges();

        //        return NoContent();
        //    }
        //    catch
        //    {
        //        foreach (var od in _context.OrderedDish)
        //            _context.OrderedDish.Remove(od);
        //        _context.SaveChanges();
        //        DeleteDish(id);
        //    }
        //    return NoContent();
        //}

        // DELETE: api/pages/adminpage/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDish(long id)
        {
            var tempDish = await _context.Dish.FindAsync(id);

            if (tempDish == null)
            {
                return NotFound();
            }

            _context.Dish.Remove(tempDish);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}