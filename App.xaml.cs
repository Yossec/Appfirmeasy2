using Appfirmeasy.views.vistas;

namespace Appfirmeasy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Start());
        }
    }
}
