using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string alph = "abcdefghijklmnopqrstuvwxyz";

            using StreamReader sr = new StreamReader(@"E:\.net\ConsoleApp1\ConsoleApp1\Input.txt");
            using StreamWriter sw = new StreamWriter(@"E:\.net\ConsoleApp1\ConsoleApp1\Output.txt");

            string str;

            int count=0;
 
            while ((str = sr.ReadLine()) != null)
            {
                string outInfo = "";

                foreach (var i in str)
                {
                    for (int j = 0; j <= count - (alph.Length - 1); j++)
                    {
                        outInfo += "0";
                    }
                    if (i == '1')
                    {
                        if (count > alph.Length - 1)
                        {
                                         
                            outInfo += alph[alph.Length - 1];

                        }
                        else
                            outInfo += alph[count];
                        count = 0;
                    }
                    else
                        count++;
                }
                Console.WriteLine(outInfo);
                sw.WriteLine(outInfo);
            }
        }      

    }
    
}

