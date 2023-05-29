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
            // Realiza la funcionalidad espec�fica la primera vez que se accede a la p�gina
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
                Ventanas = "El�ctricas",
            };
            primeravez = false;
        }

        if (Origen == "Revisar")
        {
            Texto = "Los datos del veh�culo son: \n\n" +
                "Marca: " + Puma.Marca + "\n" +
                "Modelo: " + Puma.Modelo + "\n" +
                "Color: " + Puma.Color + "\n" +
                "A�o: " + Puma.Anio + "\n" +
                "Placa: " + Puma.Placa + "\n" +
                "Tipo: " + Puma.Tipo + "\n" +
                "Frenos: " + Puma.Frenos + "\n" +
                "Navegaci�n: " + Puma.Navegacion + "\n" +
                "Ventanas: " + Puma.Ventanas + "\n" +
                "Velocidad M�xima: " + Puma.VelocidadMaxima + " km/h\n";

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