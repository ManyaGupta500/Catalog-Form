using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment__4
{
    public partial class Product : Form
    {
        public event EventHandler<ProductEventArgs> NewProduct;

        public Product()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            newProduct.Name = txtName.Text;

            NewProduct.Invoke(this, new ProductEventArgs(newProduct));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Department Department { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
