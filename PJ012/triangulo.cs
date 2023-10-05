using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ012
{
    internal class triangulo
    {
        //atributos
        private double lado1;
        private double lado2;
        private double lado3;




        //metodos 
        public void setVlado1(double p)
        {
            lado1 = p;
        }

        public void setVlado2(double p)
        {
            lado2 = p;
        }

        public void setVlado3(double p)
        {
            lado3 = p;
        }

        public double getVlado1()
        {
            return lado1;
        }

        public double getVlado2()
        {
            return lado2;
        }

        public double getVlado3()
        {
            return lado3;
        }


        public string calcularValores()


        {
            if ((lado1 + lado2 <= lado3) && (lado1 + lado3 <= lado2) && (lado2 + lado3 <= lado1))
            {
                return "Não é triangulo";
            }
            else if ((lado1 == lado2) && (lado1 == lado3) && (lado2 == lado3))
            {
                return "triangulo equilatero";
            }
            else if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3))
            {
                return "isosceles";
            }
            else
                return "Triangulo escaleno.";
        }
    }


}
  