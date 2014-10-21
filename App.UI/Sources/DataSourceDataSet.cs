using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using App.DataSets.Entities;

namespace App.UI.Sources
{
   public class DataSourceDataSet : IDataSource
   {
      private readonly string _connectionString;
      private readonly DataSet _dataSet;
      private readonly SqlDataAdapter _categoriesAdapter;
      private readonly SqlDataAdapter _productsAdapter;
      private int _nextId = int.MaxValue;
      

      public DataSourceDataSet(string connectionString)
      {
         _connectionString = connectionString;
         _dataSet = new DataSet();
         _categoriesAdapter = new SqlDataAdapter("Select * From dbo.Categories", _connectionString);
         _productsAdapter = new SqlDataAdapter("Select * From dbo.Products", _connectionString);

         Initialise();
      }

      private void Initialise()
      {
         // Setup data adapters
         new SqlCommandBuilder(_categoriesAdapter);
         new SqlCommandBuilder(_productsAdapter);

         // Extract data and load into dataset
         _categoriesAdapter.Fill(_dataSet, "Categories");
         _productsAdapter.Fill(_dataSet, "Products");
      }

      public object GetAllCategories()
      {
         return _dataSet.Tables["Categories"];
      }

      public Object GetProducts(int categoryId)
      {
         var table = _dataSet.Tables["Products"];
         table.DefaultView.RowFilter = "CategoryId = " + categoryId;
         return table;
      }

      public bool DeleteProduct(int productId)
      {
         const bool rebindRequired = false;

         var table = _dataSet.Tables["Products"];
         var query = table.AsEnumerable()
            .Where(r=>(int)r["Id"] == productId);
         var row = query.Single();

         if (row.RowState != DataRowState.Deleted)
         {
            row.Delete();
         }

         return rebindRequired;
      }

      public bool AddProduct(Product product)
      {
         const bool rebindRequired = false;

         var table = _dataSet.Tables["Products"];
         var row = table.NewRow();
         _nextId -= 1;

         row["Id"] = _nextId;
         row["Name"] = product.Name;
         row["Price"] = product.Price;
         row["CategoryId"] = product.CategoryId;

         table.Rows.Add(row);

         return rebindRequired;
      }

      public void Save()
      {
         var connection = new SqlConnection(_connectionString);
         using (connection)
         {
            connection.Open();
            _productsAdapter.Update(_dataSet, "Products");
         }
      }

      public void SeedData()
      {
         throw new System.NotImplementedException();
      }
   }
}
