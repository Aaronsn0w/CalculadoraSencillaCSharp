using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSencilla
{
    public class Calculadora: Restricciones
    {
        private string valorEnPantalla = "0";
        private string operacion = "";
        private double memoria = 0;
        public string Sumar()
        {
            if(this.operacion == "")
            {
            OperacionPendiente();
            }
            this.operacion = "suma";
            double value = double.Parse(this.valorEnPantalla);
            this.memoria = this.memoria + value;
            this.valorEnPantalla = "0";
            return "+";
        }

        public string Restar()
        {
            
            return "-";
        }
        public string Multiplicar()
        {
            
            return "x";
        }
        public string Dividir()
        {
            return "/";
        }
        public string Resultado()
        {
            OperacionPendiente();
            string resultado = this.memoria.ToString();
            this.valorEnPantalla = resultado;
            this.memoria = 0;
            this.operacion = "igual";
            return resultado;
        }
        public string Clear()
        {
            this.memoria = 0;
            return this.valorEnPantalla = "0"; 
        }
        public string ObtenerValor()
        {
            return this.valorEnPantalla;
        }
        public string PulsarNumeros(string valor)
        {
            if(this.Tecla(this.valorEnPantalla, valor))
            {
                    this.valorEnPantalla = this.valorEnPantalla + valor;
            }
            else
            {
                    this.valorEnPantalla = valor;

            }
            
            return  this.valorEnPantalla;
        }

        private void OperacionPendiente()
        {
            switch (this.operacion)
            {
                case "suma":
                    this.Sumar();
                    this.operacion = "";
                    break;
                case "resta":
                    this.Restar();
                    this.operacion = "";
                    break;
                case "multiplica":
                    this.Multiplicar();
                    this.operacion = "";
                    break;
                case "igual":
                    this.operacion = "";
                    break;
                default:
                    return;

            }
        }

    }
}
