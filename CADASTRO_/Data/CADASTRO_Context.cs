using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CADASTRO_.Models;

namespace CADASTRO_.Data
{
    public class CADASTRO_Context : DbContext
    {
        public CADASTRO_Context (DbContextOptions<CADASTRO_Context> options)
            : base(options)
        {
        }

        public DbSet<CADASTRO_.Models.Pessoa> Pessoa { get; set; } = default!;
    }
}
