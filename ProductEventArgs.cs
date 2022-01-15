using System;

namespace Assignment__4
{
    public class ProductEventArgs : EventArgs
    {
        public Product NewProduct { get; }

        public ProductEventArgs(Product product)
        {
            NewProduct = product;
        }

    }
}
