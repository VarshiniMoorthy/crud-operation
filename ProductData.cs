using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entity
{
    public class ProductData
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public ProductData(int id, string name, float price, int quantity)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.ProductPrice = price;
            this.ProductQuantity = quantity;
        }
        public ProductData()
        {

        }
        public ProductData(ProductData productData)
        {
            this.ProductId = productData.ProductId;
            this.ProductName = productData.ProductName;
            this.ProductPrice = productData.ProductPrice;
            this.ProductQuantity = productData.ProductQuantity;
        }
    }
}
