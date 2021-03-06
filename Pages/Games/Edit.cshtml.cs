using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesTemplate.Data;
using RazorPagesTemplate.Model;

namespace RazorPagesTemplate.Pages.Games
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesTemplate.Data.RazorPagesGamesContext _context;

        public EditModel(RazorPagesTemplate.Data.RazorPagesGamesContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            // if model state is invalid
            if (!ModelState.IsValid)
            {
                // return the Edit Page
                return Page();
            }

            // save entity state
            _context.Attach(Game).State = EntityState.Modified;

            try
            {
                // save changes to DB
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(Game.GameID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GameExists(int id)
        {
            return _context.Game.Any(e => e.GameID == id);
        }
    }
}
