using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticTaskIndividual
{
    public class Program
    {
        public static List<int> list = new List<int>(100);
        public static void fillcollection()
        {
            Random ran = new Random();
            for(int i = 0 ; i < 101; i++)
            {
                list.Add(ran.Next(0,100));
            }
            Console.WriteLine(string.Join(Environment.NewLine, list));
        }
        public static List<int> deletenumbers(List<int>list)
        {
            int start = 25;
            int end = 50;
            int count = end - start; 
            if (list.Count == 0)
            {
                for (int i = 0; i <= 100;i++)
                {
                    list.Add((int)i);
                    if(list.Count== 100)
                    {
                        for(int i2 = 0; i2 < list.Count;i2++)
                        {
                            if (list[i2]>25 || list[i2]<50)
                            {
                                list.Remove(i2);
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > 25 || list[i] < 50)
                    {
                        list.Remove(i);
                    }
                }
                
            }
           return list;
        }
        public static void showlist()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Пустой лист");
            }
            else
            {
                foreach (var numbers in list)
                {
                    Console.WriteLine(numbers.ToString());
                }
            }
        }
        public static void clearlist()
        {
            list.Clear();
            Console.WriteLine("Список пуст");
        }
        public static void Main(string[] args)
        {
            bool check = true;
            while(check)
            {
                Console.WriteLine("Выберите \n 1 - чтобы заполнить лист случайными числами и вывести на экран \n 2 - чтобы удалить числа из листа, которые больше 25, но меньше 50 и вывести на экран \n 3 - вывести список на экран \n 4 - выход \n 5 - очистить консоль \n 6 - очистить список");
                string num = Console.ReadLine();
                if(num == "1")
                {
                    fillcollection();
                    Console.WriteLine();
                }
                else if(num == "2")
                {
                    deletenumbers(list);
                }
                else if (num == "3")
                {
                    showlist();
                }
                else if(num == "4")
                {
                    check=false;
                }
                else if(num == "5")
                {
                    Console.Clear();
                }
                else if(num == "6")
                {
                    clearlist();
                }
                else
                {
                    Console.WriteLine("Неверно введены данные");
                }
            }
        }
    }
}
