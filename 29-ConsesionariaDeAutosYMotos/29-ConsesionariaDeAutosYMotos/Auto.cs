using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _29_ConsesionariaDeAutosYMotos
{
    class Auto: Vehiculo
    {
        public override int CapacidadDeGuantera { get; set; }
        public override string CantidadDePuertas { get; set; }

        public override string Encender() /* Aqui estamos sobre-escribiendo el METODO "Encencer" de la clase PADRE Vehiculo
                                             cuando invoquemos esta clase se ejcutara este METODO de la clase AUTO*/
        {
            return "Encendiendo Auto " + base.Marca;
        }
    }
}
