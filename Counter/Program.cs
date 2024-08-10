using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock("myclock");

            for (int i = 0; i < 60; i++)
            {
                myClock.Tick();
                myClock.GetCurrentTime();
            }
        }
    }
}
