using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DigitalGamesMarketplace2.Models;

namespace DigitalGamesMarketplace2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameWishlistsController : ControllerBase
    {
        private readonly MarketplaceContext _context;

        public GameWishlistsController(MarketplaceContext context)
        {
            _context = context;
        }

        // GET: api/GameWishlists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameWishlist>>> GetGameWishlists()
        {
            return await _context.GameWishlists.ToListAsync();
        }

        // GET: api/GameWishlists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameWishlist>> GetGameWishlist(int id)
        {
            var gameWishlist = await _context.GameWishlists.FindAsync(id);

            if (gameWishlist == null)
            {
                return NotFound();
            }

            return gameWishlist;
        }

        // PUT: api/GameWishlists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGameWishlist(int id, GameWishlist gameWishlist)
        {
            if (id != gameWishlist.GameWishlistId)
            {
                return BadRequest();
            }

            _context.Entry(gameWishlist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameWishlistExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GameWishlists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GameWishlist>> PostGameWishlist(GameWishlist gameWishlist)
        {
            _context.GameWishlists.Add(gameWishlist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGameWishlist", new { id = gameWishlist.GameWishlistId }, gameWishlist);
        }

        // DELETE: api/GameWishlists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGameWishlist(int id)
        {
            var gameWishlist = await _context.GameWishlists.FindAsync(id);
            if (gameWishlist == null)
            {
                return NotFound();
            }

            _context.GameWishlists.Remove(gameWishlist);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GameWishlistExists(int id)
        {
            return _context.GameWishlists.Any(e => e.GameWishlistId == id);
        }
    }
}
