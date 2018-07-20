using Xunit;

namespace CatFactory.Tests
{
    public class NamingServiceTests
    {
        [Fact]
        public void TestSingular()
        {
            // Arrange
            var service = new NamingService();

            // Act and Assert
            Assert.True("Address" == service.Singularize("Addresses"));
            Assert.True("Category" == service.Singularize("Categories"));
            Assert.True("Customer" == service.Singularize("Customers"));
            Assert.True("City" == service.Singularize("Cities"));
            Assert.True("Company" == service.Singularize("Companies"));
            Assert.True("Country" == service.Singularize("Countries"));
            Assert.True("Currency" == service.Singularize("Currencies"));
            Assert.True("Enterprise" == service.Singularize("Enterprises"));
            Assert.True("Order" == service.Singularize("Orders"));
            Assert.True("Order Detail" == service.Singularize("Order Details"));
            Assert.True("OrderStatus" == service.Singularize("OrderStatus"));
            Assert.True("Product" == service.Singularize("Products"));
            Assert.True("Supplier" == service.Singularize("Suppliers"));

            Assert.True("OrderStatus" == service.Singularize("OrderStatuses"));
        }

        [Fact]
        public void TestPlural()
        {
            // Arrange
            var service = new NamingService();

            // Act and Assert
            Assert.True("Addresses" == service.Pluralize("Address"));
            Assert.True("Categories" == service.Pluralize("Category"));
            Assert.True("Customers" == service.Pluralize("Customer"));
            Assert.True("Cities" == service.Pluralize("City"));
            Assert.True("Companies" == service.Pluralize("Company"));
            Assert.True("Countries" == service.Pluralize("Country"));
            Assert.True("Enterprises" == service.Pluralize("Enterprise"));
            Assert.True("Orders" == service.Pluralize("Order"));
            Assert.True("Order Details" == service.Pluralize("Order Detail"));
            Assert.True("OrderStatuses" == service.Pluralize("OrderStatus"));
            Assert.True("Products" == service.Pluralize("Product"));
            Assert.True("Suppliers" == service.Pluralize("Supplier"));

            Assert.True("OrderStatuses" == service.Pluralize("OrderStatuses"));
            Assert.True("Products" == service.Pluralize("Products"));
        }
    }
}
