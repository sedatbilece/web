using System;

namespace consoleapp3
{
    class Question{

        public String text;
        public String[] choices;
        public String answer;

        public Question(String text, String[] choices,String answer){
       this.text=text;
       this.choices=choices;
       this.answer=answer;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
var soru1=new Question("en iyi programlama dili",new String[]{"c#","java","python","swift"},"c#");

var soru2=new Question("en popüler programlama dili",new String[]{"c#","java","python","swift"},"python");

var soru3=new Question("en yaygın programlama dili",new String[]{"c#","java","python","swift"},"java");

var sorular=new Question[]{soru1,soru2,soru3};




for (int i=0;i<sorular.Length;i++){

    System.Console.WriteLine(sorular[i].text);
    foreach (var item in sorular[i].choices)
    {
        System.Console.WriteLine(item);
    }

    System.Console.WriteLine("cevap gir: ");
    String cevap= Console.ReadLine();

    if(cevap==sorular[i].answer){
     System.Console.WriteLine("dogru bildiniz");
    }
    else{
        System.Console.WriteLine($"bilemediniz cevap: {sorular[i].answer}");
    }
    System.Console.WriteLine("***********************");
}




           
        }
    }
}
