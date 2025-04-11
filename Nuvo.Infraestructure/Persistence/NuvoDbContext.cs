using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuvo.Infraestructure.Persistence
{
    public class NuvoDbContext : DbContext
    {

        DbSet<Domain.Entities.Usuario> Usuarios { get; set; }
    }
}
