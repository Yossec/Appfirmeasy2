namespace Appfirmeasy.views.vistas;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}
    private async void OnFrameTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
        Navigation.RemovePage(this);
    }
}