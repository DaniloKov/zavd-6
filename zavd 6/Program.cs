using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zavd_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число яке для прикладу ви хочете записати на файл");
            string x = Console.ReadLine();
            File.WriteAllText("D:\\ExampleFile.txt",x);
            using (FileStream fstream = File.OpenRead("D:\\ExampleFile.txt"))
            {
          
                byte[] array = new byte[fstream.Length];
              
                fstream.Read(array, 0, array.Length);
             
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                int m = Convert.ToInt32(textFromFile);
                
                if (m >= 1 * Math.Pow(10, 10000)) { Console.WriteLine("Число занадто велике"); }
                else
                {
                    Console.WriteLine($"В файлi мiститься число - {textFromFile}");
                    Console.WriteLine("До якого степеня ви бажаєте пiднести число яке мiститься в файлi");
                    int step = int.Parse(Console.ReadLine());
                    Console.WriteLine("Отримане числе - " + Math.Pow(m, step));
                }
            }
            File.Delete( "D:\\ExampleFile.txt" );
            Console.WriteLine("Файл приклад був видалений");
            Console.ReadLine();

        }
    }
}
