using System;

class Program {
  public static void Main (string[] args) 
  {
    Console.WriteLine ("This is an array of strings");

    //Arrays store data of one type
    //Arrays can be multi-dimensional
    //Arrays are fixed in sizeof
    
    //1D array
    string [] names = new string[4];

    //2D array
    string[,] student = new string[3,3];

    //Populating an array

    names[0] = "jason";
    names[1] = "james";
    names[2] = "alton";
    names[3] = "daniel";

    for(int jason= 0;jason<names.Length;jason++)
    {
      Console.WriteLine("Enetr a name");
      names[jason] = Console.ReadLine();
    }

        for(int jason= 0;jason<names.Length;jason++)
    {
        Console.WriteLine("Name: "+names[jason]);
    }
    
  }
}
