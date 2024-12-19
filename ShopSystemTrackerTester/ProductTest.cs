using ShopSystemTrackerLib; 
using Xunit;

namespace ShopSystemTrackerTester
{
    public class ProductTest
    {
        [Fact]
        public void CanCreateASampleProduct()
        {
            // Name	Description	Price	Quantity	Category
            string productName = "Milk";
            string productDescription = "1 gallon, whole milk";
            double productPrice = 3.99;
            int productQuantity = 10;
            string productCategory = "Dairy";

            // Act
            Product product = new Product(productName, productDescription, productPrice, productQuantity, productCategory);

            // Assert
            Assert.Equal(productName, product.Name);
            Assert.Equal(productDescription, product.Description);
            Assert.Equal(productPrice, product.Price);
            Assert.Equal(productQuantity, product.Quantity);
            Assert.Equal(productCategory, product.Category);
        }
    }
}
