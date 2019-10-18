using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Authpractice.Data;

namespace Authpractice.Pages.Coach
{
    public class DeleteModel : PageModel
    {
        private readonly Authpractice.Data.ApplicationDbContext _context;

        public DeleteModel(Authpractice.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Coaches Coaches { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Coaches = await _context.Coaches.FirstOrDefaultAsync(m => m.Cid == id);

            if (Coaches == null)
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

            Coaches = await _context.Coaches.FindAsync(id);

            if (Coaches != null)
            {
                _context.Coaches.Remove(Coaches);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
