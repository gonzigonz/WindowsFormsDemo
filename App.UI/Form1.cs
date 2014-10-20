using System;
using System.Windows.Forms;
using App.Data;

namespace App.UI
{
    public partial class Form1 : Form
    {
        private readonly ContextObject _source;

        public Form1()
        {
            _source = new ContextObject();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoriesComboBox.DataSource = _source.GetAllCategories();
            CategoriesComboBox.DisplayMember = "Name";
        }

    }
}
