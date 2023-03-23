﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale, INuotante
    {
        public override void Verso()
        {
            Console.WriteLine("Click");
        }
        public override void Mangia()
        {
            Console.WriteLine("Carne");
        }
        public void Nuota()
        {
            Console.WriteLine("Sto nuotando");
        }
    }
}
