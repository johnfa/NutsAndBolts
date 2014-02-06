using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutsAndBolts
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"input.txt");
            var listLenght = int.Parse(lines[0]);
            var list = new Dictionary<string, int>();        

            for (int i = 1; i < lines.Length; i++)
            {             
                var splitt = lines[i].Split(' ');
                var key = splitt[0];
                var value = int.Parse(splitt[1]);

                if (list.ContainsKey(key))
                {
                    var listValue = list[key];
                    if ((value - listValue) != 0)
                    {
                        var stringValue = (value - listValue).ToString("+#;-#");
                        Console.Write("{0} ",key);
                        Console.Write(stringValue);
                        Console.Write("\n");
                    }
                }
                else
                {
                    list.Add(key,value);

                }

            }
            Console.ReadLine();
        }
    }
}
