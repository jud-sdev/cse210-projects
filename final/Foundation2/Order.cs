public class Order {
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer) {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product) {
        _products.Add(product);
    }

    public double CalculateTotalCost() {
        double totalCost = 0;
        foreach (var product in _products) {
            totalCost += product.GetTotalCost();
        }

        totalCost += _customer.LivesInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GeneratePackingLabel() {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products) {
            packingLabel += $"{product.GetName()} - ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GenerateShippingLabel() {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer: {_customer.GetName()}\n";
        shippingLabel += $"Address:\n{_customer.GetAddress().GetFormattedAddress()}";
        return shippingLabel;
    }
}