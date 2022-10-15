using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] harfler = { 'a','e','ı','i','o','ö','u','ü'};
            string metin;
            Console.Write("Metin giriniz: ");
            metin = Console.ReadLine();
            ArrayList liste = new ArrayList();
            for (int i = 0; i < harfler.Length; i++)
            {
                for (int j = 0; j < metin.Length; j++)
                {
                    if (metin[j] == harfler[i])
                        liste.Add(harfler[i]);
                }
            }
            foreach (var item in liste)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
