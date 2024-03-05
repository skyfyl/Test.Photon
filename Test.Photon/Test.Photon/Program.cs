using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Photon.Plugin.Properties;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Test.Photon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"value1: {Settings.Default.Value1}");
            Console.WriteLine($"value2: {Settings.Default.Value2}");
            Console.WriteLine($"value1: {ConfigurationManager.AppSettings["Value1"]}");
            Console.WriteLine($"value2: {ConfigurationManager.AppSettings["Value2"]}");
            Photon.Plugin.Photon.Run();
            Console.ReadKey();
        }
    }
}
