using System.Reflection.Metadata.Ecma335;
using System;

namespace ExceptionTask
{   
        class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter roomNumber you have entered");
            string roomNumber = Console.ReadLine(); 
            Console.WriteLine("Please enter fullName");
            string fullName = Console.ReadLine(); 
            Console.WriteLine("Enter Date Entered in Room. In DD/MM/YY HH:MM");
            
            // DateTime dateEntered; 

            while (true) 
            {   
                try 
                {   
                    while (roomNumber == "TD224")
                    {
                        Console.WriteLine("RoomNumber is correct");
                    }
                }
                catch (System.FormatException)
                {
                    System.Console.WriteLine("Please enter the correct Room Number");
                }
                break;
            }

            while (true)
            {
                try 
                {
                    while (fullName == "John Doe")
                    {
                        Console.WriteLine("Fullname is correct");
                    }
                            
                }
                catch (System.FormatException)
                {
                    System.Console.WriteLine("Please enter the correct fullName entered into the room"); 
                }
                break;
            }

        }
    }
}