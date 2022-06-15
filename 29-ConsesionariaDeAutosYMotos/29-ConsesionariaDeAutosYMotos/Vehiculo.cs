using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _29_ConsesionariaDeAutosYMotos
{
    class Vehiculo
    {
        
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string TipoDeCombustible { get; set; }
        public string Color { get; set; }
        public int Cilindrada { get; set; }
        public string TipoDeSuspension { get; set; }

        public virtual string CantidadDePuertas { get; set; }
        public virtual string TipoDeMoto { get; set; }
        public virtual string TipoDeLlantas { get; set; }
        public virtual string TipoDeVehiculo { get; set; }
        public virtual int CapacidadDeGuantera { get; set; }

        public virtual string Encender() /* Este METODO se podra invocar UNICAMENTE si invocamos DIRECTAMENTE a la clase 
                                            PADRE Vehiculo al momento de crear un objeto, tal y como lo estamos haciendo con el objeto Camion.
                                            Caso contrario si creamos un objeto con la clase AUTO o MOTO, este METODO sera sobre-escrito por sus
                                            METODOS particulares correspondientes*/
        {
            return "Encendiendo Vehiculo " + this.Marca;
        }





    }
}
