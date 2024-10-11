public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsUSA() // Make this method public
    {
        return _address.isUSA();
    }

    public string GetCustomerInfo()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}
