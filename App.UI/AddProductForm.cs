using System;
using System.Windows.Forms;
using App.DataSets.Entities;

namespace App.UI
{
    public partial class AddProductForm : Form
    {
        private readonly Category _category;

        public AddProductForm(Category category)
        {
            InitializeComponent();

            _category = category;
            CategoryTextBox.Text = _category.Name;
        }

        public Product Product
        {
            get
            {
                var model = new Product
                {
                    Id = 0,
                    Name = NameTextBox.Text,
                    Price = Convert.ToDecimal(PriceTextBox.Text),
                    CategoryId = _category.Id
                };

                return model;
            }
        }
    }
}
