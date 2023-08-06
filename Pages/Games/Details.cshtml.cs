using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using connect_four__server.Data;
using connect_four__server.Models;

namespace connect_four__server.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly connect_four__server.Data.connect_four__serverContext _context;

        public DetailsModel(connect_four__server.Data.connect_four__serverContext context)
        {
            _context = context;
        }

      public Game Game { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Game == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }
            else 
            {
                Game = game;
            }
            return Page();
        }
    }
}
