using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat 
            Bejegyzes h = new Bejegyzes("","");        
            Console.WriteLine("valtoztass a tartalmon!");
            h.setTartalom(Console.ReadLine());
            Console.WriteLine(h.Kiir());

            //2.feladat
            List<Bejegyzes> bejegyzes = new List<Bejegyzes>();
            bejegyzes.Add(new Bejegyzes("szemely2", "jegyzes2"));
            bejegyzes.Add(new Bejegyzes("szemely3", "jegyzes3"));
            int db;
            Console.WriteLine("Adj meg egy szamot");
            while(!(int.TryParse(Console.ReadLine(), out db)))
            {
                Console.WriteLine("Szamot adj meg");
            }
            int szam = 3;            
            for(int i=0;i< db; i++)
            {               
                Console.WriteLine("Add meg a "+szam+++" bejegyzest: ");
                bejegyzes.Add(new Bejegyzes(Console.ReadLine(), Console.ReadLine()));
            }
            int num = 20 * bejegyzes.Count;
            Random ran = new Random();
            foreach(var i in bejegyzes)
            {
                i.setLikekok(ran.Next(1,num+1));
            }

            foreach(var i in bejegyzes)
            {
                Console.WriteLine(i.Kiir());
            }

            //3.feladat
            int max = 0;
            foreach(var i in bejegyzes)
            {
                if (i.getLikok() > max)
                {
                    max = i.getLikok();
                }
            }
            Console.WriteLine("\nLikok szama a legnepszerubb bejegyzesben: "+max);
            Boolean vane = false;
            foreach(var i in bejegyzes)
            {
                if (i.getLikok() > 35)
                {
                    vane = true;
                }
            }
            if (vane)
            {
                Console.WriteLine("\nVan 35-nel tobb lakot tartalmazo bejegyzes");
            }
            else
            {
                Console.WriteLine("\nNincs ilyen 35-nel tobb likot tartalmozo bejegyzes");
            }
            int hany = 0;
            foreach(var i in bejegyzes)
            {
                if (i.getLikok() < 15)
                {
                    hany++;
                }
            }
            Console.WriteLine("\nEnnyi 15-nel kevesebb likot tartalmozo bejegyzes van: "+hany);
            bejegyzes.Sort(delegate (Bejegyzes x, Bejegyzes y)
            {
                return y.getLikok().CompareTo(x.getLikok());
            });
            Console.WriteLine("\nLista likok szerint csokkenve:");
            foreach (var i in bejegyzes)
            {
                Console.WriteLine(i.Kiir());
            }
            Console.ReadKey();
        }
    }
}
