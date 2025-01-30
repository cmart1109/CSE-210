public class Customer
{
    private string _name;
    private Address _address;

    private bool _isFromUsa;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        _isFromUsa = IsFromUSA(_address);
    }
    public bool IsFromUSA(Address address)
    {
        string country = address.GetCountry();
        if (country == "USA")
        {
            Console.WriteLine("This Costumer is from the United States");
            return true;
        }
        else {
            Console.WriteLine("This Costumer is not from the USA");
            return false;
        }
    }
}