using System;
using System.Collections.Generic;
using System.Text;

namespace Control_de_Invetario_de_TecnoPunto
    {
    public class Producto
        {
        // Atributos
        private string _codigo;
        private string _nombre;
        private decimal _precio;
        private int _cantidad;


        // Propiedad Codigo
        public string Codigo
            {
            get {  return _codigo; }
            set { _codigo = value; }
            }
        // Propiedad Nombre
        public string Nombre
            {
            get { return _nombre; }
            set { if(value.Trim() != "")
                    { _nombre = value; }
            else
                    {
                    throw new Exception("El nombre no puede estar vacio.");
                    }
                }
            }
        // Propiedad Precio
        public decimal Precio
            {
            get { return _precio; }
            set
                {
                if (value > 0)
                    { 
                    _precio = value;
                    }

                else
                    {
                    throw new Exception("El precio debe ser mayor que cero.");
                    }


                }
            
            }

        // Propiedad Cantidad
        public int Cantidad
            {
            get { return _cantidad; }
            set
                {
                if (value >= 0)
                    { 
                    _cantidad = value; 
                    }
                else
                    {
                    throw new Exception("La cantidad no puede ser negativa.");
                    }
                    
                }
            }
        // Propiedad ValorTotal de solo lectura
        public decimal ValorTotal
            {
            get { return Precio * Cantidad; }
            }
        //Constructor 
        public Producto(string codigo, string nombre, decimal precio, int cantidad)
            {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;

            }
        
        // Metodo para Mostrar Informacion
        public void MostrarInfo()
            {
            Console.WriteLine($"Codigo: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine($"Cantidad: {Cantidad}");
            Console.WriteLine($"ValorTotal: {ValorTotal}");
            }


        }
    }
