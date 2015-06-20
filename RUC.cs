using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace WorkingWithFormat
{
    class RUC : IFormattable
    {

        // Variable que almacenará el RUC, se escoje Int64 (long) debido al tamaño del valor.
        private Int64 rucNumber = 0;

        // El constructor recive como parámetro el número de cédula.
        public RUC(Int64 cedula)
        {

            // Convertimos el valor de la cédula de Int64 a String.
            String cedulaNumber = Convert.ToString(cedula);

            // Concatenamos el valor 001 al final de la cédula.
            cedulaNumber = cedulaNumber + "001";

            // Convertimos el valor del RUC de String a Int64
            rucNumber = Convert.ToInt64(cedulaNumber);

        } // Constructor

        public Int64 getRUC()
        {

            return rucNumber;

        } // getRUC

        // Método ToString, miembro de la interfaz IFormattable.
        public string ToString(string format, IFormatProvider formatProvider)
        {
            
            // Convertimos el valor de format a mayusculas
            switch(format.ToUpperInvariant())
            {

                // Comprobamos que sea R
                case "R":

                    // Obtenemos el valor del RUC llamando al método ToString(), en este caso de la clase String.
                    return getRUC().ToString();

                default:

                    // Lanzamos una excepción en caso de que no sea R la cadena de formato.
                    throw new FormatException(String.Format("The {0} format is not supported.", format));
                    
            } // switch

        } // ToString

    } // RUC

} // WorkingWithFormat
