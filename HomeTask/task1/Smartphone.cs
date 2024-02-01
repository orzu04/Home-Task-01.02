


public class Smartphone:Computer {

public int NumberOfSelfies { get; set; }

public Smartphone (int ram, int storage,string keyboard,int numberOfSelfies ): base(ram,storage,keyboard)
{
    NumberOfSelfies=numberOfSelfies;
}


public void TakeSelfies (){
    
 
   System.Console.WriteLine($"Ram:{Ram} Storage: {Storage} NumberOfSelfies:{NumberOfSelfies}");
}

}