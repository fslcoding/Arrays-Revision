using System;

class Program 

{
   //A static variable created outside the main method cab be accessed anywhere in the class. This is a global variable which means it can be accessed in both the main method and static methods which exists outside the main method
  //(a) Creates a 2D array capable of storing the USERNAME and PASSWORD of 3 users.
  static string [,] array2D = new string[3,2];

  //Main method
  static void Main (string[] args)
  {
    //(b) Populates the 2D array with username and passwords of three fictional users.
    //Nested for loop used to populate 2D array
    for(int i =0;i<array2D.GetLength(0);i++)
      for(int j = 0;j<array2D.GetLength(1);j++)
      {
        //This will populate the username column in each row
        if(j==0)
          {
            Console.WriteLine("Please enter the username:");
            array2D[i,0] = Console.ReadLine();
          }
        //This will populate the password column in each row
        if(j==1)
          {
              Console.WriteLine("Please enter the password:");
              array2D[i,1] = Console.ReadLine();
          }
      }
//(c) Prints out the contents of the 2D array.
for(int i=0;i<array2D.GetLength(0);i++)
  {
    for(int j=0;j<array2D.GetLength(1);j++)
    {
      Console.Write(array2D[i,j]+",");//Print a row
    }
    Console.WriteLine();//Takes a new line after print a row
  }
//(d) Checks the 2D array to determine if a particular user exists in the array.
  bool found = false;
  Console.WriteLine("Enter the username you are searching for");
  string username = Console.ReadLine();
  for(int k=0;k<array2D.GetLength(0);k++)
    {
      if(array2D[k,0]==username)
        {
          found = true;
          break;
        }
    }
  if(found)//Same as if(found==true)
  {
    Console.WriteLine("The user " + username + " was found.");
  }

  else
  {
    Console.WriteLine("The user " + username + " was not found.");
  }

  //(e) Create a login method - method static void login (string username, string password)
  Console.WriteLine("Please enter your username");
  username=Console.ReadLine();//This string has already been created above
  
  Console.WriteLine("Please enter your password");
  string password=Console.ReadLine();

  login(username,password);

  }

  //This method can be called in the main method
  static void login (string username, string password)
  {
    for(int i=0;i<array2D.GetLength(0);i++)
    {
      if(array2D[i,0]==username)//If username stored in this row matches username entered
        if(array2D[i,1]==password)//If username stored in this row matches password entered
        {
          Console.WriteLine("You have successfully logged into the program");
          break;//This ensures the loop doesnt continue to run after the username and password have been correctly entered
        }
        else
        {
          Console.WriteLine("Your password is not recognised");
        }
      else
      {
          Console.WriteLine("Your username is not recognised");
      }
    }
      Console.WriteLine("The end of the program");
      }
    }
  
