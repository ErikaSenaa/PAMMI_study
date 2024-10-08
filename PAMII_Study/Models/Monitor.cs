using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMII_Study.Models
{
    public class Monitor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Foto { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
        public string Conteudo { get; set; }
        public Disciplina id { get; set; }
        public List<Disponibilidade> Disponibilidades { get; set; }
        private String idade;
    }
}
