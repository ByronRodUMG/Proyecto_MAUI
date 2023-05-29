namespace Proyecto_MAUI;

public partial class Editar : ContentPage
{
	public Editar()
	{
		InitializeComponent();
	}

    private async void BtnConvertible_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageConvertible{ Origen = "Editar" });

    }

    private async void BtnPickUp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PagePickUp{ Origen = "Editar" });

    }

    private async void BtnSedan_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageSedan { Origen = "Editar" });

    }

    private async void BtnSUV_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageSUV{ Origen = "Editar" });

    }
}