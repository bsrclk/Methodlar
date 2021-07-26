using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //metotlar tekrar tekrar kullanılabirliği sağlayan kodlardır.

            string UrunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };//burada sadece stringleri yerleştirebilirsin

            Console.WriteLine("**********************************");


            Product Urun1 = new Product();//STOK TAKİP SİSTEMİ
            //bir class tanımlamak için bu hareketi yapmak gerekiyor.
            //string urunadi gibi bir değişken tanımlarken bu yapılır classlarda

            
            Urun1.Adi = "Elma";
            Urun1.Fiyati = 15;
            Urun1.Aciklama = "Amasya elması";
            Urun1.stokAdeti = 13;

            Product Urun2 = new Product();

            
            Urun2.Adi = "karpuz";
            Urun2.Fiyati = 35;
            Urun2.Aciklama = "Diyarbakır karpuzu";
            Urun2.stokAdeti = 10;


            Product[] urunler = new Product[] { Urun1, Urun2 };

            foreach (Product urun in urunler)// foreach (var item in collection)
                
            {
             
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdeti);
                Console.WriteLine("******************************");
            }

            Console.WriteLine("*******************Metotlar*************");
            //instance-class örneği oluşturmak
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Urun1);//paramtersei artık Product oldu sende parantez içine yazman lazım
            sepetManager.Ekle(Urun2);

            Console.WriteLine("******************");
            //encapsulation yani manuel olarak yazdın sen ekle2 de ama sayfalrın patladı ama gidip ekle de public oluşturarak yaptık ve sayfada sıkıntı çıkmadı stokAdetinde
            sepetManager.Ekle2("Armut", "Yeşil", 12,4);
            sepetManager.Ekle2("Elma", "Yeşil", 14,10);
            sepetManager.Ekle2("Karpuz", "Kırmızı", 12,15);
            //dont repeat yourself-clean code- best practice
        }
    }
}
