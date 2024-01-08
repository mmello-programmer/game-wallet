using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWallet.Models
{

    public class gwContatoModel
    {
        public int id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
    }
}