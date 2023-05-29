namespace Proyecto_MAUI;

public partial class Funciones : ContentPage
{
	public Funciones()
	{
		InitializeComponent();
	}

    private async void BtnConvertible_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageConvertible{ Origen = "Funciones" });

    }

    private async void BtnPickUp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PagePickUp{ Origen = "Funciones" });

    }

    private async void BtnSedan_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageSedan { Origen = "Funciones" });

    }

    private async void BtnSUV_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageSUV{ Origen = "Funciones" });

    }
}