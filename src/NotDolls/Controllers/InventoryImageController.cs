using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using NotDolls.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NotDolls.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [EnableCors("AllowDevelopmentEnvironment")]
    public class InventoryImageController : Controller
    {

        private NotDollsContext _context;

        public InventoryImageController(NotDollsContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IQueryable<object> inventory = from i in _context.InventoryImage
                                           select i;

            if (inventory == null)
            {
                return NotFound();
            }

            return Ok(inventory);
        }

        // GET api/values/5
        [HttpGet("{id}", Name = "GetInventoryImage")]
        public IActionResult Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            InventoryImage inventory = _context.InventoryImage.Single(m => m.InventoryImageId == id);

            if (inventory == null)
            {
                return NotFound();
            }

            return Ok(inventory);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]InventoryImage inventory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.InventoryImage.Add(inventory);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (InventoryExists(inventory.InventoryImageId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("GetInventoryImage", new { id = inventory.InventoryImageId }, inventory);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] InventoryImage inventory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != inventory.InventoryImageId)
            {
                return BadRequest();
            }

            _context.Entry(inventory).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return new StatusCodeResult(StatusCodes.Status204NoContent);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            InventoryImage inventory = _context.InventoryImage.Single(m => m.InventoryImageId == id);
            if (inventory == null)
            {
                return NotFound();
            }

            _context.InventoryImage.Remove(inventory);
            _context.SaveChanges();

            return Ok(inventory);
        }

        private bool InventoryExists(int id)
        {
            return _context.InventoryImage.Count(e => e.InventoryImageId == id) > 0;
        }
    }
}
