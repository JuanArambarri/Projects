namespace HelloWorld;
//Creating Car based on OOP section in Udemy
internal class Car
{
    /* fields are prefaced with "_"
     variables initiated outside of methods, are fields.
    */
    private string _model = "";
    private string _brand = ""; // Encapsulate field -> and use property. (Generate -> Property)
    
    //creating a Property, this should be the only way to edit _model & _brand
    public string Model
    {
        get => _model;
        set => _model = value ?? throw new ArgumentNullException(nameof(value));
    }
    public string Brand
    {
        get => _brand;
        set => _brand = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    
    //Constructor: No return type, same name as Class
    public Car(string model, string brand)
    {
        Model = model; //Change _model to Model in order to protect our variables.
        Brand = brand;
        Console.WriteLine($"Created {model} {brand} successfully.");
    }
}