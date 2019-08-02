using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sucesiones
{
    class ListaNumeroSerie
    {
        List<sucesiones.SucesionFibonacci> fibs;//creamos una lista que contendra el comportamiento de la serie fibonacci
        sucesiones.SucesionFibonacci fibonacci;


        public ListaNumeroSerie(List<sucesiones.SucesionFibonacci> fib)
        {
            fibs = fib;
            fibonacci = new sucesiones.SucesionFibonacci();

        }

        public void incremento()
        {
            //mandamos a llamar el metodo siguiente de nuestra clase Fibonnacci, sabemos avanzara conforme a la series
            fibonacci.siguiente();
            agregaSerie();
        }


        public void decremento()
        {
            //mandamos a llamar el metodo para retroceder un elemento en la serie
            fibonacci.retrocede();
            agregaSerie();
        }


        //sabemos que la serie de fibonnacci guarda elementos e numros
        public void agregaSerie()
        {
            //obtenemos el estado de la serie de fiboossssssss
            fibs.Add(new SucesionFibonacci(fibonacci.obtieneEstado()));
        }


    }
}
