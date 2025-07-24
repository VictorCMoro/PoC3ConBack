using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConDomain.Validators
{
    public static class DataNascimentoValidator
    {
        public static bool EhValido(DateOnly dataNascimento)
        {
            DateOnly hoje = DateOnly.FromDateTime(DateTime.Today);
            int idade = hoje.Year - dataNascimento.Year;

            if(dataNascimento > hoje.AddYears(-idade))
            {
                idade--;
            }

            return idade >= 18;
        }
    }
}
