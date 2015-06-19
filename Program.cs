using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librería necesaria para utilizar CultureInfo.
using System.Globalization;

namespace WorkingWithFormat
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] cultureNames = { "es-ES", "en-US", "fr-FR", "de-DE" };

            foreach (String cultureName in cultureNames) {

                // Estableciendo configuración local

                CultureInfo culture = new CultureInfo(cultureName);

                // Línea en blanco

                Console.WriteLine();

                // Sustitución - Cadena de Texto

                String someString = String.Format("{0}!", "Some String");

                Console.WriteLine(someString);

                // Sustitución - Más de una variable

                String firstName = "Nery";
                String lastName = "Bergery";

                String holeName = String.Format("First name: {0} / Last name: {1}", firstName, lastName);

                Console.WriteLine(holeName);

                // Formato de Fecha

                String date = String.Format(culture, "Current date: {0:D}", DateTime.Now);

                Console.WriteLine(date);

                // Formato de Moneda (Currency)

                String monthlyWage = String.Format(culture, "Monthly wage: {0:C}", 5230);

                Console.WriteLine(monthlyWage);

                // Números grandes

                String bigNumber = String.Format(culture, "A big number: {0:N}", 123456789);

                Console.WriteLine(bigNumber);

                // Porciento

                String percent = String.Format(culture, "Percent: {0:P}", 0.364);

                Console.WriteLine(percent);

                // Número telefónico

                String phoneNumber = String.Format("Número telefónico: {0:(###) #-####-####}", +593912345678);

                Console.WriteLine(phoneNumber);

                // Línea en blanco

                Console.WriteLine();

            } // foreach

            Console.ReadKey();

        }// Main

    }// Program

}// WorkingWithFormat
