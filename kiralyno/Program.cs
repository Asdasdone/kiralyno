using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                if (t[a,b]==urescella)
                {
                    t[a, b] = 'K';
                    n--;
                }
            }
        }
        public void fajbair(StreamWriter fajl)
        {

            for (int i = 0; i < 8; i++)
            {
                string sor = "";
                for (int y = 0; y < 8; y++)
                {
                    sor += t[i, y];
                }
                fajl.WriteLine(sor);
            }
            fajl.WriteLine();
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
            tabla[] tablak = new tabla[64];
            
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
            StreamWriter ki = new StreamWriter("asd.txt");
            for (int i = 0; i < tablak.Length; i++)
            {
                tablak[i] = new tabla('*');
                //tablak[i].elhelyez(i + 1);
               // tablak[i].fajbair(ki);
            }
            for (int b = 0; b < 64; b++)
            {
                tablak[b].elhelyez(b + 1);
                tablak[b].fajbair(ki);
            }
            ki.Close();
            Console.ReadKey();
        }
    }
}
