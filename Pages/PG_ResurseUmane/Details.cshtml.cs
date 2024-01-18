using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fanca_Loredana_Madalina.Data;
using Fanca_Loredana_Madalina.Models;

namespace Fanca_Loredana_Madalina.Pages.PG_ResurseUmane
{
    public class DetailsModel : PageModel
    {
        private readonly Fanca_Loredana_Madalina.Data.Fanca_Loredana_MadalinaContext _context;

        public DetailsModel(Fanca_Loredana_Madalina.Data.Fanca_Loredana_MadalinaContext context)
        {
            _context = context;
        }

        public ResurseUmane ResurseUmane { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resurseumane = await _context.ResurseUmane.FirstOrDefaultAsync(m => m.ID == id);
            if (resurseumane == null)
            {
                return NotFound();
            }
            else
            {
                ResurseUmane = resurseumane;
            }
            return Page();
        }
    }
}
