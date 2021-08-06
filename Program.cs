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
            Console.WriteLine("Enter Date Entered in Room.");
            string dateTime = Console.ReadLine();

            try 
            {
                if (roomNumber == "TD224") 
                {
                    Console.WriteLine("RoomNumber is correct!");
                }
                else
                {
                    throw new roomNumberException("RoomNumber is incorrect! Please enter the correct RoomNumber!");
                }

                DateTime parsedDate = DateTime.Parse(dateTime); 

                Console.WriteLine(String.Format("The room number is: {0}, and the current date and time is: {1}", roomNumber, dateTime));
            }
            catch (Exception ex)
            {
                if (ex is roomNumberException || ex is FormatException)
                Console.WriteLine(ex.Message);
            }
        }
    }
}