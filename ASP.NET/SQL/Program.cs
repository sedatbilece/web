using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;





namespace vertab2
{
// costumer classı
    public class Costumer
    {
        public int id { get; set; }

        public string name { get; set; }
    }
    ///////////////////////////////////////////
    class Program
    {
        static void Main(string[] args)
        {
          var yenimus=new Costumer();
          yenimus.id=100;
          yenimus.name="sdsdsdsd2";

          setproduct(yenimus);


          var products= getAllProduct();// fonk return type List<Costumer> products

          foreach (var item in products)// her item bir satırı temsil eder
          {
              System.Console.WriteLine($"id: {item.id} name: {item.name}");
          }
        }




    
//*************************************** sql bağlantı fonksiyonu

        static MySqlConnection GetMySqlConnection(){// bağlantı saglayan fonksiyon 

             string connectstring=@"server=127.0.0.1;port=3306; database=mydb; user=root;password=123456;" ;

    return new  MySqlConnection(connectstring) ;

        }//getsql end


//*************************************** ürünleri listeleme
static List<Costumer> getAllProduct(){ //veri çekme çekme 

List<Costumer> products=null;// costumer classını tutan liste

      using(var connection = GetMySqlConnection() ){

        try{
connection.Open();
Console.WriteLine("baglantı pozitif");

string sql="select * from costumer ";//ssql metni

MySqlCommand command=new MySqlCommand(sql,connection);//verritabanı bağlantısı için command objesi üretiliyor

var reader= command.ExecuteReader();

 products =new List<Costumer>();//liste oluşturuluyor

          while(reader.Read()){
                    products.Add(new Costumer//listeye eleman ekleme
                    {
                        id=int.Parse(reader[0].ToString())
                        ,name=reader[1].ToString()
                    
                    });
                    
                    }
          reader.Close();

          

 
    
        }catch(Exception e){

            Console.WriteLine(e.Message);

        }
        finally{
    connection.Close();
}

    }//using end
    return products;// Costumer ın objelerını tutan listeyi döndürür fonksiyon

}//getallproduct
 
//*************************************** ürünleri ekleme
 static void setproduct(Costumer p){


       using(var connection = GetMySqlConnection() ){

        try{
connection.Open();
Console.WriteLine("baglantı pozitif");

string sql="insert into costumer (name) VALUES (@cstname)";//ssql metni

MySqlCommand command=new MySqlCommand(sql,connection);//verritabanı bağlantısı için command objesi üretiliyor



command.Parameters.AddWithValue("@cstname",p.name);

int result=command.ExecuteNonQuery();//kaç kayıt yapıldığını döndürür

System.Console.WriteLine($"{result} kayıt eklendi ...");
          

 
    
        }catch(Exception e){

            Console.WriteLine(e.Message);

        }
        finally{
    connection.Close();
}

    }
 }//setproduct end
       
    }
//*************************************** ürünleri güncelleme
// update işlemi ekleme ile aynı sadece sql stringi değişir 
// string sql="update costumer set (name=@cstname) where (id=@cstid)"; //gibi

//*************************************** ürünleri silme
//buda aynısı sql string değişir 
//string sql="delete from costumer where id=@cstid"; //@cst id dışarıdan almak için 

// command.Parameters.AddWithValue("@cstid,verilenid); // kullanılır


    }

