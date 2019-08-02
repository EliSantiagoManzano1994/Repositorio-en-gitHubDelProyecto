using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sucesiones
{
    public class Numero_suerte
    {
        //creamos una lista para agragar la serie de numeros de la serie
        private List<int> listaSuerte;
        private int estado;
        private int actual;

        public Numero_suerte(List<int>listaSuerte)
        {
            this.listaSuerte=listaSuerte;
            this.estado = 0;
            this.actual = 1;//primer elemento de la serie
        }




        //metodo para iniciar con la sucesion
        public void sucesionNumeros(int tope)
        {

        //implementamos
            int i=0;
            while (i < tope)
            {
                if (i % 2 == 0)
                    listaSuerte.Add(i + 1);
                i++;

                int eje = 1;
                do{
                }while(listaSuerte[eje]<=listaSuerte.Count){


                }
                
            }
        }


        //en este metodo eliminaremos elementos multiples de la sucesion
        //apartir de la posicion
        private void elimina_elementos_multiples(int punto)
        {
            int i=0;
            while(i<listaSuerte.Count){
                i++;
                if ((i + 1) % punto == 0)
                {
                    listaSuerte[i] = 0;
                }
            }
            listaSuerte.Sort();
            listaSuerte.RemoveRange(0, listaSuerte.Count / punto);
            
        }


        public void printf()
        {
            int i=0;
            while (i < listaSuerte.Count)
            {
                i++;
                System.Console.WriteLine(listaSuerte[i]);
            }

        }















    }
}
