using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using App.Data.Entities;

namespace App.Data
{
    public class ContextDataSet : IContext
    {
        private readonly DataSet _dataSet;

        public ContextDataSet(string connectionString)
        {
            _dataSet = new DataSet();
            var connection = new SqlConnection(connectionString);

            // Extract data
            var categoriesDataAdapter = new SqlDataAdapter("Select * From dbo.Categories", connection);
            categoriesDataAdapter.Fill(_dataSet, "Categories");

            var productsDataAdapter = new SqlDataAdapter("Select * From dbo.Products", connection);
            productsDataAdapter.Fill(_dataSet, "Products");
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

        public void DeleteProduct(BindingSource bindingSource, Product product)
        {
            throw new System.NotImplementedException();
        }

        public void AddProduct(BindingSource bindingSource, Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void SeedData()
        {
            throw new System.NotImplementedException();
        }
    }
}
