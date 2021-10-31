using System;

namespace RPSLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Rocky r = new Rocky();
            Console.WriteLine(r.GenerateRPS());
            UserPlayer p = new UserPlayer();
            Console.WriteLine(p.GenerateRPS());

            Randa randa = new Randa();
            Console.WriteLine(randa.GenerateRPS());



             
        }
    }
}
