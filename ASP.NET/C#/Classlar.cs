using System;

namespace consoleapp4
{
    
    class Student {

        public int id { get; set; }
        public  String name { get; set; }

        public static String schoolname="hadimköy ilkokulu";//static üye herkes için aynı
        public Student(int id,String name){
            System.Console.WriteLine("student objesi oluşturuldu");
            this.id=id;
            this.name=name;
        }


        public void shownameid(){//her persondan türetilen obje kullanabilir
            System.Console.WriteLine($" shownameid ||| name: {this.name} id: {this.id}");
        }

        public virtual void showeverything(){//bu sadece personda dahil olanları yazdırır
                System.Console.WriteLine($" showeverything ||| name: {this.name} id: {this.id}");
        }
    }

    class Studentleader : Student {//kalıtım yapıyoruz studentden

     public String lead;
     

        public Studentleader(int id,String name,String lead):base(id,name){
            // :base ile ana sınıfa istenenler gönderilir

System.Console.WriteLine("studentleader objesi oluşturuldu");
            this.lead=lead;


           
        }


    }
        class Program
    {
        static void Main(string[] args)
        {
           
           var s1=new Student(101,"sedat");

           s1.shownameid();
           
           System.Console.WriteLine($"name: {s1.name} id: {s1.id} school: {Student.schoolname}");

var s2= new Studentleader(102,"vedat","baş");

s2.shownameid();

System.Console.WriteLine($"name: {s2.name} id: {s2.id} school: {Student.schoolname} lead: {s2.lead}");

        }
    }
}
