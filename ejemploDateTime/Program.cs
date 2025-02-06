using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El tipo datetime tiene un montón de sobrecargas
            //DateTime Fecha = new DateTime(2004,04,01);
            DateTime Fecha = DateTime.Now;

            //Console.WriteLine("La fecha es: " + Fecha.AddDays(5)); //Añade 5 dias a la fecha actual
            //Console.WriteLine("La fecha es: " + Fecha.ToShortDateString()); //transforma a fecha corta
            //Console.WriteLine("La fecha es: " + Fecha.ToShortTimeString()); //transforma a hora corta
            Console.WriteLine("La fecha es: " + Fecha.ToString("dd/MM/yyyy")); //Se modifica a convenencia lo que se quiere mostrar


            Console.ReadKey();
        }
    }
}
