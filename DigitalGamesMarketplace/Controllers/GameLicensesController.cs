using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DigitalGamesMarketplace2.Models;
using Microsoft.AspNetCore.Authorization;

namespace DigitalGamesMarketplace2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameLicensesController : ControllerBase
    {
        private readonly MarketplaceContext _context;

        public GameLicensesController(MarketplaceContext context)
        {
            _context = context;
        }

        // GET: api/GameLicenses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameLicense>>> GetGameLicenses()
        {
            return await _context.GameLicenses.ToListAsync();
        }

        // GET: api/GameLicenses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameLicense>> GetGameLicense(int id)
        {
            var gameLicense = await _context.GameLicenses.FindAsync(id);

            if (gameLicense == null)
            {
                return NotFound();
            }

            return gameLicense;
        }

        // PUT: api/GameLicenses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGameLicense(int id, GameLicense gameLicense)
        {
            if (id != gameLicense.GameLicenseId)
            {
                return BadRequest();
            }

            _context.Entry(gameLicense).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameLicenseExists(id))
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

        // POST: api/GameLicenses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GameLicense>> PostGameLicense(GameLicense gameLicense)
        {
            _context.GameLicenses.Add(gameLicense);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGameLicense", new { id = gameLicense.GameLicenseId }, gameLicense);
        }

        // DELETE: api/GameLicenses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGameLicense(int id)
        {
            var gameLicense = await _context.GameLicenses.FindAsync(id);
            if (gameLicense == null)
            {
                return NotFound();
            }

            _context.GameLicenses.Remove(gameLicense);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GameLicenseExists(int id)
        {
            return _context.GameLicenses.Any(e => e.GameLicenseId == id);
        }
    }
}
