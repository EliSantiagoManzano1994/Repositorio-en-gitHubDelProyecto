using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observador
{
    class observador_sucesiones
    {

        List<sucesiones.SucesionFibonacci> unidadF;
        sucesiones.SucesionFibonacci fibo;

        List<sucesiones.sucesionPadovan> unidadP;
        sucesiones.sucesionPadovan padovan;

        List<sucesiones.sucesionUlam> unidadU;
        sucesiones.sucesionUlam ulam;


        List<sucesiones.Numero_suerte> unidadS;
            sucesiones.Numero_suerte suerte;


         List<conversion_sistemasNumericos.sistema_numerico_conversion> unidadSN;
         conversion_sistemasNumericos.sistema_numerico_conversion conversion;


         public observador_sucesiones(List<sucesiones.SucesionFibonacci>f,List<sucesiones.sucesionPadovan> p,List<sucesiones.sucesionUlam>u,List<sucesiones.Numero_suerte>s,List<conversion_sistemasNumericos.sistema_numerico_conversion>sn)
         {
             unidadF = f;
             unidadP = p;
             unidadU = u;
             unidadS = s;
             unidadSN = sn;

             fibo = new sucesiones.SucesionFibonacci();
             unidadP = new sucesiones.sucesionPadovan();






         }


         public void incremento()
         {
             //mandamos a llamar el metodo siguiente de nuestra clase Fibonnacci, sabemos avanzara conforme a la series
             fibo.siguiente();
             agregaSerie();
         }


         public void decremento()
         {
             //mandamos a llamar el metodo para retroceder un elemento en la serie
             fibo.retrocede();
             agregaSerie();
         }



         //sabemos que la serie de fibonnacci guarda elementos e numros
         public void agregaSerie()
         {
             //obtenemos el estado de la serie de fiboossssssss
             unidadF.Add(new (fibo.obtieneEstado()));
         }











    }
}
