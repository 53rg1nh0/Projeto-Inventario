using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacaoPespUni
{
    internal class ExcessaoRegraNegocio : Exception
    {
        public ExcessaoRegraNegocio(string mensagem) : base(mensagem)
        {
        }
    }
}
