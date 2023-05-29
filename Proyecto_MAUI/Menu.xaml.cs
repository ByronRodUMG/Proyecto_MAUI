using Proyecto_MAUI.Clases;

namespace Proyecto_MAUI;

public partial class Menu : ContentPage
{
    public Menu()
	{
		InitializeComponent();
	}

    private async void BtnRevisar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Revisar());

    }

    private async void BtnEditar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Editar());

    }

    private async void BtnFunciones_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Funciones());

    }

    private void BtnSalir_Clicked(object sender, EventArgs e)
    {
        Application.Current.Quit();

    }
}