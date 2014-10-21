using System.Windows.Forms;
using App.DataSets.Entities;

namespace App.UI.Sources
{
    public interface IDataSource
    {
        object GetAllCategories();
        object GetProducts(int categoryId);
        void DeleteProduct(BindingSource bindingSource, int productId);
        void AddProduct(BindingSource bindingSource, Product product);
        void Save();
        void SeedData();
    }
}