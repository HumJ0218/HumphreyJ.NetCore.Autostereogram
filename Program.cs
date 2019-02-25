using System;
using System.Linq;

namespace HumphreyJ.NetCore.Autostereogram.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var pattern = new char[][] {
                new char[8].Select(m=>(char)(random.Next(64)+35)).ToArray(),
                new char[8].Select(m=>(char)(random.Next(64)+35)).ToArray(),
                new char[8].Select(m=>(char)(random.Next(64)+35)).ToArray(),
                new char[8].Select(m=>(char)(random.Next(64)+35)).ToArray(),
                new char[8].Select(m=>(char)(random.Next(64)+35)).ToArray(),
                new char[8].Select(m=>(char)(random.Next(64)+35)).ToArray(),
                new char[8].Select(m=>(char)(random.Next(64)+35)).ToArray(),
                new char[8].Select(m=>(char)(random.Next(64)+35)).ToArray(),
                new char[8].Select(m=>(char)(random.Next(64)+35)).ToArray(),
                new char[8].Select(m=>(char)(random.Next(64)+35)).ToArray(),
            };
            var map = new int[][] {
                "0000000000000000".Select(m=>int.Parse(m+"")).ToArray(),
                "0011111111111100".Select(m=>int.Parse(m+"")).ToArray(),
                "0001111111111000".Select(m=>int.Parse(m+"")).ToArray(),
                "0000111111110000".Select(m=>int.Parse(m+"")).ToArray(),
                "0000011111100000".Select(m=>int.Parse(m+"")).ToArray(),
                "0000001111000000".Select(m=>int.Parse(m+"")).ToArray(),
                "0000000110000000".Select(m=>int.Parse(m+"")).ToArray(),
                "0000001111000000".Select(m=>int.Parse(m+"")).ToArray(),
                "0000011111100000".Select(m=>int.Parse(m+"")).ToArray(),
                "0000111111110000".Select(m=>int.Parse(m+"")).ToArray(),
                "0001111111111000".Select(m=>int.Parse(m+"")).ToArray(),
                "0011111111111100".Select(m=>int.Parse(m+"")).ToArray(),
                "0000000000000000".Select(m=>int.Parse(m+"")).ToArray(),
            };

            Console.WriteLine();
            var asg = new Autostereogram<char>(pattern, map);
            asg.Photogram.ToList().ForEach(m =>
            {
                Console.WriteLine("  " + string.Join("", m));
            });
            Console.WriteLine();

        }
    }
}