using System;

namespace studentArrays
{
    class Program
    {
        static void Main(string[] args)
        {
           string userChoice = PickStudent("enter a student number to learn about them!");
            
        }
        
        public static string PickStudent(string message)
        {
            string[] students = {"Dexter", "Jon", "Creed", "Morty", "Rick"};

            Console.WriteLine(message);
            int userPick = int.Parse(Console.ReadLine());
            
            switch (userPick)
            {
                case 1:
                    Console.WriteLine($"Student 1: {students[0]}");
                    return students[0];
                case 2:
                    Console.WriteLine($"Student 2: {students[1]}");
                    return students[1];
                case 3:
                    Console.WriteLine($"Student 3: {students[2]}");
                    return students[2];
                case 4:
                    Console.WriteLine($"Student 4: {students[3]}");
                    return students[3];
                case 5:
                    Console.WriteLine($"Student 5: {students[4]}");
                    return students[4];
                default:
                   return PickStudent($"Choose another student number. ({userPick}) is out of range. ");
            }
        }



        public static bool Continue()
        {
            Console.WriteLine($"Press {'y'} to continue or any other key to exit. . .");

            if (Console.ReadKey(true).KeyChar == 'y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
