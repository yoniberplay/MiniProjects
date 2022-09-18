using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel.ViewModel
{
    public static class CalcularDivisaViewModel
    {
        public static double Calcular(DivisaViewModel dato)
        {
            double resultado = 0;
            if (dato.De.Equals(dato.A))
            {
                resultado = dato.Monto;
            }
            else
            {
                
                if (dato.De.Equals("Dolar") && dato.A.Equals("Peso"))
                {
                    resultado = dato.Monto * 55;
                }
                if (dato.De.Equals("Peso") && dato.A.Equals("Dolar"))
                {
                    resultado = dato.Monto / 55;
                }
                if (dato.De.Equals("Euro") && dato.A.Equals("Peso"))
                {
                    resultado = dato.Monto * 54;
                }
                if (dato.De.Equals("Peso") && dato.A.Equals("Euro"))
                {
                    resultado = dato.Monto / 54;
                }
                if (dato.De.Equals("Dolar") && dato.A.Equals("Euro"))
                {
                    resultado = dato.Monto * 1.00175;
                }
                if (dato.De.Equals("Euro") && dato.A.Equals("Dolar"))
                {
                    resultado = dato.Monto / 1.00175;
                }

            }

            
            return resultado;
        }
    }
}
