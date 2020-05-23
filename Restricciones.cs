using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSencilla
{
    public class Restricciones
    {
        

        public bool Tecla(string pantalla, string valor)
        {
            bool respuesta = false;
            if (valor != null)
            {
                if (pantalla == "0" && valor == ".")
                {
                    respuesta = true;
                }
                else if (pantalla == "0")
                {
                    respuesta = false;
                }
                else
                {
                    respuesta = true;

                }
            }
            return respuesta;
        }
     
    }
}
