using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final___pomponio
{
    internal class Clientes
    {
        // Propiedades privadas

        private string id_cliente;
        private string cliente;
        private double cuit;
        private string domicilio;
        private int id_domicilio;
        private double telefono;
        private string correo;

        // constructores

        public string Id_cliente 
        { 
            get { return this.id_cliente; } 
            set { this.id_cliente = value; } 
        }
        public string Cliente 
        { 
            get { return this.cliente; } 
            set { this.cliente = value; } 
        }
        public double Cuit
        {
            get { return this.cuit; }  
            set { this.cuit = value; } 
        }
        public string Domicilio 
        { 
            get { return this.domicilio; }
            set { this.domicilio = value; } 
        }
        public int Id_domicilio 
        { 
            get { return this.id_domicilio; }
            set { this.id_domicilio = value; }
        
        }
        public double Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }

        }
        public string Correo
        {

            get { return this.correo; }
            set { this.correo = value; }
        }


        

        // Metodos

        // Propiedades publicas

        public Clientes(string id_cliente, string cliente, double cuit, string domicilio, int id_domicilio, double telefono, string correo)
        {
            this Id_cliente = id_cliente;
            this Cliente = cliente;
            this Cuit = cuit;
            this Domicilio = domicilio;
            this Id_domicilio = id_domicilio;
            this Telefono = telefono;   
            this Correo = correo;
        }


    }
}
