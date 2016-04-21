using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HW02
{
    class Test
    {
        static void Main(string[] args)
        {
            
            int count = 0;
            Console.WriteLine("Örne/Komut/> 10+5_5+3+5_1+3+1+5_4+4+5_7+4+5_4+4+5_3+4+5_3+7+6+8+0\n");
            Console.Write("/Komut/>"); string komut = Console.ReadLine();
            Cntrl.command = komut;
            ArrayList commandS = Cntrl.cmdList();
            ArrayList x = Cntrl.xArray;
            Arac pad = new Arac(Cntrl.boyut);
            pad.yonuBul();
            for (int i = 0; i < commandS.Count; i++)
            {
                if ((int)commandS[i] ==1)
                {
                    pad.Firca = 1;
                }
                if ((int)commandS[i] == 2)
                {
                    pad.Firca = 0;
                }
                if ((int)commandS[i] == 3)
                {
                    pad.sagSol = true;
                    pad.yonuBul();
                }
                if ((int)commandS[i] == 4)
                {
                    pad.sagSol = false;
                    pad.yonuBul();
                }
                if ((int)commandS[i] == 7)
                {
                    pad.geriDon(pad.yonIndis);
                    pad.yonuBul();
                }
                if ((int)commandS[i] == 5)
                {
                    pad.Bes_X((int)x[count++]);
                }
                if ((int)commandS[i] == 6)
                {
                    pad.Firca = 0;
                    pad.Bes_X(3);
                }
                if ((int)commandS[i] == 8)
                {
                    pad.Display();
                }
                if ((int)commandS[i] == 0)
                {
                    Environment.Exit(0);
                }
                
            }
        }
    }
}
