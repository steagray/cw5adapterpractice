using System;

namespace cw5adapterpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear grizzlyInstance = new Grizzly();
            ToyBear teddyBearInstance = new TeddyBear();

            BearAdapter bAdapter = new BearAdapter(grizzlyInstance);

            Console.Write("grizzlyInstance.maul(): ");
            grizzlyInstance.maul();
            Console.Write("grizzlyInstance.hibernate(): ");
            grizzlyInstance.hibernate();
            Console.Write("teddyBearInstance.hug(): ");
            teddyBearInstance.hug();
            Console.Write("bAdapter.hug(): ");
            bAdapter.hug();
        }
    }
}
