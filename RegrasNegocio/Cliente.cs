using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacaoPespUni
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string UserId { get; set; }
        public int Matricula { get; set; }
        public string Area { get; set; }
        public string Cargo { get; set; }
        public string Sigla { get; set; }
        public Unidade Unidade { get; set; }
        //equipamento

        //METODOS DE INCERÇÃO DE CLIENTE NO BANCO (ENCAPSULAMENTO)
    }
}
