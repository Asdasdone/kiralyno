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
            while (n!=0)
            {
                int a = rnd.Next(0, 8);
                int b = rnd.Next(0, 8);
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
        public bool uresoszlop(int uresoszlopok)
        {
            
            int i = 0;
            while (i < 8 && t[i,uresoszlopok]!='K' )
            {
                i++;
            }
            if (i<8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool uressor(int uressorok)
        {
            int i = 0;
            while (i < 8 && t[uressorok, i] != 'K')
            {
                i++;
            }
            if (i < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            tabla asd = new tabla('#');
            asd.elhelyez(8);
            asd.megjelenit();
            int oszlop = 0;
            int sor = 0;
            for (int i = 0; i < 8; i++)
            {
                if (asd.uresoszlop(i))
                {
                    oszlop++;
                }
                if (asd.uressor(i))
                {
                    sor++;
                }
            }
            Console.WriteLine("Üressor = {0} \nÜresoszlop = {1}",sor,oszlop);     
            /*Console.WriteLine("Kérem az oszlopot: ");
            int a = int.Parse(Console.ReadLine())-1;
            if (asd.uresoszlop(a))
            {
                Console.WriteLine("Üresoszlop");
            }
            else
            {
                Console.WriteLine("Nem üres oszlop");
            }
            Console.WriteLine("Kérem az sort: ");
            int b = int.Parse(Console.ReadLine()) - 1;
            if (asd.uressor(b))
            {
                Console.WriteLine("Üressor");
            }
            else
            {
                Console.WriteLine("Nem üres sor");
            }*/
            Console.ReadKey();
        }
    }
}
