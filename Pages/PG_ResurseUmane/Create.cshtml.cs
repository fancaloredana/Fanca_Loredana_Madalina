using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fanca_Loredana_Madalina.Data;
using Fanca_Loredana_Madalina.Models;

namespace Fanca_Loredana_Madalina.Pages.PG_ResurseUmane
{
    public class CreateModel : PageModel
    {
        private readonly Fanca_Loredana_Madalina.Data.Fanca_Loredana_MadalinaContext _context;

        public CreateModel(Fanca_Loredana_Madalina.Data.Fanca_Loredana_MadalinaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CandidatiID"] = new SelectList(_context.Candidati, "ID", "Documente");
        ViewData["StudiiSuperioareID"] = new SelectList(_context.StudiiSuperioare, "ID", "Facultate");
            return Page();
        }

        [BindProperty]
        public ResurseUmane ResurseUmane { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ResurseUmane.Add(ResurseUmane);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
