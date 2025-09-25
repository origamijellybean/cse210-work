using System.Runtime.CompilerServices;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name)
    {
        _name = name;
    }

    public void SetAddress(string address, string city, string stateProvince, string country)
    {
        _address = new Address(address, city, stateProvince, country);
    }
    public bool USA()
    {
        return _address.USA();
    }

    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
    
}