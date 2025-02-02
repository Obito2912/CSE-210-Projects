class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal AddShippingCostToOrder()
    {
        decimal total = 0;
        int usLocation = 5;
        int foreignLocation = 35;

        foreach (var product in _products)
        {
            total += product.TotalCost();
        }

        total += _customer.LivesInUs() ? usLocation : foreignLocation;

        return total;
    }

    public string PackingLabel()
    {
        string label = "\nOrder List:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} {product.GetProductId()}";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetAddress()}";
    }
}