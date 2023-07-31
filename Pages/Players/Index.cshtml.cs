using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using connect_four__server.Data;
using connect_four__server.Models;

namespace connect_four__server.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly connect_four__server.Data.connect_four__serverContext _context;

        public IndexModel(connect_four__server.Data.connect_four__serverContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Player != null)
            {
                Player = await _context.Player.ToListAsync();
            }
        }
    }
}
