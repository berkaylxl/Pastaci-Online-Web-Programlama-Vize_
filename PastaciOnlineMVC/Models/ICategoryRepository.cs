using System.Linq;

namespace PastaciOnlineMVC.Models
{
    public interface ICategoryRepository
    {
        IQueryable<Category> Categories { get; }
    }
}
