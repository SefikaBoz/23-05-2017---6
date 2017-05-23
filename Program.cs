# 23-05-2017---6

using ListCollectionExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericsGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dtStart = DateTime.Now;
            Liste<int> myListe = new Liste<int>();
            for (int i = 0; i < 1000000; i++)
            {
                myListe.Add(i);
                int element = myListe[i];
            }

            DateTime dtEnd = DateTime.Now;
            TimeSpan tsTimeListe = dtEnd - dtStart;

            Console.WriteLine("Template version .. : " + tsTimeListe.TotalMilliseconds);

            DateTime dtStart2 = DateTime.Now;
            List myList = new List();
            for (int i = 0; i < 1000000; i++)
            {
                myList.Add(i);
                int element2 = (int)myList[i];
            }
            DateTime dtEnd2 = DateTime.Now;
            TimeSpan tsTimeList = dtEnd2 - dtStart2;
            Console.WriteLine("Classical version.. " + tsTimeList.TotalMilliseconds);


            Console.ReadLine();
        }
    }
}
