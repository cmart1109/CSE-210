public class Address 
{
    private string _streetAdress;
    private string _city;
    private string _state;
    private string _country;
    public string GetAddress()
    {
        return $"{_streetAdress}, City of {_city}, State of {_state}, in {_country}";
    }
    public string GetCountry()
    {
        return $"{_country}";
    }

    public Address(string streetAdress,string city,string state,string country)
    {
        _streetAdress = streetAdress;
        _city = city;
        _state = state;
        _country = country;
    }

}