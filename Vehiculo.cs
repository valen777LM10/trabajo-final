using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final___pomponio
{
    internal class Vehiculo
    {
        private short id_vehiculo;
        private string patente;
        private int km;
        private short anio;
        private short id_marca;
        private string modelo;
        private short id_modelo;
        private short id_combustible;
        private short precio_vta;
        private string observaciones;
        private string color;
        private short cilindrada;
        private short caja_carga;
        private short dimension_caja;
        private short carga_max;


        public short Id_vehiculo
        {
            get { return this.id_vehiculo; }
            set { this.id_vehiculo = value; }
        }

        public string Patente
        {
            get { return this.patente; }
            set { this.patente = value; }
        }
        public int Km
        {
            get { return this.km; }
            set { this.km = value; }

        }
        public short Anio
        {
            get { return this.anio; }
            set { this.anio = value; }
        }


        public short Id_marca
        {
            get { return this.id_marca; }
            set { this.id_marca = value; }
        }
        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }

        }
        public short Id_modelo
        {
            get { return this.id_modelo; }
            set { this.id_modelo = value; }
        }
        public short Id_combustible
        {
            get { return this.id_combustible; }
            set { this.id_combustible = value; }
        }
        public short Precio_vta
        {
            get { return this.precio_vta; }
            set { this.precio_vta = value; }
        }
        public string Observaciones
        {
            get { return this.observaciones; }
            set { this.observaciones = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public short Cilindrada
        {

            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }
        public short Caja_carga
        {
            get { return this.caja_carga; }
            set { this.caja_carga = value; }
        }
        public short Dimension_caja
        {
            get { return this.dimension_caja; }
            set { this.dimension_caja = value; }

        }
        public short Carga_max
        {
            get { return this.carga_max; }
            set { this.carga_max = value; }
        }

        //constructor para clase Autos y Camionetas
        public Vehiculo(short id_vehiculo, string patente, int km, short anio, short id_marca, string modelo, short id_modelo, short id_combustible, short precio_vta, string observaciones, string color)
        {
            this.Id_vehiculo = id_vehiculo;
            this.Patente = patente;
            this.Km = km;
            this.Anio = anio;
            this.Id_marca = id_marca;
            this.Modelo = modelo;
            this.Id_modelo = id_modelo;
            this.Id_combustible = id_combustible;
            this.Precio_vta = precio_vta;
            this.Observaciones = observaciones;
            this.Color = color;
            
        }

        //constructor para clase Camionetas
        



    }
}
