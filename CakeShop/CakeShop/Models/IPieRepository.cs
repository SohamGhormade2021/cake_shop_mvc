using System.Collections.Generic;

namespace CakeShop.Models
{
    public interface IPieRepository
    {
        public IEnumerable<Pie> AllPies { get; }
        public IEnumerable<Pie> PiesOfTheWeek { get;}
        public Pie GetPieById(int pieId);
    }
}
