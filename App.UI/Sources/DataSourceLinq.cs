using System;
using System.Linq;
using System.Windows.Forms;
using App.DataSets.Entities;
using App.LinqToSql;

namespace App.UI.Sources
{
   public class DataSourceLinq : IDataSource
   {

      public object GetAllCategories()
      {
         using (var context = new DatabaseDataContext())
         {
            return context.LinqCategories.ToList();
         }
      }

      public object GetProducts(int categoryId)
      {
         using (var context = new DatabaseDataContext())
         {
            var query = context.LinqProducts
               .Where(p => p.CategoryId == categoryId);
            return query.ToList();
         }
      }

      public bool DeleteProduct(int productId)
      {
         var rebindRequired = false;
         using (var context = new DatabaseDataContext())
         {
            var entity = context.LinqProducts
               .FirstOrDefault(p => p.Id == productId);

            if (entity != null)
            {
               context.LinqProducts.DeleteOnSubmit(entity);
               Save(context);
               rebindRequired = true;
            }
         }
         return rebindRequired;
      }

      public bool AddProduct(Product product)
      {
         const bool rebindRequired = true;
         using (var context = new DatabaseDataContext())
         {
            var linqProduct = new LinqProduct
            {
               Id = product.Id,
               Name = product.Name,
               Price = product.Price,
               CategoryId = product.CategoryId
            };

            context.LinqProducts.InsertOnSubmit(linqProduct);
            Save(context);
         }
         return rebindRequired;
      }

      public void Save()
      {
         using (var context = new DatabaseDataContext())
         {
            Save(context);
         }
      }

      private void Save(DatabaseDataContext context)
      {
         try
         {
            using (context)
            {
               context.SubmitChanges();
            }
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message);
            throw new Exception(e.Message, e.InnerException);
         }
         
      }

      public void SeedData()
      {
         throw new NotImplementedException();
      }
   }
}
