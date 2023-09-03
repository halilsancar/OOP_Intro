using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cicek cicek1 =  new Cicek()
            {
                Renk = ConsoleColor.Magenta, 
                GovdeRengi = ConsoleColor.Yellow, 
                YaprakSayisi = 5
            };
            cicek1.Yazdir();

            Cicek cicek2 = new Cicek()
            {
                YaprakSayisi = 20,
                GovdeRengi = ConsoleColor.Green,
                Renk = ConsoleColor.Red
            };
            cicek2.Yazdir();
        }
    }
    
    class Cicek
    {
        public int YaprakSayisi { get; set; }
        public ConsoleColor Renk { get; set; }
        public ConsoleColor GovdeRengi { get; set; }
        public void Yazdir()
        {
            Console.WriteLine($"Renk : {Renk}\nGovde Rengi : {GovdeRengi}\nYaprak Sayısı :  {YaprakSayisi}");

            Console.ReadKey();
        }
    }
}
