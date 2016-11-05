using System;
using System.Runtime.CompilerServices;

namespace Caller_Information
{
    class Program
    {
        static void Main(string[] args)
        {
        
          OtroMetodo();
          Console.ReadLine();

        }

        private static void OtroMetodo()
        {
            MiMetodo();
        }

        static void MiMetodo(
                            [CallerMemberName] string NombreMetodo = "",
                            [CallerFilePath] string RutaArchivo = "",
                            [CallerLineNumber] int NumeroLinea = 0)
        {
            Console.WriteLine("Ruta del Archivo {0}", RutaArchivo);
            Console.WriteLine("Nombre de la funcion que llama {0}", NombreMetodo);
            Console.WriteLine("Numero Linea que se ejecuta {0}", NumeroLinea);

        }
    }

}
