using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final___pomponio
{
    internal class Combustibles
    {
        private int id_comb;
        private List<Combustibles> listacomb;


        public Combustibles() 
        {
            this.id_comb = 0;       
            List<Combustibles> listacomb = new List<Combustibles>();
        }

        public void CargarListaComb()
        {
            string nombretxt1 = "Combustibles";
            FileStream Archivo = new FileStream(nombretxt1, FileMode.Open);
            StreamReader leer = new StreamReader(Archivo);

            while (leer.EndOfStream == false)
            {
                string cadena = leer.ReadLine();
                string[] separado = cadena.Split(';');

                Vehiculo veh = new Vehiculo(separado[0]);
            }
        }


    }
}
