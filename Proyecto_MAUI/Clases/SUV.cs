using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAUI.Clases
{
    internal class SUV : VehiculoBase
    {
        public string Frenos { get; set; }
        public string Navegacion { get; set; }
        public string Ventanas { get; set; }

        public SUV(int velm) : base(velm)
        {
        }

        public void AbrirVentanas(Label outputLabel)
        {
            if (encendido)
            {
                outputLabel.Text = "Abriendo ventanas del vehículo.";
            }
            else
            {
                outputLabel.Text = "El vehículo no está encendido.";
            }
        }
    }
}
