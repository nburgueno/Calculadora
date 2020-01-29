using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float primero; //el 1er numero
            float segundo;
            string operacion;//operacion a realizar

            Console.Title = "Mini-Calculadora";
            Console.BackgroundColor = ConsoleColor.White;//color de fondo
            Console.ForegroundColor = ConsoleColor.Blue;//color de letra
            Console.Clear();//limpiar pantalla
            Console.SetCursorPosition(3,2);//pedimos el 1er numero de la columna
            Console.WriteLine("Introdusca el primer Nùmero");
            Console.SetCursorPosition(60,2);//columna,fila
            primero = float.Parse(Console.ReadLine());

            Console.SetCursorPosition(3, 3);//pedimos la operacion columna y fila
            Console.WriteLine("Introduzca la operacion a realizar (+,-,*,/)");
            Console.SetCursorPosition(59, 3);//columna y fila
            operacion = Console.ReadLine();

            Console.SetCursorPosition(3, 4);//pedimos el segundo numero columna
            Console.WriteLine("Introduzca el segundo nùmero");
            Console.SetCursorPosition(60, 4);//columna y fila
            segundo = float.Parse(Console.ReadLine());

            Console.SetCursorPosition(57, 5);//Mostramos la solucion 
            Console.WriteLine("_________");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("El resultado es:");
            Console.SetCursorPosition(60, 6);

            //llama al metodo calcularn y envia parametros
            Console.WriteLine(calcular(primero, segundo, operacion));
            Console.ReadKey();//lee una tecla
        }
        private static string calcular(float primero, float segundo, string operacion)
        {
            float temp;//variable que guarda el resultado de la operacion
            switch (operacion)//estructuira con switch
            {
                case "+":
                    temp = primero + segundo;
                    return temp.ToString();//retorna el resultado y lo muestra
                case "-":
                    temp = primero - segundo;
                    return temp.ToString();
                case "*":
                    temp = primero * segundo;
                    return temp.ToString();//retorna el resultado y lo muestra
                case "/":
                    temp = primero / segundo;
                    return temp.ToString();

            }
            return "-1";//se usa por si no se devuelve ningun valor
        }
    }
}
