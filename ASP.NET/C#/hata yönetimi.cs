using System;

namespace consoleapp8//exception
{
    class Program

    {
        static void Main(string[] args)
        {
           
      


          try
          {
                System.Console.WriteLine("sayı gir:");
           int sayi=int.Parse(Console.ReadLine());
//Unhandled exception. System.FormatException


          }
          catch (System.Exception ex)
          {
              System.Console.WriteLine(ex.Message);
              System.Console.WriteLine(ex.TargetSite);
              System.Console.WriteLine("************");
              throw;
          }
          finally{
              System.Console.WriteLine(" ------> finaly çalıçtı");
          }
System.Console.WriteLine("----------------------------------------------------");


     var parola="asd123";
int kar=0;
    for (int i=0;i<parola.Length;i++){

         for (int z=0;z<10;z++){
        var a=parola[i];
        if(true){
            kar++;
        }

         }


    }





        }
    }
}
