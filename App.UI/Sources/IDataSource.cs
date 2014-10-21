using App.DataSets.Entities;

namespace App.UI.Sources
{
    public interface IDataSource
    {
        object GetAllCategories();
        object GetProducts(int categoryId);
        bool DeleteProduct(int productId);
        bool AddProduct(Product product);
        void Save();
        void SeedData();
    }
}