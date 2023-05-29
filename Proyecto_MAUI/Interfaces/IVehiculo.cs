using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_MAUI.Interfaces
{
    internal interface IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get; }
        public int VelocidadActual { get; }

        void Bocina(Label outputLabel);
        void Acelerar(int cuanto, Label outputLabel);
        void Encender(Label outputLabel);
        void Apagar(Label outputLabel);
        void Frenar(int cuanto, Label outputLabel);
    }
}
