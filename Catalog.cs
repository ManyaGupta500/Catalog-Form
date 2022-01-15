using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment__4
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filepath = txtFilename.Text;
            DataStore.Load(filepath);
            dgvCatalog.DataSource = DataStore.Load(filepath);
        }

        private void chAutosave_CheckedChanged(object sender, EventArgs e)
        {
            string filepath = txtFilename.Text;
            Catalog catalog = new Catalog();
            _list = (List<Product>)dgvCatalog.DataSource;
            if (chAutosave.Checked)
                DataStore.Save(catalog, filepath);
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            using (Product productForm = new Product())
            {
                productForm.NewProduct += ProductForm_NewProduct;
            }
        }

        private void ProductForm_NewProduct(object sender, ProductEventArgs e)
        {
            var newProduct = e.NewProduct;
            _list.Add(newProduct);
            dgvCatalog.DataSource = null;
            dgvCatalog.DataSource = _list;
        }


        private List<Product> _list;
        private List<Product> filtered_list;
        public void Add(Product product)
        {
            _list.Add(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _list;
        }

        public IEnumerable<Product> GetProducts(string filter)
        {
            filtered_list = new List<Product>();
            foreach (Product product in _list)
            {
                if (product.Name.ToLower() == filter.ToLower())
                {
                    filtered_list.Add(product);
                }
            }
            return filtered_list;
        }

    }
}
