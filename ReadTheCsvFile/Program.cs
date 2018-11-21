using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTheCsvFile
{
    class Program
    {
        static void Main(string[] args)

        {
            StringBuilder csvfile = new StringBuilder();
            csvfile.AppendLine("Name, Age");
            csvfile.AppendLine("Raj,21");
            csvfile.AppendLine("Varma,21");
            string csvpath = "D:\\xyz.csv";
            File.AppendAllText(csvpath, csvfile.ToString());
            try
            {
                string st = File.ReadAllText("D:\\xyz.csv");
                Console.WriteLine(st);

            }
            catch(Exception e)
            {
                Console.WriteLine("the file is not found");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
