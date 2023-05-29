using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAUI.Clases
{
    internal class Sedan : VehiculoBase
    {
        public string Entretenimiento { get; set; }
        public string Luces { get; set; }
        public string Traccion { get; set; }

        public Sedan(int velm) : base(velm)
        {
        }

        public void EncenderLuces(Label outputLabel)
        {
            if (encendido)
            {
                outputLabel.Text = "Encendiendo las luces del vehículo.";
            }
            else
            {
                outputLabel.Text = "El vehículo no está encendido.";
            }
        }
    }
}
