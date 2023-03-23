using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class PulcinellaDiMare : Animale, IVolante, INuotante
    {
        public override void Verso()
        {
            Console.WriteLine("Chip");
        }
        public override void Mangia()
        {
            Console.WriteLine("Carne");
        }
        public void Vola()
        {
            Console.WriteLine("Sto volando");
        }
        public void Nuota()
        {
            Console.WriteLine("Sto nuotando");
        }
    }
}
