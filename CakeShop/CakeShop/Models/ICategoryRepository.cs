using System.Collections.Generic;

namespace CakeShop.Models
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> AllCategories { get; }

    }
}
