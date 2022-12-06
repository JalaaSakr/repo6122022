namespace CatalogLastApp.Data
{
    public interface ICategoryRepository
    {

        public Category Save(Category ocategory);
        public Category Update(Category ocategory);
        public Category Get(int categoryid);

        public List<Category> GetAll();
        public string Delete(int categoryid);
    }
}
