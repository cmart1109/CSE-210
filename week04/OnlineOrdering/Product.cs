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
        _totalCost = _price * _quantity; 
    }
    public double GetTotalCost()
    {
        _totalCost = _price * _quantity; 
        return _totalCost;
    }
    public string DisplayInfo()
    {
        return $"{_name}, id:{_productId}, solo price:{_price}$, {_quantity} units, total: {_totalCost}$";
    }
}