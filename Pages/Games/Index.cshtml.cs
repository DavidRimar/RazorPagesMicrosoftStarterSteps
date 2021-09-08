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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesTemplate.Data.RazorPagesGamesContext _context;

        public IndexModel(RazorPagesTemplate.Data.RazorPagesGamesContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
