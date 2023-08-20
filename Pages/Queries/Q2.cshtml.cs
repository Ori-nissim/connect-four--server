using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using connect_four__server.Data;
using connect_four__server.Models;
using connect_four__server.Models.ViewModel;

namespace connect_four__server.Pages.Queries
{
    public class Q2Model : PageModel
    {
        private readonly connect_four__server.Data.connect_four__serverContext _context;


        public Q2Model(connect_four__server.Data.connect_four__serverContext context)
        {
            _context = context;
        }

		public IList<Q2> Player { get; set; } = new List<Q2>();

		public async Task OnGetAsync()
		{
			Player = await _context.Player
				.Select(p => new Q2
                {
					Id = p.Id,
					Name = p.Name,
					MostRecentGameDate = _context.Game
						.Where(g => g.PlayerID == p.Id)
						.OrderByDescending(g => g.StartTime)
						.Select(g => g.StartTime)
						.FirstOrDefault()
				})
				.OrderByDescending(p => p.Name)
				.ToListAsync();
		}
	}

	

}

