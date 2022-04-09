using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_de_nutricion_IMC
{
    public class Imc
    {
        private const double KG = 2.2046;
        public int edad { get; set; }
        public string nombre { get; set; }
        public int altura { get; set; }
        public Char sexo { get; set; }
        public int peso { get; set; }
        public double imc { get; set; }

        public string prueba()
        {
            this.nombre = "Jairo";//ingreso de datos
            this.edad = 19;
            this.sexo = 'H';
            this.altura = 178;
            this.peso = 237;


            //Inicio de calculo IMC
            double pesoKG = this.peso / KG;
            double estaturaMTS = (double)this.altura / 100;
            double altu = (Math.Pow(estaturaMTS, 2));
            this.imc = pesoKG / altu;
            //fin del calculo de IMC
            Console.WriteLine("su IMC es de:" + imc);
            if (edad >= 18)//funcion if principal para las edades
            {
                if (imc >= 40)//comparacion de peso de adutlo
                {
                    return (" su peso está en la categoría mas alta de la Obesidad para adultos de su misma estatura porfavor es urgente!! que valla a un  especialista de la salud para que le puedan dar soluciion a su problema");
                }
                if ((imc >= 30) && (imc < 40))
                {
                    return ("Esta en estado de obecidad porfavor pongase en contacto con su nutricionista");
                }
                if ((imc >= 26) && (imc < 30))
                {
                    return ("Esta en estado de sobrepeso por favor coma mas sanamente");
                }
                else if ((imc >= 18) && (imc < 25))
                {
                    return ("Su estado actual de peso es normal, siga asi, coma saludable y haga ejercicio  ");
                }

                else
                {
                    return ("Su peso es demasiado bajo por favor pongase en contacto con un profesional de la salud para que le pueda ayudar con su problema");
                }
            }
            //fin del primer if
            else//funcion else principal
            {
                if (imc >= 40)//comparacion de peso para niños
                {
                    return (" su peso está en la categoría mas alta de Obesidad para Niños de su misma estatura \n se le recomienda consultar con un médico o profesional de la salud ya que si no lo hace puede tener graves problemas de salud");
                }
                if ((imc >= 30) && (imc < 40))
                {
                    return ("El niño tiene sobrepeso porfavor consulta a un nutricionista antes que su caso se ponga peor");
                }
                if ((imc >= 26) && (imc < 30))
                {
                    return ("El niño esta obeso porfavor consulta a un nutricionista antes que su caso se ponga peor");
                }
                else if ((imc >= 18) && (imc < 25))
                {
                    return (" su peso está en la categoría Normal para niños de su misma estatura siga asi y coma saludable para mantener una buena salud");
                }
                else
                {
                    return ("El peso del niño esta demasiado bajo porfavor ve al centro de salud mas sercano y consulta con un profesional de la salud ");
                }
                
            }//fin de la funcion if else
            
        }

    }
}