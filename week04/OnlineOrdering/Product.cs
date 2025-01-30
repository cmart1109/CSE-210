public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;
    private double _totalCost;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }
    public double GetTotalCost(double price, int quantity)
    {
        _totalCost = price * quantity; 
        return _totalCost;
    }
    public string DisplayInfo()
    {
        return $"{_name}, {_quantity} units, total: {_totalCost}";
    }
}