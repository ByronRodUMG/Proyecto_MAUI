using Proyecto_MAUI.Clases;

namespace Proyecto_MAUI;

public partial class PageConvertible : ContentPage
{
    private bool primeravez = true;
    public string Origen;
    public string Texto { get; set; }

    Convertible F8;

    public PageConvertible()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (primeravez)
        {
            // Realiza la funcionalidad espec�fica la primera vez que se accede a la p�gina
            F8 = new(340)
            {
                Marca = "Ferrari",
                Modelo = "F8 Spider",
                Color = "Rojo",
                Anio = 2020,
                Placa = "F8S-2020",
                Tipo = "Convertible",
                Motor = "V8",
                Capota = "El�ctrica",
                Suspension = "Deportiva"
            };
            primeravez = false;
        }

        if (Origen=="Revisar")
        {
            Texto = "Los datos del veh�culo son: \n\n" +
                "Marca: " + F8.Marca + "\n" +
                "Modelo: " + F8.Modelo + "\n" +
                "Color: " + F8.Color + "\n" +
                "A�o: " + F8.Anio + "\n" +
                "Placa: " + F8.Placa + "\n" +
                "Tipo: " + F8.Tipo + "\n" +
                "Motor: " + F8.Motor + "\n" +
                "Capota: " + F8.Capota + "\n" +
                "Suspensi�n: " + F8.Suspension + "\n" +
                "Velocidad M�xima: " + F8.VelocidadMaxima + " km/h\n";

            BtnEncender.IsVisible = false;
            BtnAcelerar.IsVisible = false;
            BtnBocina.IsVisible = false;
            BtnFrenar.IsVisible = false;
            BtnCapota.IsVisible = false;
            BtnApagar.IsVisible = false;
        }

        else if (Origen=="Funciones")
        {
            BtnEncender.IsVisible = true;
            BtnAcelerar.IsVisible = true;
            BtnBocina.IsVisible = true;
            BtnFrenar.IsVisible = true;
            BtnCapota.IsVisible = true;
            BtnApagar.IsVisible = true;
        }

        else if (Origen=="Editar")
        {
            BtnEncender.IsVisible = false;
            BtnAcelerar.IsVisible = false;
            BtnBocina.IsVisible = false;
            BtnFrenar.IsVisible = false;
            BtnCapota.IsVisible = false;
            BtnApagar.IsVisible = false;
        }
        BindingContext = this;
    }

    private void BtnEncender_Clicked(object sender, EventArgs e)
    {
        //await DisplayAlert("Encender", "El veh�culo ha sido encendido", "OK");
        F8.Encender(Result);
    }

    private void BtnAcelerar_Clicked(object sender, EventArgs e)
    {
        F8.Acelerar(55, Result);
    }

    private void BtnBocina_Clicked(object sender, EventArgs e)
    {
        F8.Bocina(Result);
    }

    private void BtnFrenar_Clicked(object sender, EventArgs e)
    {
        F8.Frenar(65, Result);
    }

    private void BtnCapota_Clicked(object sender, EventArgs e)
    {
        F8.ActivarCapota(Result);
    }

    private void BtnApagar_Clicked(object sender, EventArgs e)
    {
        F8.Apagar(Result);
    }

}