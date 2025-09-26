using System.ComponentModel.Design.Serialization;
using System.Dynamic;
using System.Runtime.InteropServices;

public class Order
{
    private List<Product> _products = [];
    private Customer _customer;

    public void SetName(string name)
    {
        _customer = new Customer(name);

    }
    public void SetAddress(string address, string city, string stateProvince, string country)
    {
        _customer.SetAddress(address, city, stateProvince, country);
    }

    public void AddProduct(string name, int ID, double price, int quantity)
    {
        _products.Add(new Product(name, ID, price, quantity));
    }
    public List<double> CalculateOrderCost()
    {
        List<double> cost = [0, 0];
        foreach (Product product in _products)
        {
            cost[0] += product.TotalProductCost();
        }

        bool usa = _customer.USA();
        if (usa == true)
        {
            cost[1] = 5;
        }
        else
            cost[1] = 35;
        return cost;
    }

    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetName() + "," + product.GetID() + "," + product.GetPrice() + "," + product.GetQuantity() + ";";
        }
        packingLabel = packingLabel.Remove(packingLabel.Length - 1);
        return packingLabel;
    }
    public string ShippingLabel()
    {
        return _customer.GetName() + ";" + _customer.GetAddress();
    }
}