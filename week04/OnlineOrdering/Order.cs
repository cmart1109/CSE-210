using System.Runtime.Serialization;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer; 
    private double _totalCost;
    private double _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
        
    }
    public string GetShippingLabel()
    {
        return _customer.GetCustomerInfo();

    }
    public void GetPackingLabel()
    {
        foreach (var product in _products)
        {
            Console.WriteLine(product.DisplayInfo());
            double productCost = product.GetTotalCost();
            _totalCost += productCost;
        }
    }
    public void GetShippingCost()
    {
        if (_customer.IsFromUSA() == true)
        {
            _shippingCost += 5;
        }
        else {
            _shippingCost += 35;
        }
    }
    public double GetGrandTotal()
    {
        return _totalCost + _shippingCost;
    }
}