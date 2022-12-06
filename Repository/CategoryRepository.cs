using CatalogLastApp.Data;
//using ProductCatalogApp.CatalogContext;

namespace ProductCatalogApp.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        string ICategoryRepository.Delete(int categoryid)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Category_ID == categoryid);
            _context.Categories.Remove(category);
            _context.SaveChanges();

            return "Deleted";
        }

        Category ICategoryRepository.Get(int categoryid)
        {
            return _context.Categories.FirstOrDefault(x => x.Category_ID == categoryid);
        }

        List<Category> ICategoryRepository.GetAll()
        {
            return _context.Categories.ToList();
        }

        Category ICategoryRepository.Save(Category ocategory)
        {
            if (!_context.Categories.Any(x => x.Category_ID.Equals(ocategory.Category_ID)))
            {
                _context.Categories.Add(ocategory);
                _context.SaveChanges();
                return ocategory;
            }
            else
                return null;
        }

        Category ICategoryRepository.Update(Category ocategory)
        {
            if (!_context.Categories.Any(x => x.Category_ID.Equals(ocategory.Category_ID)))
            {
                _context.Categories.Update(ocategory);
                _context.SaveChanges();
                return ocategory;
            }
            else return null;
        }
    }
}
