using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel.ViewModel
{
    public static class CalcularCuoutaViewModel
    {

        public static float Calcular(PrestamosViewModel pv)
        {
            float porcentaje = pv.Interes / 100f;
            float interes = porcentaje * pv.Monto;
            float resultado = interes + pv.Monto;
            resultado = resultado / pv.Cuotas;
            return resultado;
        }
    }
}
