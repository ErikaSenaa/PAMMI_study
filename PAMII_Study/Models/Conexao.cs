using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMII_Study.Models
{
    public class Conexao
    {
        public long Id { get; set; }
        public Monitor Idmonitor { get; set; }
        public DateTime DtCriacao{ get; set; }
    }
}
