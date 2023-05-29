using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAUI.Clases
{
    internal class Convertible : VehiculoBase
    {
        public string Motor { get; set; }
        public string Capota { get; set; }
        public string Suspension { get; set; }
        public Convertible(int velm) : base(velm)
        {
        }

        //public void ActivarCapota()
        //{
        //    if (encendido)
        //    {
        //        Console.WriteLine("Activando capota.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("El vehículo no está encendido.");
        //    }
        //}

        public void ActivarCapota(Label outputLabel)
        {
            if (encendido)
            {
                outputLabel.Text = "Activando capota.";
            }
            else
            {
                outputLabel.Text = "El vehículo no está encendido.";
            }
        }
    }
}
