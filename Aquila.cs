using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale, IVolante
    {
        public override void Verso()
        {
            Console.WriteLine("Screech");
        }
        public override void Mangia()
        {
            Console.WriteLine("Carne");
        }
        public void Vola()
        {
            Console.WriteLine("Sto volando");
        }
    }
}
