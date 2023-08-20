using connect_four__server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace connect_four__server.Pages.Queries
{
    public class Q4Model : PageModel
    {
		private readonly connect_four__server.Data.connect_four__serverContext _context;

		public Q4Model(connect_four__server.Data.connect_four__serverContext context)
		{
			_context = context;
		}

		public IList<Game> Games { get; set; } = new List<Game>();

		public async Task OnGetAsync()
		{
			Games = await _context.Game
				.GroupBy(g => new { g.PlayerID, g.Moves })
				.Select(group => group.OrderBy(g => g.StartTime).First())
				.ToListAsync();
		}
	}

    
}





