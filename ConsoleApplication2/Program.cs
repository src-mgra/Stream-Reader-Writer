using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Schreibe in Datei
            FileStream fs = new FileStream("C:\\Daten\\Quadrate.txt",FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("Quadratzahlen");
            for (int i = 0; i < 20; i++)
            {
                writer.WriteLine("i={0} i*i={1}", i, i * i);
                //Console.WriteLine("i={0} i*i={1}", i, i * i);
            }
            writer.Close();
            fs.Close();

            //Lese aus Datei
            FileStream fr = new FileStream("C:\\Daten\\Quadrate.txt",FileMode.Open);
            StreamReader reader = new StreamReader(fr);
            string zeile;
            while ((zeile = reader.ReadLine()) != null)
            {
                Console.WriteLine(zeile);
            }
            reader.Close();
            fr.Close();

            Console.ReadLine();

            //Berechnung in Schleife + Ausgabe
            int j;
            int[] c = new int[] {1,3,5,7 };
           
            for (j = 0; j < c.Count(); j++) {
                Console.WriteLine("{0}. Wert:{1} {2,2:f2}", j, c[j], c[j] * 3.14);
            }

            Console.ReadLine();
        }
    }
}
