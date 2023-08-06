using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using connect_four__server.Data;
using connect_four__server.Models;

namespace connect_four__server.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly connect_four__serverContext _context;

        public PlayersController(connect_four__serverContext context)
        {
            _context = context;
        }

        // GET: api/Players
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            await Console.Out.WriteLineAsync("Request received 2");

            if (_context.Player == null)
            {
                return NotFound("Did not find users");
            }
            
            return await _context.Player.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayerById([FromRoute] string id)
        {
            await Console.Out.WriteLineAsync("Request received");
            int playerId;
            if (!int.TryParse(id, out playerId))
            {
                // Invalid ID format
                return BadRequest("Invalid player ID format");
            }

            var player = await _context.Player.FindAsync(playerId);
            if (player == null)
            {
                // Player with the specified ID not found
                return NotFound("Did not find user with id " + id);
            }

            return player;
        }
        // api/Players/move
        [HttpGet("move")]
        public async Task<int> getMove()
        {
            Random rnd = new Random();
            int move =  rnd.Next(1, 8);
            return move;
        }
    }
}
