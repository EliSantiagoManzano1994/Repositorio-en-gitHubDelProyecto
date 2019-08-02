using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sucesiones
{

    //en esta clase determinarmos el estado de cada sucesion ya se que esta serie sea un numero feliz
    // o sea un numero capicua
    class propiedad_de_sucesion
    {

        public bool esCapicua(int numero)
        {
            char[] arr = (numero + "").ToCharArray();
            String cad1 = new String(arr);
            Array.Reverse(arr);
            String cad2 = new String(arr);
            return cad1.Equals(cad2);
        }



    }
}
