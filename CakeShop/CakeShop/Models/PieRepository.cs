using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Models
{
    public class PieRepository:IPieRepository
    {
        private readonly AppDbContext appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies => appDbContext.Pies.Include(c=>c.Category);

        public IEnumerable<Pie> PiesOfTheWeek { get => 
                appDbContext.Pies.Include(c => c.Category).Where(p=>p.IsPieOfTheWeek);  }

        public Pie GetPieById(int pieId)
        {
            return appDbContext.Pies.First(p=>p.PieId == pieId);
        }
    }
}
