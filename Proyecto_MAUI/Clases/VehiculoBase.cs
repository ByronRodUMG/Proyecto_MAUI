using Proyecto_MAUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAUI.Clases
{
    internal class VehiculoBase : IVehiculo
    {
        public bool encendido = false;
        public bool acelerando = false;
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }

        public int VelocidadMaxima { get; }

        public int VelocidadActual { get; private set; }

        public VehiculoBase(int velm)
        {
            VelocidadMaxima = velm;
        }

        public void Acelerar(int cuanto, Label outputLabel)
        {
            if (encendido)
            {
                outputLabel.Text = $"Acelerando {cuanto} km/h";
                acelerando = true;
                VelocidadActual += cuanto;
                if (VelocidadActual > VelocidadMaxima)
                {
                    VelocidadActual = VelocidadMaxima;
                    outputLabel.Text += "\nEl auto ha alcanzado su velocidad máxima.";
                    return;
                }
                outputLabel.Text += $"\nVelocidad actual: {VelocidadActual} km/h";
            }
            else
            {
                outputLabel.Text = "El auto está apagado, no se puede acelerar.";
            }
        }

        public void Apagar(Label outputLabel)
        {
            if (encendido)
            {
                outputLabel.Text = "Apagando el auto.";
                encendido = false;
                VelocidadActual = 0;
            }
            else
            {
                outputLabel.Text = "El auto ya está apagado.";
            }
        }

        public void Bocina(Label outputLabel)
        {
            if (encendido)
            {
                outputLabel.Text = "Haciendo sonar la bocina.";
            }
            else
            {
                outputLabel.Text = "El auto está apagado, no se puede hacer sonar la bocina.";
            }
        }

        public void Encender(Label outputLabel)
        {
            if (encendido)
            {
                outputLabel.Text = "El auto ya está encendido.";
            }
            else
            {
                outputLabel.Text = "Encendiendo el auto.";
                encendido = true;
            }
        }

        public void Frenar(int cuanto, Label outputLabel)
        {
            if (acelerando && VelocidadActual > 0)
            {
                outputLabel.Text = $"Frenando {cuanto} km/h";
                VelocidadActual -= cuanto;
                if (VelocidadActual < 0)
                {
                    VelocidadActual = 0;
                    outputLabel.Text += "\nEl auto se ha detenido.";
                    return;
                }
                outputLabel.Text += $"\nVelocidad actual: {VelocidadActual} km/h";
            }
            else
            {
                outputLabel.Text = "El auto no está acelerando, no puede frenar.";
            }
        }
    }
}

//namespace Proyecto_MAUI.Clases
//{
//    internal class VehiculoBase : IVehiculo
//    {
//        public bool encendido = false;
//        public bool acelerando = false;
//        public string Marca { get; set; }
//        public string Modelo { get; set; }
//        public string Color { get; set; }
//        public int Anio { get; set; }
//        public string Placa { get; set; }
//        public string Tipo { get; set; }

//        public int VelocidadMaxima { get; }

//        public int VelocidadActual { get; private set; }

//        public VehiculoBase(int velm)
//        {
//            VelocidadMaxima = velm;
//        }

//        public void Acelerar(int cuanto)
//        {
//            if (encendido)
//            {
//                Console.WriteLine("Acelerando {0} km/h", cuanto);
//                acelerando = true;
//                VelocidadActual += cuanto;
//                if (VelocidadActual > VelocidadMaxima)
//                {
//                    VelocidadActual = VelocidadMaxima;
//                    Console.WriteLine("El auto ha alcanzado su velocidad máxima.");
//                    return;
//                }
//                Console.WriteLine("Velocidad actual: {0} km/h", VelocidadActual);
//            }
//            else
//            {
//                Console.WriteLine("El auto está apagado, no se puede acelerar.");
//            }
//        }

//        public void Apagar()
//        {
//            if (encendido)
//            {
//                Console.WriteLine("Apagando el auto.");
//                encendido = false;
//                VelocidadActual = 0;
//            }
//            else
//            {
//                Console.WriteLine("El auto ya está apagado.");
//            }
//        }

//        public void Bocina()
//        {
//            if (encendido)
//            {
//                Console.WriteLine("Haciendo sonar la bocina.");
//            }
//            else
//            {
//                Console.WriteLine("El auto está apagado, no se puede hacer sonar la bocina.");
//            }
//        }

//        public void Encender()
//        {
//            if (encendido)
//            {
//                Console.WriteLine("El auto ya está encendido.");
//            }
//            else
//            {
//                Console.WriteLine("Encendiendo el auto.");
//                encendido = true;
//            }
//        }

//        public void Frenar(int cuanto)
//        {
//            if (acelerando && VelocidadActual > 0)
//            {
//                Console.WriteLine("Frenando {0} km/h", cuanto);
//                VelocidadActual -= cuanto;
//                if (VelocidadActual < 0)
//                {
//                    VelocidadActual = 0;
//                    Console.WriteLine("El auto se ha detenido.");
//                    return;
//                }
//                Console.WriteLine("Velocidad actual: {0} km/h", VelocidadActual);
//            }
//            else
//            {
//                Console.WriteLine("El auto no esta acelerando, no puede frenar.");
//            }
//        }
//    }
//}
