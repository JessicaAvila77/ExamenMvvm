
using ExamenMvvm.Views;

namespace ExamenMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DescuentoCompraView());
        }
    }
}
