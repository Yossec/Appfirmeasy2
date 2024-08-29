namespace Appfirmeasy.views.vistas;

public partial class Start : ContentPage
{
	public Start()
	{
		InitializeComponent();
	}

    private async void OnFrameTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage1());
        Navigation.RemovePage(this);
    }
}