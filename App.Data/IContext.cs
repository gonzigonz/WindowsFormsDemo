using System.Collections.Generic;
using System.Windows.Forms;
using App.Data.Entities;

namespace App.Data
{
    public interface IContext
    {
        object GetAllCategories();
        object GetProducts(int categoryId);
        void DeleteProduct(BindingSource bindingSource, Product product);
        void AddProduct(BindingSource bindingSource, Product product);
        void Save();
        void SeedData();
    }
}