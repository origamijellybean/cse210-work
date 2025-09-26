public class Product
{
    private string _name;
    private int _ID;
    private double _price;
    private int _quantity;

    public Product(string name, int ID, double price, int quantity)
    {
        _name = name;
        _ID = ID;
        _price = price;
        _quantity = quantity;
    }
    public double TotalProductCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetID()
    {
        return _ID;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}