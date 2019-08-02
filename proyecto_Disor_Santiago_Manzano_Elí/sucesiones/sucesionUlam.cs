using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sucesiones
{
    class sucesionUlam
    {
      List<int> lista_ulam;
        public sucesionUlam(List<int> lista_ulam) {
            this.lista_ulam = lista_ulam;
            lista_ulam.Add(1);//agregamos a la lista el elemento uno para realizar las operaciones
            lista_ulam.Add(2);//agrgamos a la lista el segundo elemento
        }
        public sucesionUlam()
        {
            lista_ulam = new List<int>();
            lista_ulam.Add(1);
            lista_ulam.Add(2);
        }

        //Un Número de Ulam es un miembro de una secuencia entera
        public void sucesion(int tope)
        {
            //realizamos un ciclo que recorrera la sucesion, hasta encontrar el valor deseado y verificar
            //que los elementos no sean iguales para poder agregarlos a la lista
            for (int k=3; k <= tope;k++) {
            if (!elementos_iguales(k))
                    lista_ulam.Add(k);
            }
        }

        //metodo que verificara que los elementos no sean iguales y se realicen las operaciones
        //se debe tener en cuenta que al realizar estas operaciones

        private bool elementos_iguales(int k)
        {
            int repeticiones = 0;
            for (int i = 0; i < lista_ulam.Count; i++)
                for (int j = 0; j < lista_ulam.Count; j++)
                    if (k == (lista_ulam[i] + lista_ulam[j]) && lista_ulam[i] != lista_ulam[j]) 
                        repeticiones++;
         
            if (repeticiones ==2 )
                return false;
                
            

            return true;
        }

        public void printf()
        {
            for (int i = 0; i < lista_ulam.Count; i++)
                System.Console.WriteLine(lista_ulam[i]);
        }

        public void guarda()
        {
            throw new NotImplementedException();
        }
    }
}
