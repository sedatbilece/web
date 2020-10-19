using System;

namespace consoleapp7//Interface
{
interface IInsan{

    int age{get;set;}

}

    interface IPerson{
        string name{get;set;}
        
      
        int id{get;set;}

        void bilgi();
    }

    class Yönetici : IPerson,IInsan//BİR classa birden fazla interface eklenebilir
    //sorun çıkarsa ctrl+. ile arabirimi uygula
    {
     

    public Yönetici(string name,int id,string departman){
        this.name=name;
        this.id=id;
        this.departman=departman;
    }
        public string departman;
        public string name {get;set;}
       
        public int id {get;set;}
        public int age {get;set;}

        public void bilgi()
        {
            System.Console.WriteLine($"name: {this.name }  id: {this.id} depart: {this.departman}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            var y=new Yönetici("sedat",101,"bilişim");

            y.bilgi();
            
        }
    }
}
