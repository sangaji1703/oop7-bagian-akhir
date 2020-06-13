using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Motor : IKendaraan
    {
        public override void Jenis()
        {
            Console.WriteLine("Motor, disini motor yang dimaksud dengan beroda dua.");
            Console.WriteLine("Motor, banyak digunakan dikalangan masyarakat indonesia.");
        }
    }
}