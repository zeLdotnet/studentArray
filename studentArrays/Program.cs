using System;

namespace studentArrays
{
    class Program 
    {
        static void Main(string[] args)
        {
           string userChoice = PickStudent("enter a student number to learn about them!");
           string studentInfo = GetStudentInfo(userChoice);
           Console.WriteLine(studentInfo);
            
        }
        
        public static string PickStudent(string message)
        {
            string[] students = {"Dexter", "Jon", "Creed", "Morty", "Rick"};

            Console.WriteLine(message);
            int userPick = int.Parse(Console.ReadLine());
            
            switch (userPick)
            {
                case 1:
                    Console.WriteLine($"\nStudent 1: {students[0]}\n");
                    return students[0];
                case 2:
                    Console.WriteLine($"\nStudent 2: {students[1]}\n");
                    return students[1];
                case 3:
                    Console.WriteLine($"\nStudent 3: {students[2]}\n");
                    return students[2];
                case 4:
                    Console.WriteLine($"\nStudent 4: {students[3]}\n");
                    return students[3];
                case 5:
                    Console.WriteLine($"\nStudent 5: {students[4]}\n");
                    return students[4];
                default:
                   return PickStudent($"\nChoose another student number. ({userPick}) is out of range. ");
            }
        }

        public static string GetStudentInfo(string student)
        {

            if(student == "Dexter")
            {
                Console.WriteLine($"\nWhat would you like to know about {student}?");
                Console.Write($"enter [1. Hobbies] or [2. Hometown]\t");

                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        return "\nDexter's hobby is boating.";
                    case 2:
                        return "\nDexter's hometown is Miami, Florida";
                    default:
                        return GetStudentInfo(student);                         
                }
                
            }
            else if (student == "Jon")
            {
                Console.WriteLine($"\nWhat would you like to know about {student}?");
                Console.Write($"enter [1. Hobbies] or [2. Hometown]\t");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        return "\nJon's hobby is sword fighting.";
                    case 2:
                        return "\nJon's hometown is Winterfell";
                    default:
                        return GetStudentInfo(student);
                }
            }
            else if (student == "Creed")
            {
                Console.WriteLine($"\nWhat would you like to know about {student}?");
                Console.Write($"enter [1. Hobbies] or [2. Hometown]\t");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        return "\nCreed's hobby is selling office supplies on eBay.";
                    case 2:
                        return "\nCreed's hometown is Scranton, Pennsylvania";
                    default:
                        return GetStudentInfo(student);
                }
            }
            else if (student == "Morty")
            {
                Console.WriteLine($"\nWhat would you like to know about {student}?");
                Console.Write($"enter [1. Hobbies] or [2. Hometown]\t");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        return "\nMorty's hobby involves a computer... yeah.";
                    case 2:
                        return "\nMorty's hometown is Earth, C137.";
                    default:
                        return GetStudentInfo(student);
                }
            }
            else if (student == "Rick")
            {
                Console.WriteLine($"\nWhat would you like to know about {student}?");
                Console.Write($"enter [1. Hobbies] or [2. Hometown]\t");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        return "\nRick's hobby is inventing things and dimension hopping.";
                    case 2:
                        return "\nRick's hometown is Earth, C137.";
                    default:
                        return GetStudentInfo(student);
                }
            }
            else
            {
                return GetStudentInfo("enter a valid student!");
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
