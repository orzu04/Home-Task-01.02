


public class Transport
{

    public int Id { get; set; }
    public string Model { get; set; }
    public string  Color { get; set; }

    public int Weight { get; set; }

    public Transport (int id, string model,string color,int weight)
    {
        Id = id;
        Model = model;
        Color = color;
        Weight = weight;
    }

    public void info()
    {
        System.Console.WriteLine($"{Id} {Model} {Color} {Weight}");
    }

}