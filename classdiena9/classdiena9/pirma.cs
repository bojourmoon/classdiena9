using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classdiena9
{
    class pirma

    {
        public int skaitlis; //vienkars parasts mainigais kuram var pieklut no citam klasem.nav labais tonis
       // public, private piejama vai nepieejama var pieklut arpus sis klases. 
       public int saskaitisana(int a,int b)//parasta publiska funkcija
        {

            return a + b;
        }

        private void izvade()
        {

            Console.WriteLine("tadaa");
            Console.ReadKey();
        }
      
    }
    
}
//katru reizi kad pieklustam klasei un izveidojam objektu vinam var pieskirt citu vertibu 