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
    public class DetailsModel : PageModel
    {
        private readonly Authpractice.Data.ApplicationDbContext _context;

        public DetailsModel(Authpractice.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
