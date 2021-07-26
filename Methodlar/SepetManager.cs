using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {//classlar da bir veritipidir.
       //naming convention
        public  void Ekle(Product urun)//sonda böyle bir parantez varsa sonda bilinki orda metot dönüyor
            //Ekle()parantez içine biz ne ekleriz seğete ürüm ekleriz ondan parantezden o ürüne ulaşabiliriz
        {
            Console.WriteLine("Sepete eklendi="+urun.Adi+urun.Fiyati," "+urun.Aciklama," "+urun.stokAdeti);//sen ekleyi çağırdığında bu bloğun hepsi gelir

        }
        public void Ekle2(string urunAdi,string Aciklama,double Fiyat,int stokAdeti)
        {
            Console.WriteLine("Sepete eklendi=" + urunAdi+Aciklama+Fiyat+stokAdeti);
        }
    }
}
