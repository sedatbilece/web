using System;

namespace consoleapp2 //class uygulaması
{

    class Product{
//prop yazıp tablayarak kolayca oluşturur
       public String name;
       public int price;
       public String description;


       public int getprice(){//nesne function

           return this.price;
       }

    }//class product end


    class Islem{

        public Islem(int max){//constructor adı class ile aynı olmalı 

this.max=max;
        }

        public int max { get; set; }
        public int sayi { get; set; }

        public int topla(int x,int y){

            return x+y;
        }

        public int belirsiztopla(params int[] num){
           
           int top=0;
            foreach (var item in num)
            {
           top+=item;
            }

return top;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
//************************* islem classı
            var islem1=new Islem(10);

            System.Console.WriteLine(islem1.topla(8,9) + islem1.max);

            System.Console.WriteLine(islem1.belirsiztopla(10,20,3));

//*************************  Product classı hazır atama
            var nesne1=new Product{name="sedat",price=1000,description="none"};//böylede tanımlanabilir
           
             System.Console.WriteLine($"name :{nesne1.name} fiyat: {nesne1.price} desc: {nesne1.description}");

//*************************  Product classı sonradan atama
System.Console.WriteLine($"nesne1 price: {nesne1.getprice()}");
        System.Console.WriteLine("kaç eleman eklenecek");
        int adet=int.Parse(Console.ReadLine());

        Product[] ürünler =new Product[adet];
Product prd;
int i=0;

       while(i<adet){
   prd=new Product();

   System.Console.WriteLine("ürün adı");
   prd.name= Console.ReadLine();
   System.Console.WriteLine("ürün fiyatı");
   prd.price=int.Parse(Console.ReadLine());
   System.Console.WriteLine("ürün açıklaması");
   prd.description=Console.ReadLine();
   
   ürünler[i]=prd;
   i=i+1;

       }//while(i<adet) end 


System.Console.WriteLine(ürünler.Length);

       for(int z=0;z<ürünler.Length;z++){

           System.Console.WriteLine($"name :{ürünler[z].name} fiyat: {ürünler[z].price} desc: {ürünler[z].description}");


       }

    

        }
    }


}
