// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
public class customer
{
    private string _name;
    private Address _address;

    public customer(string name, Address address)
    {
        name = _name;
        address = _address;
    }

    private bool isUSA()
    {
        return Address.isUSA()
    }

    public void DisplayCustomer()
    {
        Console.WriteLine({_name}"\n"{_address})
    }

}