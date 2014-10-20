using System;
using System.Windows.Forms;
using App.Data;
using App.Data.Entities;

namespace App.UI
{
    public partial class Form1 : Form
    {
        private ContextObject _source;
        private readonly BindingSource _categoriesBindingSource = new BindingSource();
        private readonly BindingSource _productsBidBindingSource = new BindingSource();

        private Category _currentCategory;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _source = new ContextObject();
            _categoriesBindingSource.DataSource = _source.GetAllCategories();

            toolStripCategoriesComboBox.ComboBox.DisplayMember = "Name";
            toolStripCategoriesComboBox.ComboBox.ValueMember = "Id";
            toolStripCategoriesComboBox.ComboBox.DataSource = _categoriesBindingSource;

            ProductsDataGridView.DataSource = _productsBidBindingSource;
            ProductsListBox.DataSource = _productsBidBindingSource;
            ProductsListBox.DisplayMember = "Name";
            NameTextBox.DataBindings.Add("Text", _productsBidBindingSource, "Name");
            PriceTextBox.DataBindings.Add("Text", _productsBidBindingSource, "Price");
        }

        private void toolStripCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCategory = (Category) toolStripCategoriesComboBox.SelectedItem;
            _productsBidBindingSource.DataSource = _source.GetProducts(_currentCategory.Id);
        }

        private void toolStripAddButton_Click(object sender, EventArgs e)
        {
            var addNewProductForm = new AddProductForm(_currentCategory);
            var result = addNewProductForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                //_source.AddProduct(addNewProductForm.Product);
                _productsBidBindingSource.Add(addNewProductForm.Product);
            }
        }

        private void toolStripDeleteButton_Click(object sender, EventArgs e)
        {
            var model = (Product) ProductsListBox.SelectedItem;
            //_source.DeleteProduct(model);
            _productsBidBindingSource.Remove(model);
        }

        private void toolStripBackButton_Click(object sender, EventArgs e)
        {
            _productsBidBindingSource.MovePrevious();
        }

        private void toolStripNextButton_Click(object sender, EventArgs e)
        {
            _productsBidBindingSource.MoveNext();
        }

    }
}
