using System;
using System.IO;

namespace OOP_assesment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //start program
            Menu();
        }

        static void Menu()
        {
            //menu system to either leave the program or compare files
            Console.WriteLine("What would you like to do?\n" +
                "(1) compare two files\n" +
                "(2) exit the program ");
            string menuOption = Console.ReadLine();

            
            if (menuOption == "1") //compare two files
            {
                //take in a location for fileA
                string fileA = CollectingFile();
                //read in content of fileA
                string fileAContent = Reader(fileA);

                //take in a location for fileB
                string fileB = CollectingFile();
                //read in content of fileB
                string fileBContent = Reader(fileB);

                //compare files A and B
                functions.Compare(fileA, fileB, fileAContent, fileBContent);
            }

            else if (menuOption == "2") //end program
            {
                //exit program
                Environment.Exit(0);
            }
            else //invalid option entered
            {
                //error message
                Errors.MenuError();
            }

            //loop menu system
            Menu();
            
        }

        static string CollectingFile()
        {
            //user inputs which file they would like to be read in
            Console.WriteLine("Enter the a file to be compared \n" +
                "(enter help if you would like to view which files can be compared):");
            string fileChosen = Console.ReadLine();

            //help function tells user which files are avalible
            if (fileChosen.ToLower() == "help")
            {
                fileChosen = Help();
            }
            return fileChosen;
        }

        //shows user which files are readable by the program
        static string Help()
        {
            Console.WriteLine("The files avaliable are: \n" +
                "> GitRepositories_1a.txt\n" +
                "> GitRepositories_1b.txt\n" +
                "> GitRepositories_2a.txt\n" +
                "> GitRepositories_2b.txt\n" +
                "> GitRepositories_3a.txt\n" +
                "> GitRepositories_3b.txt");

            //pasue program
            Console.ReadLine();

            //rerun Collecting file method
            string fileChosen = CollectingFile();
            return fileChosen;
        }

        static string Reader(string filename)
        {
            string txtFileContent = "";
            //tries to read in the content of the text file the user chose
            try
            {
                StreamReader file = new StreamReader(filename);
                txtFileContent = file.ReadToEnd();
                //Console.WriteLine(txtFileContent);
                //Console.ReadLine();
                
            }
            //if the file cannot be found output error message
            catch
            {
                Errors.FindingFileError();
                Menu();
            }
            //return the content that is read in
            return txtFileContent;
        }
    }
}
