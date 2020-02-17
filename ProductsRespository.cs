using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product.Entity;

namespace ProductsDetails.respository
{
    public class ProductsRespository
    {
        public static List<ProductData> productList = new List<ProductData>();
        static ProductsRespository()
        {
            productList.Add(new ProductData(1, "Shampoo",130, 11));
            productList.Add(new ProductData(2, "Knife",100 , 1));
            productList.Add(new ProductData(3, "Slipper",800, 2));
            productList.Add(new ProductData(4, "Bat", 3000, 3));

        }
        public IEnumerable<ProductData> GetProductDetails()
        {
            return productList;
        }
        public void AddProductDetails(ProductData productData)
        {
            productList.Add(productData);
        }
        public ProductData GetProductId(int ProductId)
        {
            return productList.Find(id => id.ProductId == ProductId);
        
        }
        public void DeleteProduct(int ProductId)
        {
            ProductData productDataList = GetProductId(ProductId);
            if (productDataList != null)
                productList.Remove(productDataList);
        }

    }
}
