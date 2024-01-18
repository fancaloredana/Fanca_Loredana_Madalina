using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fanca_Loredana_Madalina.Models;

namespace Fanca_Loredana_Madalina.Data
{
    public class Fanca_Loredana_MadalinaContext : DbContext
    {
        public Fanca_Loredana_MadalinaContext (DbContextOptions<Fanca_Loredana_MadalinaContext> options)
            : base(options)
        {
        }

        public DbSet<Fanca_Loredana_Madalina.Models.Candidati> Candidati { get; set; } = default!;
        public DbSet<Fanca_Loredana_Madalina.Models.ResurseUmane> ResurseUmane { get; set; } = default!;
        public DbSet<Fanca_Loredana_Madalina.Models.StudiiSuperioare> StudiiSuperioare { get; set; } = default!;
        public DbSet<Fanca_Loredana_Madalina.Models.Roluri> Roluri { get; set; } = default!;
    }
}
