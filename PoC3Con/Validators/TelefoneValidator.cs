using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC3ConDomain.Validators
{
    public static class TelefoneValidator
    {
        public static bool EhValido(string telefone)
        {
            if (string.IsNullOrWhiteSpace(telefone))
                return false;

            telefone = new string(telefone.Where(char.IsDigit).ToArray());

            return telefone.Length == 10 || telefone.Length == 11;
        }
    }
}
