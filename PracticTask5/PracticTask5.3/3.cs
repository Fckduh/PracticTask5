using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PracticTask5._3
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            HashSet<string> repeats = new HashSet<string>();
            Addnum(repeats);
        }
        public static HashSet<string>Addnum(HashSet<string> repeats)
        {
            bool check = true;
            while(check)
            {
                Console.WriteLine("Введите число");
                string num = Console.ReadLine();
                if (num == "")
                    break;
                if (repeats.Contains(num))
                {
                    Console.WriteLine("Такое число уже существует");
                }
                else
                    Console.WriteLine("Число успешно добавлено");
                    repeats.Add(num);
            }
            return repeats;
        }
    }
}
