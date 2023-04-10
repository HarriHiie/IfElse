using System;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kõrgus = 171;

            if (kõrgus >= 40 && kõrgus <= 80)
            {
                Console.WriteLine("Sinu pikkus on 40-80");
            }
            else if (kõrgus >= 81 && kõrgus <= 130)
            {
                Console.WriteLine("Sinu pikkus on 81-130");
            }
            else if (kõrgus >= 131 && kõrgus <= 170 )
            {
                Console.WriteLine("Sinu pikkus on 131-170");
            }
            else if (kõrgus > 171)
            {
                Console.WriteLine("Sinu pikkus on on 171");
            }

        }
    }
}
