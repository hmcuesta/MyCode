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
            while ((line = sr.ReadLine()) != null)
            {
                line = line.ToUpper();
                var palabras = line.Split(' ').ToList().Where(str => (str.StartsWith("P") && str.EndsWith("R")) || 
                                           (str.StartsWith("H") && str.Contains("O"))).ToList();

                palabras.ForEach(s => line = line.Replace(s.Trim(), new String('#', s.Count())));
            
                Console.WriteLine(line);
                sw.WriteLine(line);
            }

            Console.ReadKey();

        }
    }
}
