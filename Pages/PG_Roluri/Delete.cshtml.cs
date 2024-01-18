using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fanca_Loredana_Madalina.Data;
using Fanca_Loredana_Madalina.Models;

namespace Fanca_Loredana_Madalina.Pages.PG_Roluri
{
    public class DeleteModel : PageModel
    {
        private readonly Fanca_Loredana_Madalina.Data.Fanca_Loredana_MadalinaContext _context;

        public DeleteModel(Fanca_Loredana_Madalina.Data.Fanca_Loredana_MadalinaContext context)
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

            var roluri = await _context.Roluri.FirstOrDefaultAsync(m => m.ID == id);

            if (roluri == null)
            {
                return NotFound();
            }
            else
            {
                Roluri = roluri;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roluri = await _context.Roluri.FindAsync(id);
            if (roluri != null)
            {
                Roluri = roluri;
                _context.Roluri.Remove(Roluri);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
