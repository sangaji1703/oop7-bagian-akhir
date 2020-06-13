using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Mobil : Kendaraan
    {
        public override void Jenis()
        {
            Console.WriteLine("Mobil, biasa digunakan untuk berpergian antar kota.");
            Console.WriteLine("Mobil, banyak digunakan dikalangan masyarakat indonesia daerah perkotaan.");
        }
    }
}