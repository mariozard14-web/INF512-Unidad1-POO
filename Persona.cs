using System;

namespace INF512_Unidad1_POO
{
    public class Persona
    {
        // Atributos
        private string nombre;
        private int edad;

        // Constructor
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // Método para mostrar la información
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
        }

        // Método para aumentar la edad
        public void CumplirAnios()
        {
            edad++;
        }

        // Método para obtener el nombre
        public string ObtenerNombre()
        {
            return nombre;
        }

        // Método para saludar
        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {nombre}.");
        }
    }
}
