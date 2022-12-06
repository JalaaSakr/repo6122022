using CatalogLastApp.Data;
using Microsoft.IdentityModel.Tokens;
//using ProductCatalogApp.CatalogContext;

namespace ProductCatalogApp.Repository
{
    public class ProductRepository : IProductRepository
    {
        ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        string IProductRepository.Delete(int productid)
        {
            var product = _context.Products.FirstOrDefault(x => x.Product_ID == productid);
            _context.Products.Remove(product);
            _context.SaveChanges();

            return "Deleted";
        }

        Product IProductRepository.Get(int productid)
        {
            if (_context.Products.Where(x => x.Product_ID == productid).Count() > 0)
                return _context.Products.FirstOrDefault(x => x.Product_ID == productid);
            else
                return null;
        }

        List<Product> IProductRepository.GetAll()
        {
            if (_context.Products.Count() > 0)
                return _context.Products.ToList();
            else return null;
        }

        Product IProductRepository.Save(Product oproduct)
        {
            if (!_context.Products.Any(x => x.Product_ID.Equals(oproduct.Product_ID)))
            {
                _context.Products.Add(oproduct);
                _context.SaveChanges();
                return oproduct;
            }
            else
                return null;
        }

        Product IProductRepository.Update(Product oproduct)
        {
            if (!_context.Products.Any(x => x.Product_ID.Equals(oproduct.Product_ID)))
            {
                _context.Products.Update(oproduct);
                _context.SaveChanges();
                return oproduct;
            }
            else return null;
        }
    }
}
