using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sucesiones
{
    public class SucesionFibonacci
    {
         private int estado;//variable que guardara el estado de fibonnaacci en cada recorrido
        private int actual;//variable que guarda el valor actual despues de haber recorrido la serie
        private int anterior;//numero anterior despues de haber avanzado una posicion

        public SucesionFibonacci()
        {
            estado = 0;
            actual = 0;
            anterior = 0;
        }
        public SucesionFibonacci(int number)
        {
            estado = 0;
            actual = 0;
            anterior = 0;
            avanza(number);
        }

        private void avanza(int number)
        {
            if (number < 0)
                try
                {
                    throw new System.InvalidOperationException("----error en el rango (" + estado + ") dicho error no esta definido");
                }
                catch (Exception e)
                {
                    Console.WriteLine("desbordamiento ",e);
                }
                //throw new System.InvalidOperationException("--Fuera del rango de la funcion fibonacci--\nfib(" + estado + ")= #ERROR No esta definido ");
            //creamos un ciclo for, el cual hara que el valor de siguiente, avance conforme se da click  y haga cumplir el evento
            for (int i = 1; i < number; i++)
            {
                siguiente();
            }
        }
        public void printf()
        {

            System.Console.WriteLine("fib(" + estado + ")= " + actual);
        }

        //crearemos el metodo siguiente, es cual iniciara con un vaor actual de cero, conforme vaa avanzando, los valores iran avanzando
        public void siguiente()
        {
            //creams una variable que tendra el valor actual, se ira modificando conforme avance la serie
            int respaldoActual = actual;
            estado++;

           
          
                if (actual < 0)
                   
                       

                    try
                    {
                        throw new System.InvalidOperationException("----desbordamiento en estado (" + estado + ") error:numero muy grande para un entero");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("desbordamiento ", e);
                    }
                        actual = estado == 1 ? 1 : actual;
                        actual += anterior;
                        anterior = respaldoActual;
                    
          
                       

                       
  }
        public void retrocede()
        {
            estado--;
            if (estado < 0)
                 try
                    {
                        throw new System.InvalidOperationException("--te encuentras fuera de la serie de fibonnacci (" + estado + ") ");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("desbordamiento ", e);
                    }
            int respaldoActual = actual;
            actual = anterior;
            anterior = estado == 0 ? 0 : respaldoActual - actual;
        }

        public int obtenValor()
        {
            return actual;

        }
        public int obtieneEstado()
        {
            return estado;

        }


    }
}
