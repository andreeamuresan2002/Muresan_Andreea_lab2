﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Muresan_Andreea_lab2.Data;
using Muresan_Andreea_lab2.Models;

namespace Muresan_Andreea_lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Muresan_Andreea_lab2.Data.Muresan_Andreea_lab2Context _context;

        public IndexModel(Muresan_Andreea_lab2.Data.Muresan_Andreea_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}
