using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesTemplate.Data;
using RazorPagesTemplate.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesTemplate.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesTemplate.Data.RazorPagesGamesContext _context;

        // CONSTRUCTOR
        public IndexModel(RazorPagesTemplate.Data.RazorPagesGamesContext context)
        {
            _context = context;
        }

        // PROPERTIES
        public IList<Game> Game { get;set; }

        [BindProperty(SupportsGet = true)]
        public string HomeTeamSearchString { get; set; }
        

        // METHODS
        public async Task OnGetAsync()
        {
            var games = from g in _context.Game
                         select g;

            if (!string.IsNullOrEmpty(HomeTeamSearchString))
            {
                games = games.Where(g => g.HomeTeamName.Contains(HomeTeamSearchString));
            }

            Game = await games.ToListAsync();
        }
    }
}
