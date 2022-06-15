using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _29_ConsesionariaDeAutosYMotos
{
    class Moto: Vehiculo
    {
        public override string TipoDeMoto { get; set; }
        public override string TipoDeLlantas { get; set; }

        public override string Encender()/* Aqui estamos sobre-escribiendo el METODO "Encencer" de la clase PADRE Vehiculo
                                            cuando invoquemos esta clase se ejcutara este METODO de la clase MOTO*/
        {
            return "Encendiendo Moto " + base.Marca;
        }
    }
}
