﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly Fanca_Loredana_Madalina.Data.Fanca_Loredana_MadalinaContext _context;

        public IndexModel(Fanca_Loredana_Madalina.Data.Fanca_Loredana_MadalinaContext context)
        {
            _context = context;
        }

        public IList<ResurseUmane> ResurseUmane { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ResurseUmane = await _context.ResurseUmane
                .Include(r => r.Candidati)
                .Include(r => r.StudiiSuperioare).ToListAsync();
        }
    }
}
