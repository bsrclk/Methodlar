using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class Product
    {//benim için bir ürünün ürün olması için o ürünün bir çok özelliğini barındırması lazım
      //claslarda sadece bir şeyi değilde bir çok özelliği içinde barındıran bir yapıdır
      //class oluşturmadan manuel olarak yaparsak herşeyi tek tek yazar bir de aarrylersek ürünleri sıralamayız.çünkü arry de sadece arry de string tutabiliriz int falan aynı anda tutamayız
      //classlarla iilgili 2 tane temel özellik var 1.özellik tutuyorlar
       //Property-özellik aşağıdakiler hepsi birer özellik
       //2.ise Manager.......,bunlar bir operasyon tutuyor.
        
        
        public int Id { get; set; }
        public string Adi { get; set; }

        public int Fiyati  { get; set; }

        public string Aciklama { get; set; }

        public int stokAdeti { get; set; }

    }
}
