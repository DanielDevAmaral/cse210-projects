class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address addres)
    {
        _name = name;
        _address = addres;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.Gathering();
    }
        public bool IsInAmerica()
    {
        if (_address.GetCoutry() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}