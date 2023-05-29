using Proyecto_MAUI.Clases;

namespace Proyecto_MAUI;

public partial class PageSUV : ContentPage
{
    private bool primeravez = true;
    public string Origen;
    public string Texto { get; set; }

    SUV Puma;

    public PageSUV()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (primeravez)
        {
            // Realiza la funcionalidad específica la primera vez que se accede a la página
            Puma = new(220)
            {
                Marca = "Ford",
                Modelo = "Puma",
                Color = "Verde",
                Anio = 2022,
                Placa = "PUM-2022",
                Tipo = "SUV",
                Frenos = "ABS",
                Navegacion = "Satelital",
                Ventanas = "Eléctricas",
            };
            primeravez = false;
        }

        if (Origen == "Revisar")
        {
            Texto = "Los datos del vehículo son: \n\n" +
                "Marca: " + Puma.Marca + "\n" +
                "Modelo: " + Puma.Modelo + "\n" +
                "Color: " + Puma.Color + "\n" +
                "Año: " + Puma.Anio + "\n" +
                "Placa: " + Puma.Placa + "\n" +
                "Tipo: " + Puma.Tipo + "\n" +
                "Frenos: " + Puma.Frenos + "\n" +
                "Navegación: " + Puma.Navegacion + "\n" +
                "Ventanas: " + Puma.Ventanas + "\n" +
                "Velocidad Máxima: " + Puma.VelocidadMaxima + " km/h\n";

            BtnEncender.IsVisible = false;
            BtnAcelerar.IsVisible = false;
            BtnBocina.IsVisible = false;
            BtnFrenar.IsVisible = false;
            BtnVentanas.IsVisible = false;
            BtnApagar.IsVisible = false;
        }

        else if (Origen == "Funciones")
        {
            BtnEncender.IsVisible = true;
            BtnAcelerar.IsVisible = true;
            BtnBocina.IsVisible = true;
            BtnFrenar.IsVisible = true;
            BtnVentanas.IsVisible = true;
            BtnApagar.IsVisible = true;
        }

        else if (Origen == "Editar")
        {
            BtnEncender.IsVisible = false;
            BtnAcelerar.IsVisible = false;
            BtnBocina.IsVisible = false;
            BtnFrenar.IsVisible = false;
            BtnVentanas.IsVisible = false;
            BtnApagar.IsVisible = false;
        }
        BindingContext = this;
    }

    private void BtnEncender_Clicked(object sender, EventArgs e)
    {
        Puma.Encender(Result);
    }

    private void BtnAcelerar_Clicked(object sender, EventArgs e)
    {
        Puma.Acelerar(55, Result);
    }

    private void BtnBocina_Clicked(object sender, EventArgs e)
    {
        Puma.Bocina(Result);
    }

    private void BtnFrenar_Clicked(object sender, EventArgs e)
    {
        Puma.Frenar(65, Result);
    }

    private void BtnVentanas_Clicked(object sender, EventArgs e)
    {
        Puma.AbrirVentanas(Result);
    }

    private void BtnApagar_Clicked(object sender, EventArgs e)
    {
        Puma.Apagar(Result);
    }

}