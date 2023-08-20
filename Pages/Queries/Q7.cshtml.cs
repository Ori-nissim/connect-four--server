using connect_four__server.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace connect_four__server.Pages.Queries
{
    public class Q7Model : PageModel
    {
        private readonly connect_four__server.Data.connect_four__serverContext _context;

        public Q7Model(connect_four__server.Data.connect_four__serverContext context)
        {
            _context = context;
        }

        public IList<Q6> PlayerGamesCounts { get; set; } = new List<Q6>();

        public async Task OnGetAsync()
        {
            PlayerGamesCounts = await _context.Player
                .Select(player => new Q6
                {
                    Player = player,
                    GamesCount = _context.Game.Count(g => g.PlayerID == player.Id)
                })
                .OrderByDescending(p => p.GamesCount).ToListAsync();
        }
    }
}
