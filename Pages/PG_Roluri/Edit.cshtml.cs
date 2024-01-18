using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fanca_Loredana_Madalina.Data;
using Fanca_Loredana_Madalina.Models;

namespace Fanca_Loredana_Madalina.Pages.PG_Roluri
{
    public class EditModel : PageModel
    {
        private readonly Fanca_Loredana_Madalina.Data.Fanca_Loredana_MadalinaContext _context;

        public EditModel(Fanca_Loredana_Madalina.Data.Fanca_Loredana_MadalinaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Roluri Roluri { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roluri =  await _context.Roluri.FirstOrDefaultAsync(m => m.ID == id);
            if (roluri == null)
            {
                return NotFound();
            }
            Roluri = roluri;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Roluri).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoluriExists(Roluri.ID))
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

        private bool RoluriExists(int id)
        {
            return _context.Roluri.Any(e => e.ID == id);
        }
    }
}
