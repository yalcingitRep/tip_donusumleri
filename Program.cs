using System;
using System.Security.Cryptography.X509Certificates;

namespace tip_donusumleri{
    class Program{
        public static void Main(string[] args){
            //Implicit Conversion 
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine(d);
            long h = d;
            Console.WriteLine(h);
            float f = h;
            Console.WriteLine(f);

            string st = "hello";
            char ch = 'c';
            object o = st + ch + d;

            //Explicit Conversion 
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine(y);
            int z = 100;
            byte t = (byte)z;
            Console.WriteLine(t);

            float fl = 10.3f;
            byte bt = (byte)fl;

            Console.WriteLine(bt);

            //ToString Metodu

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy);

            //System.Convert

            string s1 = "10",s2 = "20";
            int sayi1, sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);

            //Parse

            ParsMethod();

            

        }
        public static void ParsMethod(){
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double dobule1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine(rakam1);
            dobule1 = Double.Parse(metin2);
            Console.WriteLine(dobule1);
      }
    }
}