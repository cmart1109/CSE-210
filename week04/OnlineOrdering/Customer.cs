using System.Collections.Concurrent;

public class Customer
{
    private string _name;
    private Address _address;
    private string _country;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        _country = address.GetCountry();
    }
    public bool IsFromUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else {
            return false;
        }
    }
    public string GetCustomerInfo()
    {
        return $"{_name}, {_address.GetAddress()}";
    }
}