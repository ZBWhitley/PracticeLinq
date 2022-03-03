using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vGList = new List<string> {"Mario", "Donkey Kong", "Phantasy Star", "League of Legends", "Rocket League", "Lost Ark", "Horizon Zero Down"};

            vGList.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x) );

            //foreach (var vG in vGSorted)
            //{
            //    Console.WriteLine(vG);
            //}

        }
    }
}
