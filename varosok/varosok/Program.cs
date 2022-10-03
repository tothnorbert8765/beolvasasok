using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace varosok
{
    class Baross
    {
        public int Helyezes { get; set; }
        public string Varos { get; set; }
        public string Orszag { get; set; }
        public int nepesseg { get; set; }
        public Baross(string egysor)
        {
            string[] darabos = egysor.Split(';');
            Helyezes = int.Parse(darabos[0]);
            Varos =darabos[1];
            Orszag = darabos[2];
            nepesseg = int.Parse(darabos[3]);
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            /* StreamReader sr = new StreamReader("varosok.txt");
             string sor = sr.ReadLine();
             Baross[] data = new Baross[sor.Length - 1];
             for (int i = 0; i < data.Length; i++)
             {
                 Console.WriteLine(data);
             }*/
            StreamReader sr = new StreamReader("varosok.txt");
            string sor = sr.ReadLine();
            var lista = new List<string[]>();
            string elsosor = sr.ReadLine();
            string[] darabok;
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                darabok = sor.Split(';');

                Console.WriteLine(darabok[0] + ' ' + darabok[2] + ' ' + darabok[3]);
                lista.Add(darabok);
            }
            foreach (var item in lista)
            {
                Console.WriteLine(item[1] + ' ' + item[2]);
            }
            sr.Close();
            StreamWriter sw = new StreamWriter("kiir.txt");
            sw.WriteLine("Dóra a felfedező");
            sw.WriteLine(elsosor);
            foreach (var item in lista)
            {
                sw.WriteLine(item[1] + (char)9 + item[2]);
            }
            sw.Flush();
            sw.Close();
            //olvasás fájlból ReadAllines
            string[] lines = File.ReadAllLines("varosok.txt");
            var lista2 = new List<string[]>();

            Console.ReadKey();
        }
    }
}
