using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesTemplate.Data;
using RazorPagesTemplate.Model;

namespace RazorPagesTemplate.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesTemplate.Data.RazorPagesGamesContext _context;

        public DetailsModel(RazorPagesTemplate.Data.RazorPagesGamesContext context)
        {
            _context = context;
        }

        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Game.FirstOrDefaultAsync(m => m.GameID == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
