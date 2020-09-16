using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiralyno
{
     class tabla
    {
        private char[,] t;
        private char urescella;
        private int uresoszlopok;
        private int uresoszsorok;
        public tabla(char a)
        {
            t = new char[8, 8];
            urescella = a;
            for (int i = 0; i < 8; i++)
            {
                for (int y = 0; y < 8; y++)
                {
                    t[i, y] = a;
                }
            }
        }
        public void elhelyez(int n)
        {
            Random rnd = new Random();
            int a=new int();
            int b = new int();
            while (n!=0)
            {
                a = rnd.Next(0, 8);
                b = rnd.Next(0, 8);
                if (t[a,b]!='K')
                {
                    t[a, b] = 'K';
                    n--;
                }
            }
        }
        public void fajbair()
        {

        }
        public void megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Console.Write(t[i,y]+"\t");
                }
                Console.WriteLine("\n\n");
            }
        }
        public int uresoszlop()
        {
            return 0;
        }
        public int uressor()
        {
            return 0;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            tabla asd = new tabla('#');
            asd.elhelyez(4);
            asd.megjelenit();
            Console.ReadKey();
        }
    }
}
