public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string address, string city, string stateProvince, string country)
    {
        _streetAddress = address;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public bool USA()
    {
        if (_country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        return _streetAddress + ", " + _city + ", " + _stateProvince + ", " +  _country + "\n";
    }
}