using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    internal class planeticket
    {
        public string origin { get; set; }
        public string destination { get; set; }
        public int cost { get; set; }
        public string currency { get; set; }

        public void PrintSummary()
        {
            Console.WriteLine("origin: {0}", origin);
            Console.WriteLine("destination: {0}", destination);
            Console.WriteLine("cost: {0} {1}", cost, currency);

            if (currency == "IDR")
            {
                cost = cost / 15000;
                Console.WriteLine("convert to dollar: {0}", cost);
            }
            else if (currency == "USD")
            {
                cost = cost * 15000;
                Console.WriteLine("convert to rupiah: {0}", cost);
            }


        }
    }
}