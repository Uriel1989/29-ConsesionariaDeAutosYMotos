using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _29_ConsesionariaDeAutosYMotos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de catalogo de vehiculos:");

            Console.WriteLine("Ingrese AUTO o MOTO, segun lo que desee ver:");
            string tipo = Convert.ToString(Console.ReadLine());

            Auto auto1 = new Auto(); /*Cuando inicialicemos esto, vamos a invocar el "Encender" de la clase hijo AUTO
                                       ya que esta sobre-escribiendo la propiedad GENERAL de la clase PADRE Vehiculo para 
                                       implementar la propiedad de AUTO*/

            auto1.Marca = "Ferrari";
            auto1.Modelo = "Spider";
            auto1.Color = "Negro";
            auto1.TipoDeCombustible = "Gasoil";
            auto1.CapacidadDeGuantera = 2;
            auto1.Cilindrada = 458;
            auto1.Cilindrada = 80;
            

            Moto moto1 = new Moto(); /*Cuando inicialicemos esto, vamos a invocar el "Encender" de la clase hijo MOTO
                                       ya que esta sobre-escribiendo la propiedad GENERAL de la clase PADRE Vehiculo para 
                                       implementar la propiedad de MOTO*/
            moto1.Marca = "Honda";
            moto1.Modelo = "CB190R";
            moto1.Color = "Rojo";
            moto1.TipoDeCombustible = "Nafta";
            moto1.CapacidadDeGuantera = 0;
            moto1.Cilindrada = 190;
            moto1.Cilindrada = 20;

            Vehiculo Camion = new Vehiculo(); /*Cuando inicialicemos esto, vamos a invocar el "Encender" de la clase padre VEHICULO
                                                ya que estamos invocando la propiedad GENERAL de dicha clase*/
            Camion.Marca = "Scania";
            Camion.Modelo = "CB190R";
            Camion.Color = "Rojo";
            Camion.TipoDeCombustible = "Nafta";
            Camion.CapacidadDeGuantera = 0;
            Camion.Cilindrada = 190;
            Camion.Cilindrada = 20;


            List<Vehiculo> MiLista = new List<Vehiculo>();

            MiLista.Add(auto1);
            MiLista.Add(moto1);
            MiLista.Add(Camion);

            Console.WriteLine("Datos de los vehiculos: ");
            foreach (Vehiculo vehiculo in MiLista)
            {                
                Console.WriteLine(vehiculo.Marca);
                Console.WriteLine(vehiculo.Modelo);
                Console.WriteLine(vehiculo.Color);
                Console.WriteLine(vehiculo.TipoDeCombustible);

                Console.WriteLine(vehiculo.Encender());
                
                
            }




            Console.ReadKey();
        }
    }
}
