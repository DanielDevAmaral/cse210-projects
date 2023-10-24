using Microsoft.VisualBasic;

class Product
{
    private string _name;
    private int _productID;
    private int _quantity;
    private double _price;

    public Product (string nameoftheProduct, int id, int quantity, double price)
    {
        _name = nameoftheProduct;
        _productID = id;
        _quantity = quantity;
        _price = price;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetID()
    {
        return _productID;
    }
    public double TotalPrice()
    {
        return _quantity * _price;
    }

}