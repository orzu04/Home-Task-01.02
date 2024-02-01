


public class Computer {
    public int Ram { get; set; }
    public int Storage { get; set; }

public string Keyboard { get; set; }

public Computer (){}
public Computer(int ram, int storage,string keyboard)
{
     Ram = ram;
     Storage = storage;
     Keyboard = keyboard;
     
}

public void AddRam( )
{
 System.Console.WriteLine($"{Ram}");   
}
public void AddStorge()
{
    System.Console.WriteLine($"{Storage}");
}



}
