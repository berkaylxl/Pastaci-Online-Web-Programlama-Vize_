using System.Linq;

namespace PastaciOnlineMVC.Models
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly  PastaciDbContext _pastaciDbContext;
        public EFCategoryRepository(PastaciDbContext context)
        {
            _pastaciDbContext = context;
        }
        public IQueryable<Category> Categories => _pastaciDbContext.Categories;
    }
}
