using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sucesiones
{
    class sucesionPadovan
    {
        /*La sucesion de Padovan, necesita dependa de los tres valores X(n-1),x(n-2) x(n-3)) */
        private ulong terminoAnterior;//termino uno(p1)
        private ulong terminoActual;//definimos el termino actual que tendra
        private ulong VecesLlama;//numero en la que es llamado un elemnto en la sucesion
        private ulong terminoAntes2;//termino anterior2(p2)
        private ulong terminoAntes3;//termino anterior 3(p3)

        //p(0)=p(1)=p(2)=1
        //la siguiente relación de recurrencia p(n)=P(n-3)+p(n-2)

        //contructor de sucesion padovn
        public sucesionPadovan()         {
            this.terminoAnterior = 0;
            this.terminoActual = 0;
            this.VecesLlama = 0;
            this.terminoAntes2 = 0;
            this.terminoAntes3 = 0;
        }


        private void avanza(int number)
        {
            if (number < 0)
                try
                {
                    throw new System.InvalidOperationException("----error en el rango (" + terminoActual + ") dicho error no esta definido");
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



        public ulong siguiente()        {
            this.actualizarTerminoSiguiente();
            this.VecesLlama += 1;
            return this.terminoActual;
        }
        public void actualizarTerminoSiguiente()        {
            if (this.VecesLlama >=0 && this.VecesLlama<=2){
                this.terminoActual =1;
                this.terminoAntes2 = 0;
                this.terminoAntes3 = 0;
                this.terminoAnterior = 0;
            }
            
            if (this.VecesLlama == 3)        {
                this.terminoActual = 2;
                this.terminoAntes2  =1;
                this.terminoAntes3 = 1;
                this.terminoAnterior = 1;
            }

            if (this.VecesLlama > 3) {
                this.terminoAntes3 = this.terminoAntes2;
                this.terminoAntes2 = this.terminoAnterior;
                this.terminoAnterior = this.terminoActual;

                this.terminoActual = this.terminoAntes2 + this.terminoAntes3;
            }
        }

        public ulong anterior()        {
            this.actualizarTerminoAnterior();
            this.VecesLlama -= 1;
            return terminoActual;
        }
        public void actualizarTerminoAnterior()        {
            if (this.VecesLlama >=0 && this.VecesLlama<=2 ) {
                this.terminoActual = 1;
                this.terminoAntes3 = 1;
                this.terminoAntes2 = 1;
                this.terminoAnterior =1;
            }
            
            if (this.VecesLlama==3)            {
                this.terminoActual = 2;
                this.terminoAntes3 = 1;
                this.terminoAntes2 = 1;
                this.terminoAnterior = 1;
            }
            if (this.VecesLlama > 3)  {
                ulong respaldoTerminoAnterior = this.terminoAnterior;
                this.terminoActual = this.terminoAnterior;
                this.terminoAnterior = this.terminoAntes2;
                this.terminoAntes2 = this.terminoAntes3;
                this.terminoAntes3 = +respaldoTerminoAnterior - this.terminoAntes3;
            }

        }
        public ulong TerminoActual()
        {
            return terminoActual;
        }

    }




    }

