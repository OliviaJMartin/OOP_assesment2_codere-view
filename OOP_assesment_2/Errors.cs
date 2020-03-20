using System;
namespace OOP_assesment_2
{
    public class Errors
    {
        //outputting appropriate error messages
        public static void MenuError()
        {
            Console.WriteLine("Invalid Option given. \n" +
                "Please try again:");
            Console.ReadLine();
            Console.Clear();
        }
        public static void FindingFileError()
        {
            Console.WriteLine("Cannot find file that you have entered. \n" +
                "Please try again:");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
