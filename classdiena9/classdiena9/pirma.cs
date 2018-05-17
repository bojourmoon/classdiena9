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

        //sadi ir pareizi taisit mainigo 

        private int privatais1;
        //getteri un setteri
        public int Get()
        {//ar get izmanto funkciju un var ari mainit vertibas un parbaudit
            return privatais1;
        }

        public void Set(int value)//lai var pieklut privatajam mainigajam var mainit vertibu , SET PIESKIR VERTIBU AR GET VAR IZVADIT ARI 
        {//KATRAM MAINIGAJAM VAJADZETU SAVU GET UN SETU..
            if (value != 0) {
                privatais1 = value;
            }
            else
            {
                privatais1 = 1;
            }
        }

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