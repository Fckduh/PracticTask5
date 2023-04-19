using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticTask5._2
{
    public class Program
    {
        
        
        
        public static void Main(string[] args)
        {
            Dictionary<string, string> phonebook= new Dictionary<string, string>();
            phonebook = Addphone(phonebook);
            findowner(phonebook);
        }
        public static Dictionary<string,string>Addphone(Dictionary<string,string> phonebook)
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine($"Введите номер телефона ");
                string key = Console.ReadLine();
                if(key == "")
                {
                    break;
                }
                Console.WriteLine("Введите Ф.И.О владельца номера телефона ");
                string value = Console.ReadLine();
                phonebook.Add(key, value) ;
            }
                return phonebook;
        }
        public static void findowner(Dictionary<string, string> phonebook)
        {
            string findow = "";
            bool check = true;
            while (check)
            {
                Console.WriteLine("Введите номер телефона владельца для его поиска");
                string checkowner = Console.ReadLine();
                if (checkowner == "")
                {
                    break;
                }
                if (phonebook.TryGetValue(checkowner, out findow))
                {
                    Console.WriteLine($"У телефона {checkowner} владелец {findow}");
                }
                else
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }
        }
    }
}
