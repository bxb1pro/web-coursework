using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DigitalGamesMarketplace.Models;

namespace DigitalGamesMarketplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameUpdatesController : ControllerBase
    {
        private readonly MarketplaceContext _context;

        public GameUpdatesController(MarketplaceContext context)
        {
            _context = context;
        }

        // GET: api/GameUpdates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameUpdate>>> GetGameUpdates()
        {
            return await _context.GameUpdates.ToListAsync();
        }

        // GET: api/GameUpdates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameUpdate>> GetGameUpdate(int id)
        {
            var gameUpdate = await _context.GameUpdates.FindAsync(id);

            if (gameUpdate == null)
            {
                return NotFound();
            }

            return gameUpdate;
        }

        // PUT: api/GameUpdates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGameUpdate(int id, GameUpdate gameUpdate)
        {
            if (id != gameUpdate.GameUpdateId)
            {
                return BadRequest();
            }

            _context.Entry(gameUpdate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameUpdateExists(id))
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

        // POST: api/GameUpdates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GameUpdate>> PostGameUpdate(GameUpdate gameUpdate)
        {
            _context.GameUpdates.Add(gameUpdate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGameUpdate", new { id = gameUpdate.GameUpdateId }, gameUpdate);
        }

        // DELETE: api/GameUpdates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGameUpdate(int id)
        {
            var gameUpdate = await _context.GameUpdates.FindAsync(id);
            if (gameUpdate == null)
            {
                return NotFound();
            }

            _context.GameUpdates.Remove(gameUpdate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GameUpdateExists(int id)
        {
            return _context.GameUpdates.Any(e => e.GameUpdateId == id);
        }
    }
}
