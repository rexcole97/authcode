using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Authpractice.Data;

namespace Authpractice.Pages.Teams
{
    public class DeleteModel : PageModel
    {
        private readonly Authpractice.Data.ApplicationDbContext _context;

        public DeleteModel(Authpractice.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public teams teams { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            teams = await _context.teams.FirstOrDefaultAsync(m => m.teamid == id);

            if (teams == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            teams = await _context.teams.FindAsync(id);

            if (teams != null)
            {
                _context.teams.Remove(teams);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
