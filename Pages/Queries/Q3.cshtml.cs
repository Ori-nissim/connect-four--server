using connect_four__server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace connect_four__server.Pages.Queries
{
    public class Q3 : PageModel
    {
		private readonly connect_four__server.Data.connect_four__serverContext _context;


		public Q3(connect_four__server.Data.connect_four__serverContext context)
		{
			_context = context;
		}

		public IList<Game> Game { get; set; } = default!;

		public async Task OnGetAsync()
		{
			if (_context.Game != null)
			{
				Game = await _context.Game.ToListAsync();
			}
		}
	}

}

