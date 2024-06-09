namespace HelloWorld;

public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    
    //Custom contructor (multiple)
    public Customer(string name, string address, string contactNumber)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public Customer(string name)
    {
        Name = name;
    }
    // for default values, nothing passed
    public Customer()
    {
        Name = "DefaultName";
        Address = "No address";
        ContactNumber = "No contact number";
    }
}