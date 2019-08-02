using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion_sistemasNumericos
{
    class sistema_numerico_conversion
    {

        
        private List<char> simbolosNumericos;
        private String numero;



        public sistema_numerico_conversion(List<char> simbolosNumericos)
        {
            this.simbolosNumericos = simbolosNumericos;
            numero = "";
        }

        public void Decimal_a_Base_n(int dividendo, int divisor)
        {
            int residuo = 0;
            numero = "";
            do
            {
                residuo = dividendo % divisor;
                dividendo -= residuo;
                numero += simbolosNumericos[residuo];
                dividendo /= divisor;
            } while (dividendo > 0);
            char[] array = numero.ToCharArray();
            Array.Reverse(array);
            numero = new String(array);
            printf();
            printf();

        }

        public void printf()
        {
            System.Console.WriteLine(numero);
        }
        public String getNumero()
        {
            return numero;
        }

    }


    }
}
