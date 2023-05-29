using Proyecto_MAUI.Clases;

namespace Proyecto_MAUI;

public partial class PageSedan : ContentPage
{
    private bool primeravez = true;
    public string Origen;
    public string Texto { get; set; }

    Sedan Corolla;

    public PageSedan()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (primeravez)
        {
            // Realiza la funcionalidad específica la primera vez que se accede a la página
            Corolla = new(180)
            {
                Marca = "Toyota",
                Modelo = "Corolla",
                Color = "Blanco",
                Anio = 2019,
                Placa = "COR-2019",
                Tipo = "Sedan",
                Entretenimiento = "Pantalla táctil",
                Luces = "LED",
                Traccion = "Delantera"
            };
            primeravez = false;
        }

        if (Origen == "Revisar")
        {
            Texto = "Los datos del vehículo son: \n\n" +
                "Marca: " + Corolla.Marca + "\n" +
                "Modelo: " + Corolla.Modelo + "\n" +
                "Color: " + Corolla.Color + "\n" +
                "Año: " + Corolla.Anio + "\n" +
                "Placa: " + Corolla.Placa + "\n" +
                "Tipo: " + Corolla.Tipo + "\n" +
                "Entretenimiento: " + Corolla.Entretenimiento + "\n" +
                "Luces: " + Corolla.Luces + "\n" +
                "Traccion: " + Corolla.Traccion + "\n" +
                "Velocidad Máxima: " + Corolla.VelocidadMaxima + " km/h\n";

            BtnEncender.IsVisible = false;
            BtnAcelerar.IsVisible = false;
            BtnBocina.IsVisible = false;
            BtnFrenar.IsVisible = false;
            BtnLuces.IsVisible = false;
            BtnApagar.IsVisible = false;
        }

        else if (Origen == "Funciones")
        {
            BtnEncender.IsVisible = true;
            BtnAcelerar.IsVisible = true;
            BtnBocina.IsVisible = true;
            BtnFrenar.IsVisible = true;
            BtnLuces.IsVisible = true;
            BtnApagar.IsVisible = true;
        }

        else if (Origen == "Editar")
        {
            BtnEncender.IsVisible = false;
            BtnAcelerar.IsVisible = false;
            BtnBocina.IsVisible = false;
            BtnFrenar.IsVisible = false;
            BtnLuces.IsVisible = false;
            BtnApagar.IsVisible = false;
        }
        BindingContext = this;
    }

    private void BtnEncender_Clicked(object sender, EventArgs e)
    {
        Corolla.Encender(Result);
    }

    private void BtnAcelerar_Clicked(object sender, EventArgs e)
    {
        Corolla.Acelerar(55, Result);
    }

    private void BtnBocina_Clicked(object sender, EventArgs e)
    {
        Corolla.Bocina(Result);
    }

    private void BtnFrenar_Clicked(object sender, EventArgs e)
    {
        Corolla.Frenar(65, Result);
    }

    private void BtnLuces_Clicked(object sender, EventArgs e)
    {
        Corolla.EncenderLuces(Result);
    }

    private void BtnApagar_Clicked(object sender, EventArgs e)
    {
        Corolla.Apagar(Result);
    }

}