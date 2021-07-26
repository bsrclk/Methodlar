using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int float,double,decimal,bool=DEĞER TİP
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //sayi1=10
            //sayi2 = 30;
            //sonra sayi1=sayi2 olur ve 
            //sayi1=30
            //sayi2=30 oluyor sonra
            //sayi2=65 oluyor
            //sayi1=30 da kalıyor
            // değeri kopyalıyor ve bitiyor


            Console.WriteLine("*******************");


            //array,class,interface=REFERANS TİP
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; 
            sayilar2[0] = 999;
            //sayilar1 stackde yazdın sonra new dediğin anda heap e geçer [10,20,30] olur heap de
            //sayilar2 satckde yazdın sonra new dediğin anda heap e geçer [100,200,300] oluyor
            //sayilar1 in referans numarası=sayilar2 in referans numarasına eşittir
            //sayilar1 referans numarası 101 olsun
           //ayilar2 referans numarası 102 olsun
           //sayilar1 in ve sayilar2 inin 102 oldu
           //sonra sayilar2 nin 0. değeri 999 oldu ve otomatikmen sayilar1[0]elemanıda 999 değeri oldu
            //sonra 101 in değerleri çöpe atılacak çünkü onu tutan bir veri yok.

            Console.WriteLine(sayilar1[0]);

            //BELLEKTE STACK VE HEAP DİYE YER VAR 
            //BELLEKTE DEĞER TİPLER STACK DE GERÇEKLEŞŞİR 
            //BELLEKTE REFERANS TİPLER 


        }
    }
}
