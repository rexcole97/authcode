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
    public class IndexModel : PageModel
    {
        private readonly Authpractice.Data.ApplicationDbContext _context;

        public IndexModel(Authpractice.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Coaches> Coaches { get;set; }

        public async Task OnGetAsync()
        {

    
        }
    }
}
