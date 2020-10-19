using System;

namespace consoleapp6//Abstract
{
    abstract class Person{// abstract ( soyut sınıf )
        public String name;
        public int age;
        public int id;

        public Person(String name,int age,int id ){
            this.name=name;
            this.age=age;
            this.id=id;

        }

        public abstract void show();//abstract fonk classıda abstract olmalı

        public void write(){
            System.Console.WriteLine("person class write calling");
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

    class Teacher:Person{
public String branch;
        public Teacher(String name,int age,int id,String branch):base(name,age,id){
this.branch=branch;
        }
          public override void show(){
            System.Console.WriteLine($"name:{this.name} id:{this.id} school: {this.branch}");
           
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           
     //var p1=new Person("sedat",19,21); //soyut sınıftan nesne üretilmez
           var s1=new Student("vedat",18,72,"hadımkoy ilköğretim");
var t1=new Teacher("veli",40,000,"mat");
          // p1.show();
           s1.show();
           t1.show();
           s1.write();
System.Console.WriteLine("*************");

var peoples=new Person[2];

peoples[0]=t1;//teacher objesi
peoples[1]=s1;//student objesi
// persondan oluçtukları için aynı listede kullanılabilirler

foreach (var item in peoples)
{
    System.Console.WriteLine($"name:{item.name} id: {item.id}");
}

        }
    }
}
