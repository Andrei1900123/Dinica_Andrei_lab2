using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dinica_Andrei_lab2.Data;
using Dinica_Andrei_lab2.Models;

namespace Dinica_Andrei_lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Dinica_Andrei_lab2.Data.Dinica_Andrei_lab2Context _context;

        public IndexModel(Dinica_Andrei_lab2.Data.Dinica_Andrei_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b=>b.Publisher)
                    .ToListAsync();
                
            }
        }
    }
}
