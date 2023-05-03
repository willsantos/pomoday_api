using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoday.Repository.Context
{
    public class PomodayContext : DbContext
    {
        public PomodayContext(DbContextOptions<PomodayContext> options) : base(options) { }
    }
}
