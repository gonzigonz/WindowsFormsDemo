using System;
using System.Linq;
using System.Windows.Forms;
using App.DataSets.Entities;
using App.LinqToSql;

namespace App.UI.Sources
{
   public class DataSourceLinq : IDataSource
   {
      private readonly DatabaseDataContext _context = new DatabaseDataContext();

      public object GetAllCategories()
      {
         return _context.LinqCategories;
      }

      public object GetProducts(int categoryId)
      {
         var query = _context.LinqProducts
            .Where(p => p.CategoryId == categoryId);
         return query;
      }

      public void DeleteProduct(BindingSource bindingSource, int productId)
      {
         throw new NotImplementedException();
      }

      public void AddProduct(BindingSource bindingSource, Product product)
      {
         throw new NotImplementedException();
      }

      public void Save()
      {
         throw new NotImplementedException();
      }

      public void SeedData()
      {
         throw new NotImplementedException();
      }
   }
}
