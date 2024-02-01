
public class Car:Transport
{
    public string DrivarName { get; set; }


    public Car(int id, string model,string color,int weight,string drivarname):base (id,model,color,weight)
    {
        DrivarName = drivarname;
    }

    public void CarInfo()
    {
        System.Console.WriteLine($" Id: {Id} Model: {Model} Color: {Color} Weight: {Weight} DrivarName: {DrivarName}");
    }
}

