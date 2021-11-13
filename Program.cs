using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace P2_2_1204025
{
    class Program
    {
        static void Main(string[] args)
        {
            anjing anjingsaya; 
            burung burungku;


          
            anjingsaya = new anjing();
            anjingsaya.Namahewan = "Broniee";
            anjingsaya.umur = 6;
            anjingsaya.Warnaa = "coklat";
            anjingsaya.Jeniss = "herder";


            burungku = new burung();
            burungku.Namahewan = "Leo";
            burungku.umur =  3;
            burungku.Warnaa = "Hijau";
            burungku.Jeniss = "parkit";
            

            Console.WriteLine("Ini adalah anjingku namanya adalah {0}", anjingsaya.Namahewan);
            Console.WriteLine("karena dia masih muda dia baru berumur {0} bulan", anjingsaya.umur);
            Console.WriteLine("karena dia gagah perkasa dan sesuai namanya yaitu brownie dia mempunyai kulit  {0}", anjingsaya.Warnaa);
            Console.WriteLine ("dia berjenis {0}", anjingsaya.Jeniss  );

            Console.WriteLine("Ini adalah burungku namanya adalah {0}", burungku.Namahewan);
            Console.WriteLine("karena dia masih muda dia baru berumur {0} bulan", burungku.umur);
            Console.WriteLine("karena dia lucu dengan bulunya yang berwarna  {0}", burungku.Warnaa);
            Console.WriteLine ("dia berjenis {0}", burungku.Jeniss  );




            anjingsaya.makan();
            burungku.memanjat();
 
            Console.ReadLine();
         
         
        }
        
           
    }
}