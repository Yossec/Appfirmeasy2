namespace Appfirmeasy.views.vistas;

public partial class Start : ContentPage
{
	public Start()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var nuevaPagina = new Login();
        await Navigation.PushAsync(nuevaPagina);

        Navigation.RemovePage(this);
    }
    private async void OnFrameTapped(object sender, EventArgs e)
    {
        var nuevaPagina = new Login();
        await Navigation.PushAsync(nuevaPagina);

        Navigation.RemovePage(this);
    }
}