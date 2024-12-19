using System.Xml.Linq;

namespace ShopSystemTrackerLib
{
    public class Product : IProduct
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }
        public string Category { get; private set; }

        public Product(string productName, string productDescription, double productPrice,
            int productQuantity, string productCategory)
        {
            Name = productName;
            Description = productDescription;
            Price = productPrice;
            Quantity = productQuantity;
            Category = productCategory;
        }
    }

}
