﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Muresan_Andreea_lab2.Data;
using Muresan_Andreea_lab2.Models;

namespace Muresan_Andreea_lab2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Muresan_Andreea_lab2.Data.Muresan_Andreea_lab2Context _context;

        public CreateModel(Muresan_Andreea_lab2.Data.Muresan_Andreea_lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
