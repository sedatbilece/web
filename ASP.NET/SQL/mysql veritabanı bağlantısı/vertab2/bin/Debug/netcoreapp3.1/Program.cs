using System;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace vertab2
{
    class Program
    {
        static void Main(string[] args)
        {
           GetMySqlConnection();
        }




    
///////////////////////////////////////////////////////////////////////////

        static void GetMySqlConnection(){

             string connectstring=@"server=127.0.0.1;port=3306; database=mydb; user=root;password=123456;" ;

    using(var connection =new  MySqlConnection(connectstring) ){

        try{
connection.Open();
Console.WriteLine("baglantı pozitif");
    
        }catch(Exception e){

            Console.WriteLine(e.Message);

        }
        finally{
    connection.Close();
}

    }//using end

        }//getsql end


        }


    }

