using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Authpractice.Data;

namespace Authpractice.Pages.Coach
{
    public class EditModel : PageModel
    {
        private readonly Authpractice.Data.ApplicationDbContext _context;

        public EditModel(Authpractice.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Coaches).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoachesExists(Coaches.Cid))
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

        private bool CoachesExists(int id)
        {
            return _context.Coaches.Any(e => e.Cid == id);
        }
    }
}
