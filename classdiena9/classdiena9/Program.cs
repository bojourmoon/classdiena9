using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classdiena9
{
    class Program
    {
        static void Main(string[] args)
        {
            pirma pirmaisobj = new pirma();
            //masina bmw = new masina pamats objekta izveidei. lai pieklutu klasei vajag izveidot objektu
            //klases nosaukums objektanosaukums = new  klasesnosaukums()
            int rezultats = pirmaisobj.saskaitisana(0, 0);

            //otrs objekts
            pirma pirmaisobj2 = new pirma();

              pirmaisobj.skaitlis = 5;
            pirmaisobj2.skaitlis = 9;

            Console.WriteLine("izvade no pirm    " + pirmaisobj.skaitlis);
            Console.WriteLine("izvade no pirm2      " + pirmaisobj2.skaitlis);



            Console.WriteLine("sis naks no manas klases---" + rezultats);
            Console.ReadLine();
        }
        
    }
}
// objekti var nakt no vienas klases bet viens otru neietekme