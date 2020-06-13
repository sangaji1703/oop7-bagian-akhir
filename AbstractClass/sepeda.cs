using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Sepeda : Kendaraan
    {
        public override void Jenis()
        {
            Console.WriteLine("Sepeda, transportasi jarak dekat.");
            Console.WriteLine("Sepeda, umumnya dipakai untuk berolahraga dan tempuh perjalanan jarak dekat.");
        }
    }
}