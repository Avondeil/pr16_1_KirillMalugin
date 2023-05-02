using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt16Algoritmzad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Введите элементы массива с использованием (/): ");
            string[] text = Console.ReadLine().Split('/');
            foreach (string str in text)
            {
                foreach (char numb in str)
                {
                    if (char.IsDigit(numb)) { count++; }
                }
            }
            Console.WriteLine($"Кол-во цифр в массиве: {count}");
            Console.WriteLine($"Элементы массива до символа (/): ");
            foreach (string str in text)
            {
                if (str == "/")
                {
                    break;
                }
                if (str != "") 
                { 
                    Console.WriteLine(str); 
                }
            }
            Console.WriteLine($"Элементы массива после символа (/) в верхнем и нижнем регистрах:");
            foreach (string str in text)
            {
                string info = "";
                if (str == "/") { continue; }
                if (str == "") { break; }
                foreach (char znak in str)
                {
                    if (Char.IsUpper(znak))
                    {
                        info += Char.ToLower(znak);
                    }
                    else if (Char.IsLower(znak))
                    {
                        info += Char.ToUpper(znak);
                    }
                    else { info += znak; }
                }
                Console.WriteLine(info);
                StreamWriter st = new StreamWriter("file.txt", true);
                st.WriteLine(info);
                st.Close();
            }
            Console.WriteLine("Измененный массив был записан в файл");
            Console.ReadKey();
        }
    }
}
