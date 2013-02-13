using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SG
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\imagenes\\datos.in");
            StreamWriter sw = new StreamWriter("C:\\imagenes\\datos.out");
            string line;
            List<string> arr = new List<string>();
           
            while ((line = sr.ReadLine()) != null)
            {
                line = line.ToUpper();
                arr = line.Split(' ').ToList();
                var wrd = arr.Where(str => (str.StartsWith("P") && str.EndsWith("R")) || 
                                           (str.StartsWith("H") && str.Contains("O")))
                                           .Select(str => str).ToList();

                wrd.ForEach(s => line = line.Replace(s.Trim(), new String('#', s.Count())));
            
                Console.WriteLine(line);
                sw.WriteLine(line);
            }

            Console.ReadKey();

        }
    }
}
