using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HW02
{
    static class Cntrl
    {
        public static string command;
        public static ArrayList xArray = new ArrayList();
        static ArrayList cmdArray = new ArrayList();
        public static int boyut;
        
        public static ArrayList cmdList()
        {
            string[] cmdS = command.Split('+');
            boyut = int.Parse(cmdS[0]);
            for (int i = 1; i < cmdS.Length; i++)
            {
                if (cmdS[i].Contains('_'))
                {
                    xArray.Add(int.Parse(cmdS[i].Substring(2)));//5_x komutu için x değerlerini tutuyor
                    cmdArray.Add(int.Parse((cmdS[i][0]).ToString())); //5_x komutu için 5 değerlerini topluyor
                }
                else
                {
                    cmdArray.Add(int.Parse(cmdS[i]));
                }
            }
            return cmdArray;
        }
        //Komutun "+" karakterine göre kesilip geri döndürmesini sağlıyor.
        public static string[] split()
        {
            return command.Split('+');
        }
        
    }
}
