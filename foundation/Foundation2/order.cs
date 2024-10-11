using System.ComponentModel.DataAnnotations;

public class Order
{
    private List<Product> _products;
    private Customer _customer; // Fixed this variable name

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost() // Added return type
    {
        decimal total = 0; // Fixed the colon
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }
        decimal shippingCost = _customer.IsUSA() ? 5 : 35; // Corrected method name to capital
        return total + shippingCost;
    }

    public string GetShippingLabel() // Added return type
    {
        return $"Shipping Label:\n{_customer.GetCustomerInfo()}";
    }

    public string GetPackingLabel()
    {
        var label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetProductInfo()}\n";
        }
        return label;
    }

}
