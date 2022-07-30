using System;
using System.Collections.Generic;
using System.Text;
namespace teste
{
    public delegate double dell(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            soma Somar = soma.Instance;
            calculadora calculadora = calculadora.Instance;
            Console.WriteLine(calculadora.calcular(2,3, Somar.oper));
            Console.WriteLine(calculadora.calcular(7,3, Somar.oper)); 
            Console.WriteLine(calculadora.calcular(2,1, Somar.oper));
           
            soma sun = soma.Instance;
            Console.WriteLine(calculadora.calcular(2,3, sun.oper));
            Console.WriteLine(calculadora.calcular(7,3, sun.oper)); 
            Console.WriteLine(calculadora.calcular(2,1, sun.oper));
           
            soma2 soma2 = new soma2();

            Console.WriteLine(calculadora.calcular(3,4,soma2.oper));
            Console.WriteLine(calculadora.calcular(3,5,soma2.oper));

            soma2 som = new soma2();
            Console.WriteLine(calculadora.calcular(2,3, som.oper));
            Console.WriteLine(calculadora.calcular(7,3, som.oper)); 
            Console.WriteLine(calculadora.calcular(2,1, som.oper));
           
        }
    }
}
