using System.Reflection.Metadata.Ecma335;
using System;

namespace ExceptionTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program myProgram = new Program();
        }


        public void getUserDetails()
        {
            User_One person = new User_One();

            Console.WriteLine("1. Enter the room you are attending.");
            person.RoomNum = Console.ReadLine(); 
            Console.WriteLine("2. Enter your name.");
            person.Name = Console.ReadLine();
            Console.WriteLine("3. Enter the date you attended the room.");
            person.DateTime = Console.ReadLine();
            Console.WriteLine("4. Enter the time stayed inside the room");
            person.TimeStayed = Console.ReadLine();
            Console.WriteLine("Checked in details of User One");
            Console.WriteLine(person.Name + " " + "entered" + " " + person.RoomNum + "on this" + person.DateTime+ "and stayed for" + person.TimeStayed);
        }
    }
}
