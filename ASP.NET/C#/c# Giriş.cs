using System;
using System.Globalization;

namespace consoleapp
{
      
    class Araba{
public String model { get; set; }

public int hp { get; set; }

public int number { get; set; }
      
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //************************| değişkenler |*********************************************
          int sayi=20;

          Console.WriteLine(sayi);
          // Console.WriteLine için cw yazıp tabla
          float a=20.5f;
          
          double b=10.4;

          long sayi3=50;

          short sayi4=25;

          byte sayi5=10;



          string name="sedat bilece";

          char ch= 'a';

          bool tut= true;


          System.Console.WriteLine(name);
          System.Console.WriteLine("*********************************************");
        //************************| değişken dönüşümleri |*********************************************

        string say1="10";

        string say2="20";

        int say3;
       say3 = int.Parse(say1) + int.Parse(say2);

        System.Console.WriteLine(say3);

        string str= say3.ToString();

        System.Console.WriteLine("str sayi: "+str);
 System.Console.WriteLine("*********************************************");



        //************************| veri tip dönüşüm uygulama |*********************************************

         System.Console.WriteLine("kenarları gir :"); 
        string e1= Console.ReadLine();
        string e2=Console.ReadLine();

        int inte1 = int.Parse(e1);
        int inte2= int.Parse(e2);

        int alan = inte1*inte2;

        int cevre= (inte1*2)+(inte2*2);

        System.Console.WriteLine("alan: "+alan+"\ncevre : "+cevre);

System.Console.WriteLine("*********************************************");
        //************************| string işlemleri |*********************************************
         

         string strad="My Name is Sedat and ı am 19 Years old";

         System.Console.WriteLine(strad.Length);//uzunluk 

         System.Console.WriteLine(strad.ToLower());//küçültme

         System.Console.WriteLine(strad.Trim());//baş ve sondaki boşlıkları siler

         System.Console.WriteLine(strad.Split()[2]); // boşlıklara böler

         System.Console.WriteLine(strad[3]); 
         
         System.Console.WriteLine(strad.EndsWith("1"));//sorgu

         System.Console.WriteLine(strad.StartsWith("My"));

         System.Console.WriteLine(strad.Contains("Sedat"));//verile  karakter varmı diye bakar

         System.Console.WriteLine(strad.IndexOf("and"));//index bulma
         
         System.Console.WriteLine(strad.Substring(5,15));//index aralığını getirir

         System.Console.WriteLine(strad.Replace(" ","_"));//değiştirir

         System.Console.WriteLine(strad.Insert(0,".... ::"));
         
System.Console.WriteLine("*********************************************");
        //************************| Diziler |*********************************************************

         string yazid="My Name is Sedat and ı am 19 Years old";

        var result=yazid.Split();// boşluklara göre böler dizi döndürür
        for(var i=0;i<result.Length;i++){
            System.Console.WriteLine(result[i]);
        }


        string[] isimler=new string[5];
   isimler[0]="sedat";
        System.Console.WriteLine("isimler : "+isimler[0]);

        
        int[] numaralar= new int[5];
  
        
         string num="asd";
string[] isimler2={"sedat","vedat","fatih"};

isimler2[0]="sedatb";//klasik atama

isimler2.SetValue("vedatb",1);//fonk ile atama

  System.Console.WriteLine(isimler2[0]);

        System.Console.WriteLine( Array.IndexOf(isimler2,"vedat") );//indexi verir
        
        


        System.Console.WriteLine("*********************************************");

        //************************|datetime |*********************************************************

        DateTime simdi= DateTime.Now;

        System.Console.WriteLine(simdi);

        System.Console.WriteLine(simdi.Year);
        System.Console.WriteLine(simdi.Month);
        System.Console.WriteLine(simdi.Day);
        System.Console.WriteLine(simdi.DayOfWeek);
        System.Console.WriteLine(simdi.Hour);
        System.Console.WriteLine(simdi.Minute);
        System.Console.WriteLine(simdi.DayOfYear);




         System.Console.WriteLine(simdi);

        CultureInfo culture = new CultureInfo("tr");//türkçe yapmak
        System.Console.WriteLine(simdi.ToString("F",culture));
        





        System.Console.WriteLine("*********************************************");
        //************************| if else ve döngüler |*********************************************************
 
         if(3>2){
             System.Console.WriteLine("3>2");
         }
         else if(3==2){
             System.Console.WriteLine("3=2");
         }
         else {
             System.Console.WriteLine("3<2");
         }


         var ay=12;

         switch(ay){
   
        case 12:

          System.Console.WriteLine("aralık"); 
          break;      
        case 1:
          System.Console.WriteLine("ocak");  
          break;     

        case 2:
        System.Console.WriteLine("subat");     
        break;  

        case 5:
          System.Console.WriteLine("mayıs"); 
          break;      

        case 6:
          System.Console.WriteLine("haz");  
          break; 
          
          default:
          System.Console.WriteLine("hiçbiri");
          break;


          




         }


        System.Console.WriteLine("*********************************************");
        //************************| CLASSLAR |*********************************************************

           Araba car1=new Araba();

           car1.model="reno";
           car1.hp=103;
           car1.number=110357;


           Araba car2= new Araba(){

            model="opel",
            hp=120,
            number=451107


           };

           Araba[] arabalar= new Araba[2];

           arabalar[0]=car1;
           arabalar[1]=car2;

           for(int i=0;i<2;i++){
System.Console.WriteLine($"model: {arabalar[i].model} hp: {arabalar[i].hp} number: {arabalar[i].number}");

           }
           System.Console.WriteLine("____");
          
          System.Console.WriteLine($"model: {car1.model} hp: {car1.hp} number: {car1.number}");

          System.Console.WriteLine($"model: {car2.model} hp: {car2.hp} number: {car2.number}");

             

             
        }//main end

    }//program class end

}//namespace end
