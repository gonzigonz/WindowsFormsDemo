using System;
using System.Configuration;
using System.Windows.Forms;
using App.Data;
using App.Data.Entities;

namespace App.UI
{
   public partial class Form1 : Form
   {
      // Avaliable data sources
      private ContextObject _sourceDataObject;
      private ContextDataSet _sourceDataDbSet;

      private IContext _currentSource;
      private Category _currentCategory;
      private readonly BindingSource _categoriesBindingSource = new BindingSource();
      private readonly BindingSource _productsBindingSource = new BindingSource();

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         // Init binding members
         if (toolStripCategoriesComboBox.ComboBox != null)
         {
            toolStripCategoriesComboBox.ComboBox.DisplayMember = "Name";
            toolStripCategoriesComboBox.ComboBox.ValueMember = "Id";
         }
         ProductsListBox.DisplayMember = "Name";
         ProductsListBox.ValueMember = "Id";

         // Set default Source Data to Object data
         toolStripSourceComboBox.SelectedIndex = 0;

         // Bind Product elements
         ProductsDataGridView.DataSource = _productsBindingSource;
         ProductsListBox.DataSource = _productsBindingSource;
         NameTextBox.DataBindings.Add("Text", _productsBindingSource, "Name");
         PriceTextBox.DataBindings.Add("Text", _productsBindingSource, "Price");
      }

      private void toolStripSourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         SetSource();
         BindCategories();
         BindProducts();
      }

      private void toolStripCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         BindProducts();
      }

      private void toolStripAddButton_Click(object sender, EventArgs e)
      {
         var addNewProductForm = new AddProductForm(_currentCategory);
         var result = addNewProductForm.ShowDialog();

         if (result == DialogResult.OK)
         {
            var model = addNewProductForm.Product;
            _currentSource.AddProduct(_productsBindingSource, model);
         }
      }

      private void toolStripDeleteButton_Click(object sender, EventArgs e)
      {
         var productId = (int) ProductsListBox.SelectedValue;
         _currentSource.DeleteProduct(_productsBindingSource, productId);
      }

      private void toolStripBackButton_Click(object sender, EventArgs e)
      {
         _productsBindingSource.MovePrevious();
      }

      private void toolStripNextButton_Click(object sender, EventArgs e)
      {
         _productsBindingSource.MoveNext();
      }

      private void SetSource()
      {
         switch (toolStripSourceComboBox.SelectedIndex)
         {
            case 0:
               if (_sourceDataObject == null)
               {
                  _sourceDataObject = new ContextObject();
               }
               _currentSource = _sourceDataObject;
               break;
            case 1:
               if (_sourceDataDbSet == null)
               {
                  _sourceDataDbSet = new ContextDataSet(GetConnectionString);
               }
               _currentSource = _sourceDataDbSet;
               break;
         }
      }

      private void BindCategories()
      {
         // Get Categories data
         _categoriesBindingSource.DataSource = _currentSource.GetAllCategories();
      }

      private void BindProducts()
      {
         // Get current Category ID
         if (toolStripCategoriesComboBox.ComboBox != null)
         {
            toolStripCategoriesComboBox.ComboBox.DataSource = _categoriesBindingSource;
            var id = toolStripCategoriesComboBox.ComboBox.SelectedValue;
            var name = toolStripCategoriesComboBox.Text;
            _currentCategory = new Category { Id = (int)id, Name = name };
         }

         // Get Products data
         _productsBindingSource.DataSource = _currentSource.GetProducts(_currentCategory.Id);
      }

      private static string GetConnectionString
      {
         get
         {
            //return ConfigurationManager.AppSettings["DatabaseSource"];
            return ConfigurationManager.ConnectionStrings["DatabaseSource"].ToString();
         }
      }

      private void SaveButton_Click(object sender, EventArgs e)
      {
         _currentSource.Save();
      }
   }
}
