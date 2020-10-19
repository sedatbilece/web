using System;

namespace consoleapp5//kalıtım
{
    class Person{
        public String name;
        public int age;
        public int id;

        public Person(String name,int age,int id ){
            this.name=name;
            this.age=age;
            this.id=id;

        }

        public virtual void show(){
            System.Console.WriteLine($"name:{this.name} id:{this.id}");
        }

    }

    class Student:Person{
   public String school;
 public Student(String name,int age,int id,String school):base(name,age,id){
     this.school=school;
 }
          
            public override void show(){
            System.Console.WriteLine($"name:{this.name} id:{this.id} school: {this.school}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
    var p1=new Person("sedat",19,21);
           var s1=new Student("vedat",18,72,"hadımkoy ilköğretim");

           p1.show();
           s1.show();
        }
    }
}
