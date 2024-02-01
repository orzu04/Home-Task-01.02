



public class Laptop:Computer
{

public int Weight { get; set; }

public Laptop(int ram, int storage,string keyboard,int weight):base(ram,storage,keyboard)
{
    Weight=weight;
}

public void WeightChack()
{
    System.Console.WriteLine($"Ram:{Ram} Storage: {Storage} Weight: {Weight} ");
}

}