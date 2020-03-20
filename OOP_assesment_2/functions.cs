using System;
namespace OOP_assesment_2
{
    public class functions
    {

        public static void Compare(string txtA, string txtB, string txtAContent, string txtBContent)
        {
            //check if the files are the same
            if (txtAContent == txtBContent)
            {
                //change colour of writing to green
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{txtA} and {txtB} are not different");
            }

            else
            {
                //change colour of writing to red
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{txtA} and {txtB} are not the same");
               
            }

            //pause and clear console
            Console.ReadLine();
            Console.Clear();

            //change writing colour back to white
            Console.ForegroundColor = ConsoleColor.White;
            
        }
        
    }
}
