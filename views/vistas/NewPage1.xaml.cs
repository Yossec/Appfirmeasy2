namespace Appfirmeasy.views.vistas;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		
	}
    private async void OnFrameTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registro());

    }
    private async void OnLabelRegistro(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registro());
    }
}