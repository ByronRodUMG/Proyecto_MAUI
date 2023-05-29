using Proyecto_MAUI.Clases;

namespace Proyecto_MAUI;

public partial class PagePickUp : ContentPage
{
    private bool primeravez = true;
    public string Origen;
    public string Texto { get; set; }

    PickUp F150;

    public PagePickUp()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (primeravez)
        {
            // Realiza la funcionalidad específica la primera vez que se accede a la página
            F150 = new(175)
            {
                Marca = "Ford",
                Modelo = "F-150",
                Color = "Negro",
                Anio = 2020,
                Placa = "F15-2020",
                Tipo = "PickUp",
                Carga = "1 Tonelada",
                Escape = "Salida doble",
                Conectividad = "Wi-Fi"
            };
            primeravez = false;
        }

        if (Origen == "Revisar")
        {
            Texto = "Los datos del vehículo son: \n\n" +
                "Marca: " + F150.Marca + "\n" +
                "Modelo: " + F150.Modelo + "\n" +
                "Color: " + F150.Color + "\n" +
                "Año: " + F150.Anio + "\n" +
                "Placa: " + F150.Placa + "\n" +
                "Tipo: " + F150.Tipo + "\n" +
                "Carga: " + F150.Carga + "\n" +
                "Escape: " + F150.Escape + "\n" +
                "Conectividad: " + F150.Conectividad + "\n" +
                "Velocidad Máxima: " + F150.VelocidadMaxima + " km/h\n";

            BtnEncender.IsVisible = false;
            BtnAcelerar.IsVisible = false;
            BtnBocina.IsVisible = false;
            BtnFrenar.IsVisible = false;
            BtnWiFi.IsVisible = false;
            BtnApagar.IsVisible = false;
        }

        else if (Origen == "Funciones")
        {
            BtnEncender.IsVisible = true;
            BtnAcelerar.IsVisible = true;
            BtnBocina.IsVisible = true;
            BtnFrenar.IsVisible = true;
            BtnWiFi.IsVisible = true;
            BtnApagar.IsVisible = true;
        }

        else if (Origen == "Editar")
        {
            BtnEncender.IsVisible = false;
            BtnAcelerar.IsVisible = false;
            BtnBocina.IsVisible = false;
            BtnFrenar.IsVisible = false;
            BtnWiFi.IsVisible = false;
            BtnApagar.IsVisible = false;
        }
        BindingContext = this;
    }

    private void BtnEncender_Clicked(object sender, EventArgs e)
    {
        F150.Encender(Result);
    }

    private void BtnAcelerar_Clicked(object sender, EventArgs e)
    {
        F150.Acelerar(55, Result);
    }

    private void BtnBocina_Clicked(object sender, EventArgs e)
    {
        F150.Bocina(Result);
    }

    private void BtnFrenar_Clicked(object sender, EventArgs e)
    {
        F150.Frenar(65, Result);
    }

    private void BtnWiFi_Clicked(object sender, EventArgs e)
    {
        F150.ActivarWiFi(Result);
    }

    private void BtnApagar_Clicked(object sender, EventArgs e)
    {
        F150.Apagar(Result);
    }

}