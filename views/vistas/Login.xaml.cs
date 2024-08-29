namespace Appfirmeasy.views.vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
    }

    private async void OnLabelRegistro(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registro());
    }
}