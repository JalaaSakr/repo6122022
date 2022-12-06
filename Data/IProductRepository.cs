namespace CatalogLastApp.Data
{
    public interface IProductRepository
    {
        public Product Save(Product oproduct);
        public Product Update(Product oproduct);
        public Product Get(int productid);

        public List<Product> GetAll();
        public string Delete(int productid);



    }
}
