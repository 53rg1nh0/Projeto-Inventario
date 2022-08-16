using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoDB
{
    public class ExcessaoBanco: Exception
    {
        public ExcessaoBanco(string message) : base(message)
        {
            
        }
    }
}
