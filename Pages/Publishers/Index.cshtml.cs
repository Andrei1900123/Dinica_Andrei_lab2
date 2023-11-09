using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dinica_Andrei_lab2.Data;
using Dinica_Andrei_lab2.Models;

namespace Dinica_Andrei_lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Dinica_Andrei_lab2.Data.Dinica_Andrei_lab2Context _context;

        public IndexModel(Dinica_Andrei_lab2.Data.Dinica_Andrei_lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
