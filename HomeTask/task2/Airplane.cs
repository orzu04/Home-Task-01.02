



public class Airplane:Transport{

public int IdStuardesses { get; set; }

public Airplane(int id, string model,string color,int weight,int idStuardesses ):base (id,model,color,weight)
{
    IdStuardesses = idStuardesses;
}


public void AirGet(){
     
     System.Console.WriteLine($" Id: {Id} Model: {Model} Color: {Color} Weight: {Weight}IdStuardesses: {IdStuardesses}");
}


}



