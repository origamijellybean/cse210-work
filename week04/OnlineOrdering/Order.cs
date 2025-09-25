using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order()
    {

    }

    public float CalculateOrderCost(Customer customer)
    {
        float cost = 0;
        foreach (Product product in _products)
        {
            cost += product.TotalProductCost();
        }

        bool usa = customer.USA();
        if (usa == true)
        {
            cost += 5;
        }
        else cost += 35;
        return cost;
    }

    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetName() + "," + product.GetID() + ";";
        }
        return packingLabel;
    }
    //needs to return label as string
    public string ShippingLabel()
    {
        return _customer.GetName() + ";" + _customer.GetAddress();
    }
}