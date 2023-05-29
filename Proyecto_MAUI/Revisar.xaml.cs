namespace Proyecto_MAUI;

public partial class Revisar : ContentPage
{
	public Revisar()
	{
		InitializeComponent();
	}

    private async void BtnConvertible_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageConvertible { Origen = "Revisar"});

    }

    private async void BtnPickUp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PagePickUp { Origen = "Revisar"});

    }

    private async void BtnSedan_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageSedan { Origen = "Revisar" });

    }

    private async void BtnSUV_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageSUV{ Origen = "Revisar" });

    }
}