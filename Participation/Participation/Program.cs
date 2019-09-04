using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime future = today.AddDays(27);
            Console.WriteLine(today.ToLongDateString());
            Console.WriteLine(future);

            //shows the difference between the 2 days
            var difference = future - today;
            Console.WriteLine(difference.Days); //difference._____ can retrieve which ever value you want. (days, time, seconds, etc.)

            Console.ReadKey();
        }
    }
}
