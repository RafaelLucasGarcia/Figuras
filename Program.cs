using System;
using System.Collections.Generic;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            var consola = new Consola();
            var lienzo = new Lienzo();
            var toolbar = new Toolbar();

            var paint = new Paint(lienzo, toolbar, consola);
            var exit = false;
            string input = "";

            do {
                paint.Consola.Escribir(paint.MostrarAcciones());
                input = paint.Consola.Leer();
                Acciones accion = (Acciones)Convert.ToInt32(input);

                if (accion == Acciones.Nueva)
                {
                    paint.NuevaFigura();
                }
                else if (accion == Acciones.Ver)
                {
                    var figuras = paint.VerFiguras();
                    paint.Consola.Escribir(figuras);
                }
                else if (accion == Acciones.Salir)
                {
                    exit = true;
                }
                
                
                
            } while (!exit);                                             
        }
    }
}
