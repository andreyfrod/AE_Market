using AE_Market_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CuponLN
    {
        public static void Nuevo(CuponEntidad cupon)
        {
            CuponDatos.Insertar(cupon);
        }
    }
}
