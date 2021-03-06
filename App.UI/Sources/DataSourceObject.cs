﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using App.DataSets.Entities;

namespace App.UI.Sources
{
   public class DataSourceObject : IDataSource
   {
      private readonly List<Category> _categories;
      private readonly List<Product> _products;

      public DataSourceObject()
      {
         _categories = new List<Category>();
         _products = new List<Product>();

         SeedData();
      }

      public object GetAllCategories()
      {
         return _categories;
      }

      public object GetProducts(int categoryId)
      {
         return _products.Where(p => p.CategoryId == categoryId).ToList();
      }

      public bool DeleteProduct(int productId)
      {
         const bool rebindRequired = true;
         var product = _products.FirstOrDefault(p => p.Id == productId);
         if (product != null)
         {
            //bindingSource.Remove(product);
            _products.Remove(product);
         }
         return rebindRequired;
      }

      public bool AddProduct(Product product)
      {
         const bool rebindRequired = true;
         var nextId = _products.Max(p => p.Id) + 1;
         product.Id = nextId;
         //bindingSource.Add(product);
         _products.Add(product);
         return rebindRequired;
      }

      public void Save()
      {
         //Nothing to do yet
      }

      public void SeedData()
      {
         _categories.Add(new Category { Id = 1, Name = "Beverages" });
         _categories.Add(new Category { Id = 2, Name = "Condiments" });
         _categories.Add(new Category { Id = 3, Name = "Dairy" });

         _products.Add(new Product { Id = 1, CategoryId = 1, Name = "Coke", Price = 3.50m });
         _products.Add(new Product { Id = 2, CategoryId = 1, Name = "Pepsi", Price = 3.40m });
         _products.Add(new Product { Id = 3, CategoryId = 2, Name = "Ketchup", Price = 2.70m });
         _products.Add(new Product { Id = 4, CategoryId = 2, Name = "Mustard", Price = 2.50m });
         _products.Add(new Product { Id = 5, CategoryId = 3, Name = "Full Milk", Price = 1.50m });
         _products.Add(new Product { Id = 6, CategoryId = 3, Name = "Skim Milk", Price = 1.60m });
      }
   }
}
