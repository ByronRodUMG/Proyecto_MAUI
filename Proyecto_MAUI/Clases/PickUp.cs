using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAUI.Clases
{
    internal class PickUp : VehiculoBase
    {
        public string Carga { get; set; }
        public string Escape { get; set; }
        public string Conectividad { get; set; }

        public PickUp(int velm) : base(velm)
        {
        }

        public void ActivarWiFi(Label outputLabel)
        {
            if (encendido)
            {
                outputLabel.Text = "Activando Wi-Fi.";
            }
            else
            {
                outputLabel.Text = "El vehículo no está encendido.";
            }
        }
    }
}
