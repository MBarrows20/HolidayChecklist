using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HolidayChecklist.Models;

namespace HolidayChecklist.Pages.Episodes
{
    public class CreateModel : PageModel
    {
        private readonly HolidayChecklist.Models.AppDbContext _context;

        public CreateModel(HolidayChecklist.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Episode Episode { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Episode.Add(Episode);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}