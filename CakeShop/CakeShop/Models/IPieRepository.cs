using System.Collections.Generic;

namespace CakeShop.Models
{
    public interface IPieRepository
    {
        public IEnumerable<Pie> AllPies { get; }
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
        public Pie GetPieById(int pieId);
    }
}
