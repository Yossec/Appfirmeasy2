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
    private async void OnLabelLogin(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());

    }
    private void OnLabelTapped(object sender, EventArgs e)
    {
        DisplayAlert("Términos y Condiciones", "Aquí irían los términos y condiciones.", "OK");
    }
}