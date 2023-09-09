using System;

class Program {
  public static void Main (string[] args) 
  {

    //An array is a storage container object which can store data of ONLY ONE TYPE (specified at the time of creation)
    //An array has fixed size again specified during the creation of the array. This cannot be changed.
    //The first location in array is index location 0 e.g. names[0]
    
    //This will create a string array capable of storing 3 strings
    string [] users1D = new string[3];
    
    //This is one method of populating a string array
    users1D[0] = "Toby";
    users1D[1]="Gillian";
    users1D[2]= "Zach";
    Console.WriteLine("The contents of drawer 1[0] is " + users1D[2]);

    //This will create an int array capable of storing three ints
    int [] age = new int [3] {15,21,12};//This is an alternative method of populating an array

    Console.WriteLine("The age of the person at position [0] is " + age[0]);

    //This means I have two arrays storing different types of data about the each person
    //A better way would be to create a 2D array which acts like a spreadsheet

    string [,] users2D = new string[3,2];
    users2D[0,0] ="toby";
    users2D[0,1] = 15.ToString();
    users2D[1,0] = "Gillian";
    users2D[1,1] = 21.ToString();
    users2D[2,0] = "Zach";
    users2D[2,1] = 12.ToString();

    for(int i=0;i<users2D.GetLength(0);i++)
      {
        for(int j=0;j<users2D.GetLength(1);j++)
          {
            Console.Write(users2D[i,j]+",");
          }
        Console.WriteLine();
      }
    for(int i=0;i<users2D.GetLength(0);i++)
      {
        Console.WriteLine("Enter name");
        users2D[i,0] = Console.ReadLine();
        Console.WriteLine("Enter age");
        users2D[i,1] = Console.ReadLine().ToString();
      }

    for(int i=0;i<users2D.GetLength(0);i++)
      {
        for(int j=0;j<users2D.GetLength(1);j++)
      {
        Console.Write(users2D[i,j]+",");
      }
        Console.WriteLine();
      }
  }
}
