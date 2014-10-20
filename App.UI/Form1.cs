using System;
using System.Windows.Forms;
using App.Data;
using App.Data.Entities;

namespace App.UI
{
    public partial class Form1 : Form
    {
        private readonly ContextObject _source;
        private Category _currentCategory;

        public Form1()
        {
            _source = new ContextObject();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripCategoriesComboBox.ComboBox.DisplayMember = "Name";
            toolStripCategoriesComboBox.ComboBox.ValueMember = "Id";
            toolStripCategoriesComboBox.ComboBox.DataSource = _source.GetAllCategories();
        }

        private void toolStripCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCategory = (Category) toolStripCategoriesComboBox.SelectedItem;
            
            var products = _source.GetProducts(_currentCategory.Id);

            ProductsDataGridView.DataSource = products;
            ProductsListBox.DataSource = products;
            ProductsListBox.DisplayMember = "Name";

            NameTextBox.DataBindings.Clear();
            PriceTextBox.DataBindings.Clear();
            NameTextBox.DataBindings.Add("Text", products, "Name");
            PriceTextBox.DataBindings.Add("Text", products, "Price");
        }

        private void toolStripAddButton_Click(object sender, EventArgs e)
        {
            var addNewProductForm = new AddProductForm(_currentCategory);
            var result = addNewProductForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _source.AddProduct(addNewProductForm.Product);
            }
        }

        private void toolStripDeleteButton_Click(object sender, EventArgs e)
        {
            var model = (Product) ProductsListBox.SelectedItem;
            _source.DeleteProduct(model);
        }

    }
}
