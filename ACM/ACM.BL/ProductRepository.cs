using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        //Retrieves one product by Id
        public Product Retrieve(int productId)
        {
            var prod = new Product();
            if (productId == 2)
            {
                prod.ProductName = "Sunflowers";
                prod.ProductDescription = "4 bright mini yellow sunflowers";
                prod.CurrentPrice = 20.25M;
            }
            return prod;
        }


        //Saves the current Product
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if(product.IsNew)
                    {
                        //Call an Insert Stored Procedure
                    }
                    else
                    {
                        //Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
