using connect_four__server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace connect_four__server.Pages.Queries
{
    public class Q8Model : PageModel
    {
        private readonly connect_four__server.Data.connect_four__serverContext _context;


        public Q8Model(connect_four__server.Data.connect_four__serverContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Player != null)
            {
                Player = await _context.Player.OrderBy(p => p.Country).ToListAsync();
            }
        }
    }
}
