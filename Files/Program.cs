using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  // must include this reference when implementing file handling


namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteToFile();

            //ReadAllLines();

            ReadCSVFile();
        }

        static void ReadCSVFile()
        {
            Console.WriteLine("\n Reading all lines from CSV file and printing each line to the console \n");

            StreamReader sr = new StreamReader(@"h:\playlist2017.txt");


            string lineIn; // will hold data that we read in

            string[] fieldArray = new string[3];

            int totalTime = 0;
            
            lineIn = sr.ReadLine(); // read in first line from file

            while (lineIn != null)
            {
                // split lineIn where there is a ','

                fieldArray = lineIn.Split(',');

                int songLength = int.Parse(fieldArray[2]);


                totalTime += songLength;

                Console.WriteLine(fieldArray[0]);

                lineIn = sr.ReadLine();


            }

            Console.WriteLine("Total playlist playing time = {0}",totalTime);

            Console.WriteLine("\nat end of file");

            sr.Close();
        }

        static void WriteToFile()
        {

            Console.WriteLine("\n Writing to file \n");

            // create a streamwriter object called sw (you can call it what you like), which allows us to write characters to a file
            // you can think of it as a pipe connecting our program to the file, which facilitates different operations

            
            StreamWriter sw = new StreamWriter(@"h:\myfile.txt"); 
            
            // note the @, this means the string is read verbatim (as is), escape chars are ignored
            // note also, that generally it is a bad idea to hard code the path of a file 
            // if you dont specify a path, the file will be placed in the Debug folder of your project


            // write three lines out to the file
            sw.WriteLine("Hello");
            sw.WriteLine("today is monday");
            sw.WriteLine("it is sunny");

            // close the connection to the file
            sw.Close();


        }

        static void ReadAllLines()
        {

            Console.WriteLine("\n Reading all lines from the file and printing each line to the console \n");

            StreamReader sr = new StreamReader(@"h:\myfile.txt");

            
            string lineIn; // will hold data that we read in

            lineIn = sr.ReadLine(); // read in first line from file

            
            while (lineIn != null) // null signals we are end of the file
            {
                Console.WriteLine(lineIn); // print to screen

                lineIn = sr.ReadLine(); // read in next line from file
            }

             sr.Close();

       }
    }
}
