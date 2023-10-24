class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private Address _address;
    private int _packingLabel;
    private int _shippingLabel;
    private double test;

    public double TotalCost() //totalPrice
    {
        foreach(Product item in _products)
        {
            test += item.TotalPrice();
        }
        return test;
    }

    public int Shipping()
    {
        if (_address.IsInAmerica() == true)
        {
            _shippingLabel = 5;
        }
        else
        {
            _shippingLabel = 35;
        }
        return _shippingLabel;
    }

    public string PackingLabel()
    {
        foreach(Product itens in _products)
        {
            return $"Label\n Name: {itens.GetName()} Id: {itens.GetID()}";
        }
        
    }
    public string ShippingLabel()
    {
        return $"Shipping Label\n Name:{_customer.GetName()} Address: {_customer.GetAddress()}";
    }

    public void Display()
    {
        Console.WriteLine(PackingLabel());
        Console.WriteLine(ShippingLabel());


    }











}