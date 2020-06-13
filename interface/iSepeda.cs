using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Sepeda : IKendaraan
    {
        public override void Jenis()
        {
            Console.WriteLine("Sepeda, transportasi jarak dekat.");
            Console.WriteLine("Sepeda, umumnya dipakai untuk berolahraga dan tempuh perjalanan jarak dekat.");
        }
    }
}