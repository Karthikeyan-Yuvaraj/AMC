using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMC.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productid)
        {
            var product = new Product(productid);

            if (productid == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted ";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    // call an insert stored proc
                    //Pizza
                }
                else
                {
                    // Call an update stored proc
                }
            }
            return success;
        }
    }
}
