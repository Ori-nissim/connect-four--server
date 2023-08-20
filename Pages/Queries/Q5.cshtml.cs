using connect_four__server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace connect_four__server.Pages.Queries
{
    public class Q5Model : PageModel
    {
        private readonly connect_four__server.Data.connect_four__serverContext _context;

        public Q5Model(connect_four__server.Data.connect_four__serverContext context)
        {
            _context = context;
        }

        public IList<Game> GamesByPlayer { get; set; } = new List<Game>();
        public int PlayerId { get; private set; } // Property to store the player ID

        public async Task<IActionResult> OnGetAsync(int id) // Accept the player ID as a parameter
        {
            PlayerId = id; // Store the player ID in the property

            // Query the games by player ID
            GamesByPlayer = await _context.Game
                .Where(game => game.PlayerID == id)
                .ToListAsync();

            return Page(); // Return the Razor Page
        }

      
    }
}
