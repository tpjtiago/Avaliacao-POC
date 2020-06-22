using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.Model
{
    public class RickMory
    {
        public Guid id { get; set; }
        public string RickNome { get; set; }
        public string MortyNome { get; set; }
        public string Dimensao { get; set; }
        public byte [] ImagemRick { get; set; }
        public byte [] ImagemMorty { get; set; }


    }
}
