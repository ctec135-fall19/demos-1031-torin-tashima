using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Linq;
using static System.Console;

namespace ReadAndQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Loading an XML doc");

            XDocument myDoc = XDocument.Load("Inventory.xml");
            WriteLine(myDoc);
            WriteLine();

            var result = from car in myDoc.Descendants("Car")
                         where ((string)car.Attribute("ID")).Equals("2")
                         select car;

            foreach (var car in result)
            {
                WriteLine(car);
            }
        }
    }
}
